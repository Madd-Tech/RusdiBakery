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

namespace RusdiBakery.Views.Public.Panels.Components
{
    public partial class CartPanel : UserControl
    {
        private List<CartItem> _cartItems = new List<CartItem>();
        public event Action? OnTransactionComplete;

        public CartPanel()
        {
            InitializeComponent();
            buttonClear.Click += (s, e) => ClearCart();
            buttonRemove.Click += (s, e) => RemoveSelected();
            buttonCheckout.Click += (s, e) => Checkout();
        }

        public void AddToCart(Product product, int qty)
        {
            var existing = _cartItems.FirstOrDefault(i => i.ProductId == product.IdProduct);
            if (existing != null)
            {
                existing.Qty += qty;
            }
            else
            {
                _cartItems.Add(new CartItem
                {
                    ProductId = product.IdProduct,
                    ProductName = product.ProductName,
                    Qty = qty,
                    Price = product.Price
                });
            }
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _cartItems.Select(i => new {
                i.ProductName,
                i.Qty,
                i.Price,
                i.Subtotal
            }).ToList();

            double total = _cartItems.Sum(i => i.Subtotal);
            labelTotal.Text = $"Total: IDR {total:N0}";
        }

        private void ClearCart()
        {
            _cartItems.Clear();
            RefreshGrid();
        }

        private void RemoveSelected()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var value = dataGridView1.SelectedRows[0].Cells["ProductName"].Value;
                if (value != null)
                {
                    string productName = value.ToString() ?? "";
                    _cartItems.RemoveAll(i => i.ProductName == productName);
                    RefreshGrid();
                }
            }
        }

        private void Checkout()
        {
            if (!_cartItems.Any())
            {
                MessageBox.Show("Keranjang belanja kosong.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Pastikan customer sudah login
            if (!SessionManager.IsLoggedIn)
            {
                MessageBox.Show("Silakan login terlebih dahulu sebelum melakukan transaksi.", "Login Diperlukan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double grandTotal = _cartItems.Sum(i => i.Subtotal);
            var result = MessageBox.Show(
                $"Konfirmasi pembelian?\n\nTotal: IDR {grandTotal:N0}",
                "Checkout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool allSuccess = true;
                string lastError = "";

                foreach (var item in _cartItems)
                {
                    var transaction = new Transaction
                    {
                        IdProduct = item.ProductId,
                        IdCustomer = SessionManager.CurrentCustomer!.IdCustomer, // FIX: set customer dari session
                        Qty = item.Qty,
                        Total = item.Subtotal
                    };

                    var response = TransactionRepo.Create(transaction);
                    if (!response.success)
                    {
                        allSuccess = false;
                        lastError = response.message;
                        break;
                    }
                }

                if (allSuccess)
                {
                    MessageBox.Show("Transaksi berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearCart();
                    OnTransactionComplete?.Invoke();
                }
                else
                {
                    MessageBox.Show("Transaksi gagal: " + lastError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}