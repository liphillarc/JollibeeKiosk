using System;
using System.Drawing;
using System.Windows.Forms;
using JollibeeKiosk.Models;
using JollibeeKiosk.Services;
using JollibeeKiosk.Enums;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;

namespace JollibeeKiosk
{
    public class ReceiptItem
    {
        public string ProductName { get; set; } = string.Empty;
        public int Quantity { get; set; }
    }
    public partial class FormEditReceipt : Form
    {
        private ReceiptRecord _record;
        private BindingList<ReceiptItem> _itemsList;

        public FormEditReceipt(ReceiptRecord record)
        {
            InitializeComponent();
            _record = record;
            
            txtTotal.Text = _record.TotalAmount.ToString("F2");
            txtDiscount.Text = _record.DiscountAmount.ToString("F2");
            txtOrderType.Text = _record.OrderType;
            
            _itemsList = new BindingList<ReceiptItem>();
            LoadItems(_record.ItemsDetails);
            
            dgvItems.DataSource = _itemsList;
            dgvItems.Columns["ProductName"].HeaderText = "Product Name";
            dgvItems.Columns["Quantity"].HeaderText = "Qty";
        }

        private void LoadItems(string details)
        {
            if (string.IsNullOrWhiteSpace(details)) return;
            
            var items = details.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in items)
            {
                var parts = item.Split(new[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2 && int.TryParse(parts[1], out int qty))
                {
                    _itemsList.Add(new ReceiptItem { ProductName = parts[0], Quantity = qty });
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTotal.Text, out decimal newTotal) &&
                decimal.TryParse(txtDiscount.Text, out decimal newDiscount))
            {
                _record.TotalAmount = newTotal;
                _record.DiscountAmount = newDiscount;
                _record.OrderType = txtOrderType.Text.Trim();
                
                // Reconstruct ItemsDetails from grid
                var sb = new StringBuilder();
                foreach (var item in _itemsList)
                {
                    if (sb.Length > 0) sb.Append(", ");
                    sb.Append($"{item.ProductName}: {item.Quantity}");
                }
                _record.ItemsDetails = sb.ToString();

                DatabaseService.UpdateReceipt(_record);
                MessageBox.Show("Receipt updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for Total and Discount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

