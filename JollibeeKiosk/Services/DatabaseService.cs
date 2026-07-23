using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using JollibeeKiosk.Models;
using JollibeeKiosk.Enums;

namespace JollibeeKiosk.Services
{
    public class ReceiptRecord
    {
        public long Id { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public string OrderType { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
        public string ItemsDetails { get; set; } = string.Empty;
    }

    public static class DatabaseService
    {
        private static string _masterConnectionString = "";
        private static string _connectionString = "";

        private static readonly string[] PossibleServers = new[]
        {
            ".",
            ".\\SQLEXPRESS",
            "(localdb)\\MSSQLLocalDB"
        };

        private static bool TryFindWorkingServer()
        {
            // We force (localdb)\MSSQLLocalDB so that the database creates an MDF file we can share via the repository
            string server = "(localdb)\\MSSQLLocalDB";
            _masterConnectionString = $"Server={server};Database=master;Integrated Security=True;TrustServerCertificate=True;";
            
            // Find the project directory to save the database file so it gets pushed to GitHub
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string projectDir = System.IO.Directory.GetParent(baseDir)?.Parent?.Parent?.Parent?.FullName ?? baseDir;
            string dbPath = System.IO.Path.Combine(projectDir, "JollibeeKioskDB.mdf");

            _connectionString = $"Server={server};Integrated Security=True;TrustServerCertificate=True;AttachDbFilename={dbPath};";

            try
            {
                using var conn = new SqlConnection(_masterConnectionString);
                conn.Open();
                
                // If the file doesn't exist on disk, we must create it using the master database
                if (!System.IO.File.Exists(dbPath))
                {
                    var cmd = conn.CreateCommand();
                    // Clean up any broken references in LocalDB
                    cmd.CommandText = @"
                        IF EXISTS (SELECT name FROM sys.databases WHERE name = N'JollibeeKioskDB')
                        BEGIN
                            ALTER DATABASE [JollibeeKioskDB] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                            DROP DATABASE [JollibeeKioskDB];
                        END";
                    cmd.ExecuteNonQuery();

                    // Create the physical file in the project directory
                    cmd.CommandText = $"CREATE DATABASE [JollibeeKioskDB] ON PRIMARY (NAME = JollibeeKioskDB_Data, FILENAME = '{dbPath}')";
                    cmd.ExecuteNonQuery();
                }
                
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void InitializeDatabase()
        {
            try
            {
                if (!TryFindWorkingServer())
                {
                    throw new Exception("Could not connect to LocalDB. Make sure you have SQL Server Express LocalDB installed on your computer!");
                }

                // Next, ensure the Receipts table exists
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandText = @"
                        IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Receipts' and xtype='U')
                        BEGIN
                            CREATE TABLE Receipts (
                                Id BIGINT IDENTITY(1,1) PRIMARY KEY,
                                TotalAmount DECIMAL(18,2) NOT NULL,
                                DiscountAmount DECIMAL(18,2) NOT NULL,
                                OrderType NVARCHAR(50) NOT NULL,
                                OrderDate DATETIME NOT NULL,
                                ItemsDetails NVARCHAR(MAX) NOT NULL DEFAULT ''
                            )
                        END
                        ELSE
                        BEGIN
                            IF COL_LENGTH('Receipts', 'ItemsDetails') IS NULL
                            BEGIN
                                ALTER TABLE Receipts ADD ItemsDetails NVARCHAR(MAX) NOT NULL DEFAULT '';
                            END
                        END
                    ";
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Automatic Database Connection Failed!\n\n" +
                    "Error Details:\n" + ex.Message,
                    "Database Connection Error",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public static long InsertOrder(Order order)
        {
            if (string.IsNullOrEmpty(_connectionString)) return 0;
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = @"
                INSERT INTO Receipts (TotalAmount, DiscountAmount, OrderType, OrderDate, ItemsDetails)
                VALUES (@TotalAmount, @DiscountAmount, @OrderType, @OrderDate, @ItemsDetails);
                SELECT SCOPE_IDENTITY();
            ";
            
            command.Parameters.AddWithValue("@TotalAmount", order.GetTotal());
            command.Parameters.AddWithValue("@DiscountAmount", order.DiscountAmount);
            command.Parameters.AddWithValue("@OrderType", order.OrderType.ToString());
            command.Parameters.AddWithValue("@OrderDate", DateTime.Now);

            // Generate items details string like "Burger: 2, Fries: 1"
            var itemsList = new System.Collections.Generic.List<string>();
            foreach (var oi in order.Items)
            {
                itemsList.Add($"{oi.Item.Name}: {oi.Quantity}");
            }
            command.Parameters.AddWithValue("@ItemsDetails", string.Join(", ", itemsList));

            var newIdObj = command.ExecuteScalar();
            if (newIdObj != null && newIdObj != DBNull.Value)
            {
                return Convert.ToInt64(newIdObj);
            }
            return 0;
        }

        public static void UpdateReceipt(ReceiptRecord record)
        {
            if (string.IsNullOrEmpty(_connectionString)) return;
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = @"
                UPDATE Receipts 
                SET TotalAmount = @TotalAmount, 
                    DiscountAmount = @DiscountAmount, 
                    OrderType = @OrderType, 
                    ItemsDetails = @ItemsDetails
                WHERE Id = @Id;
            ";
            
            command.Parameters.AddWithValue("@TotalAmount", record.TotalAmount);
            command.Parameters.AddWithValue("@DiscountAmount", record.DiscountAmount);
            command.Parameters.AddWithValue("@OrderType", record.OrderType);
            command.Parameters.AddWithValue("@ItemsDetails", record.ItemsDetails);
            command.Parameters.AddWithValue("@Id", record.Id);
            command.ExecuteNonQuery();
        }

        public static List<ReceiptRecord> GetAllReceipts()
        {
            var list = new List<ReceiptRecord>();

            try 
            {
                if (string.IsNullOrEmpty(_connectionString)) return list;
                using var connection = new SqlConnection(_connectionString);
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "SELECT Id, TotalAmount, DiscountAmount, OrderType, OrderDate, ItemsDetails FROM Receipts ORDER BY Id DESC";

                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new ReceiptRecord
                    {
                        Id = reader.GetInt64(0),
                        TotalAmount = reader.GetDecimal(1),
                        DiscountAmount = reader.GetDecimal(2),
                        OrderType = reader.GetString(3),
                        OrderDate = reader.GetDateTime(4),
                        ItemsDetails = reader.IsDBNull(5) ? "" : reader.GetString(5)
                    });
                }
            }
            catch 
            {
                // In case table isn't created yet or other error, return empty list
            }

            return list;
        }

        public static void DeleteAllRecords()
        {
            if (string.IsNullOrEmpty(_connectionString)) return;
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "TRUNCATE TABLE Receipts;";
            command.ExecuteNonQuery();
        }
    }
}
