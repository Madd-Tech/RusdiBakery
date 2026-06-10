using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RusdiBakery.repos;

namespace RusdiBakery.Views.Admin.Panels
{
    public partial class Transaction : UserControl
    {
        public Transaction()
        {
            InitializeComponent();
            this.Load += Transaction_Load;
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            LoadTransactions();
        }

        private void LoadTransactions()
        {
            try
            {
                var transactions = TransactionRepo.GetAll();

                // Tampilkan data transaksi ke DataGridView
                dataGridView1.DataSource = transactions.Select(t => new
                {
                    ID = t.IdTransaction,
                    Produk = t.Product?.ProductName ?? "Unknown",
                    Customer = t.Customer?.Username ?? "Guest",
                    Qty = t.Qty,
                    Total = t.Total
                }).ToList();

                if (dataGridView1.Columns.Contains("Total"))
                {
                    dataGridView1.Columns["Total"].DefaultCellStyle.Format = "N0";
                    dataGridView1.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView1.Columns["Total"].HeaderText = "Total (IDR)";
                }

                // Update summary labels
                label1.Text = transactions.Count.ToString();   // Total Orders count
                label3.Text = transactions.Count.ToString();   // New Orders
                double revenue = TransactionRepo.GetTotalRevenue();
                label7.Text = $"{revenue / 1000:N0}K";        // Revenue summary
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data transaksi: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e) => PaintRounded(panel1, e);
        private void panel2_Paint(object sender, PaintEventArgs e) => PaintRounded(panel2, e);
        private void panel3_Paint(object sender, PaintEventArgs e) => PaintRounded(panel3, e);
       

        private static void PaintRounded(Panel panel, PaintEventArgs e)
        {
            int radius = 40;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }

        private void label3_Click(object sender, EventArgs e) { }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}