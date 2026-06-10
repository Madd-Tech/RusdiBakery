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
using RusdiBakery.Views.Public.Panels.Components;

namespace RusdiBakery.Views.Public.Panels
{
    public partial class ProductList : UserControl
    {
        public ProductList()
        {
            InitializeComponent();
            button1.Click += (s, e) => LoadProducts(textBox1.Text);
            cartPanel1.OnTransactionComplete += () => LoadProducts(); // Refresh products (stock might change)
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts(string search = "")
        {
            productEntriesPanel.Controls.Clear();
            var products = ProductRepo.GetAll();

            if (!string.IsNullOrEmpty(search))
            {
                products = products.Where(p => p.ProductName.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            foreach (var product in products)
            {
                var card = new ProductCard();
                card.Initialize(product);
                card.OnOrderClicked += (p, qty) =>
                {
                    cartPanel1.AddToCart(p, qty);
                };
                productEntriesPanel.Controls.Add(card);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void productEntriesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cartPanel1_Load(object sender, EventArgs e)
        {

        }
    }
}
