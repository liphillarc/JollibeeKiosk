using System;
using System.Linq;
using System.Windows.Forms;
using JollibeeKiosk.Services;

namespace JollibeeKiosk
{
    public class ProductSales
    {
        public string Product { get; set; } = string.Empty;
        public int QuantitySold { get; set; }
    }

    public partial class FormSales : Form
    {
        private readonly Form _opener;

        public FormSales(Form opener)
        {
            _opener = opener;
            InitializeComponent();
        }

        private void FormSales_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var records = DatabaseService.GetAllReceipts();
            dgvSales.DataSource = records;

            if (dgvSales.Columns["TotalAmount"] != null)
                dgvSales.Columns["TotalAmount"].DefaultCellStyle.Format = "C2";
            
            if (dgvSales.Columns["DiscountAmount"] != null)
                dgvSales.Columns["DiscountAmount"].DefaultCellStyle.Format = "C2";
            
            if (dgvSales.Columns["OrderDate"] != null)
                dgvSales.Columns["OrderDate"].DefaultCellStyle.Format = "g";

            decimal totalSales = records.Sum(r => r.TotalAmount);
            lblTotalSales.Text = $"TOTAL SALES: ₱{totalSales:F2}";

            // Calculate aggregate product sales
            var productDict = new System.Collections.Generic.Dictionary<string, int>();
            foreach (var record in records)
            {
                if (string.IsNullOrWhiteSpace(record.ItemsDetails)) continue;
                var items = record.ItemsDetails.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in items)
                {
                    var parts = item.Split(new[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length == 2 && int.TryParse(parts[1], out int qty))
                    {
                        if (productDict.ContainsKey(parts[0]))
                            productDict[parts[0]] += qty;
                        else
                            productDict[parts[0]] = qty;
                    }
                }
            }
            var productSalesList = productDict.Select(kvp => new ProductSales { Product = kvp.Key, QuantitySold = kvp.Value })
                                              .OrderByDescending(x => x.QuantitySold)
                                              .ToList();
            dgvProducts.DataSource = productSalesList;
            if (dgvProducts.Columns["QuantitySold"] != null)
                dgvProducts.Columns["QuantitySold"].HeaderText = "Qty";
        }

        private void DgvSales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var record = (ReceiptRecord)dgvSales.Rows[e.RowIndex].DataBoundItem;
                var editForm = new FormEditReceipt(record);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadData(); // Refresh grid
                }
            }
        }

        private void BtnDeleteAll_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to delete ALL records? This action cannot be undone.",
                "Delete All Records",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DatabaseService.DeleteAllRecords();
                MessageBox.Show("All records have been successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }



        private void BtnBack_Click(object sender, EventArgs e)
        {
            _opener.Show();
            this.Close();
        }
    }
}

