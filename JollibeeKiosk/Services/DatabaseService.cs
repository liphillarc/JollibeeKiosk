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
            foreach (var server in PossibleServers)
            {
                string testMaster = $"Server={server};Database=master;Integrated Security=True;TrustServerCertificate=True;";
                try
                {
                    using var conn = new SqlConnection(testMaster);
                    conn.Open();
                    _masterConnectionString = testMaster;
                    _connectionString = $"Server={server};Database=JollibeeKioskDB;Integrated Security=True;TrustServerCertificate=True;";
                    return true;
                }
                catch
                {
                    // Ignore and try the next one
                }
            }
            return false;
        }

        public static void InitializeDatabase()
        {
            try
            {
                if (!TryFindWorkingServer())
                {
                    throw new Exception("Could not find a running local SQL Server instance (tried ., .\\SQLEXPRESS, and (localdb)\\MSSQLLocalDB).");
                }

                // First, ensure the database exists
                using (var masterConnection = new SqlConnection(_masterConnectionString))
                {
                    masterConnection.Open();
                    var cmd = masterConnection.CreateCommand();
                    cmd.CommandText = @"
                        IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'JollibeeKioskDB')
                        BEGIN
                            CREATE DATABASE [JollibeeKioskDB];
                        END";
                    cmd.ExecuteNonQuery();
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
