using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using RusdiBakery.repos;
using ProductModel = RusdiBakery.Models.Product;

namespace RusdiBakery.Views.Admin.Panels
{
    public partial class Product : UserControl
    {
        private int? _selectedProductId = null;

        public Product()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ShapeButton(Button btn, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            btn.Region = new Region(path);
        }

        private void ShapeButtons()
        {
            ShapeButton(button1, 30);
            ShapeButton(button2, 30);
            ShapeButton(button3, 30);
            ShapeButton(button4, 30);
        }

        private void Product_Load(object sender, EventArgs e)
        {
            ShapeButtons();

            // Set up GridView settings for a clean premium UX
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Wire up combobox changed event
            comboBox1.SelectedIndexChanged += (s, ev) => LoadProducts();

            // Set initial sort dropdown selection
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                LoadProducts();
            }
        }

        private void LoadProducts()
        {
            try
            {
                string sortBy = comboBox1.SelectedItem?.ToString() ?? "A - Z";
                var products = ProductRepo.GetAll(sortBy);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = products;

                // Configure grid columns nicely
                if (dataGridView1.Columns["IdProduct"] != null)
                {
                    dataGridView1.Columns["IdProduct"].HeaderText = "Product ID";
                    dataGridView1.Columns["IdProduct"].Width = 100;
                }
                if (dataGridView1.Columns["ProductName"] != null)
                {
                    dataGridView1.Columns["ProductName"].HeaderText = "Product Name";
                }
                if (dataGridView1.Columns["Price"] != null)
                {
                    dataGridView1.Columns["Price"].HeaderText = "Price";
                    dataGridView1.Columns["Price"].DefaultCellStyle.Format = "C0"; // Currency format
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load products: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            _selectedProductId = null;
            label4.Text = "Add New Product";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int radius = 55;

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel1.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel1.Width - radius, panel1.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel1.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            panel1.Region = new Region(path);
        }

        private void thirdpanel_Paint(object sender, PaintEventArgs e)
        {
            int radius = 40;

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(thirdpanel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(thirdpanel.Width - radius, thirdpanel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, thirdpanel.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            thirdpanel.Region = new Region(path);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            int radius = 40;

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel2.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel2.Width - radius, panel2.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel2.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            panel2.Region = new Region(path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShapeButton(button2, 30);

            if (dataGridView1.SelectedRows.Count > 0)
            {
                var product = dataGridView1.SelectedRows[0].DataBoundItem as ProductModel;
                if (product != null)
                {
                    var confirmResult = MessageBox.Show($"Are you sure you want to delete '{product.ProductName}'?",
                                                        "Confirm Delete",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {
                            if (ProductRepo.Delete(product.IdProduct))
                            {
                                MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearForm();
                                LoadProducts();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error deleting product: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product from the list to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShapeButton(button1, 30);

            if (dataGridView1.SelectedRows.Count > 0)
            {
                var product = dataGridView1.SelectedRows[0].DataBoundItem as ProductModel;
                if (product != null)
                {
                    _selectedProductId = product.IdProduct;
                    textBox1.Text = product.ProductName;
                    textBox2.Text = product.Price.ToString();
                    label4.Text = "Edit Product";
                }
            }
            else
            {
                MessageBox.Show("Please select a product from the list to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShapeButton(button3, 30);
            ClearForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShapeButton(button4, 30);

            string name = textBox1.Text.Trim();
            string priceText = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Product name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(priceText, out double price) || price < 0)
            {
                MessageBox.Show("Please enter a valid positive price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_selectedProductId.HasValue)
                {
                    // Update Mode
                    var product = new ProductModel
                    {
                        IdProduct = _selectedProductId.Value,
                        ProductName = name,
                        Price = price
                    };

                    if (ProductRepo.Update(product))
                    {
                        MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        LoadProducts();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Add Mode
                    var product = new ProductModel
                    {
                        ProductName = name,
                        Price = price
                    };

                    if (ProductRepo.Create(product))
                    {
                        MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        LoadProducts();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving product: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
