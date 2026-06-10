using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RusdiBakery.Models;

namespace RusdiBakery.Views.Public.Panels.Components
{
    public partial class ProductCard : UserControl
    {
        public Product? ProductData { get; private set; }
        public event Action<Product, int>? OnOrderClicked;

        public ProductCard()
        {
            InitializeComponent();
            button1.Enabled = false;
            textBox1.TextChanged += (s, e) => ValidateQty();
            button1.Click += (s, e) => {
                if (ProductData != null && int.TryParse(textBox1.Text, out int qty))
                {
                    OnOrderClicked?.Invoke(ProductData, qty);
                    textBox1.Clear();
                }
            };
        }

        public void Initialize(Product product)
        {
            ProductData = product;
            label1.Text = product.ProductName;
            label3.Text = product.Price.ToString("N0");
        }

        private void ValidateQty()
        {
            if (int.TryParse(textBox1.Text, out int qty) && qty > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
