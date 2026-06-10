using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RusdiBakery.Models;
using RusdiBakery.repos;

namespace RusdiBakery.Views.Admin.Panels
{
    public partial class Stock : UserControl
    {
        private int? _selectedStockId = null;

        public Stock()
        {
            InitializeComponent();
            this.Load += Stock_Load;
            button1.Click += Button1_Click; // Add
            button2.Click += Button2_Click; // Update
            button3.Click += Button3_Click; // Delete
            button4.Click += (s, e) => ClearInputs(); // Clear
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void Stock_Load(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Load Stocks into DataGridView
            var stocks = StockRepo.GetAll();
            dataGridView1.DataSource = stocks.Select(s => new
            {
                ID = s.IdStock,
                Product = s.Product?.ProductName,
                Quantity = s.StockQty
            }).ToList();

            // Load Products into ComboBox (only those without stock)
            var products = ProductRepo.GetProductsWithoutStock();
            comboBox1.DataSource = products;
            comboBox1.DisplayMember = "ProductName";
            comboBox1.ValueMember = "IdProduct";
            comboBox1.SelectedIndex = -1;

            // Reset inputs
            textBox1.Clear();
            _selectedStockId = null;
            comboBox1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            if (!int.TryParse(textBox1.Text, out int qty) || qty < 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            var stock = new RusdiBakery.Models.Stock
            {
                IdProduct = (int)comboBox1.SelectedValue,
                StockQty = qty
            };

            if (StockRepo.Create(stock))
            {
                MessageBox.Show("Stock added successfully.");
                LoadData();
            }
            else
            {
                MessageBox.Show("Failed to add stock.");
            }
        }

        private void Button2_Click(object? sender, EventArgs e)
        {
            if (_selectedStockId == null)
            {
                MessageBox.Show("Please select a stock entry to update.");
                return;
            }

            if (!int.TryParse(textBox1.Text, out int qty) || qty < 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            var stock = new RusdiBakery.Models.Stock
            {
                IdStock = _selectedStockId.Value,
                StockQty = qty
            };

            if (StockRepo.Update(stock))
            {
                MessageBox.Show("Stock updated successfully.");
                LoadData();
            }
            else
            {
                MessageBox.Show("Failed to update stock.");
            }
        }

        private void Button3_Click(object? sender, EventArgs e)
        {
            if (_selectedStockId == null)
            {
                MessageBox.Show("Please select a stock entry to delete.");
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this stock entry?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (StockRepo.Delete(_selectedStockId.Value))
                {
                    MessageBox.Show("Stock deleted successfully.");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Failed to delete stock.");
                }
            }
        }

        private void DataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                _selectedStockId = (int)row.Cells["ID"].Value;
                textBox1.Text = row.Cells["Quantity"].Value.ToString();

                string productName = row.Cells["Product"].Value?.ToString() ?? "";

                // Show the product in ComboBox even if it's already in stock (for viewing during update)
                var products = ProductRepo.GetAll(); // Get all products to ensure we can find the one in stock
                comboBox1.DataSource = products;
                comboBox1.DisplayMember = "ProductName";
                comboBox1.ValueMember = "IdProduct";

                // Find and select the product
                foreach (var item in products)
                {
                    if (item.ProductName == productName)
                    {
                        comboBox1.SelectedItem = item;
                        break;
                    }
                }

                comboBox1.Enabled = false; // Disable product change on update
                button1.Enabled = false;   // Disable Add button
                button2.Enabled = true;    // Enable Update button
                button3.Enabled = true;    // Enable Delete button
            }
        }

        private void ClearInputs()
        {
            LoadData(); // LoadData already handles resetting
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

