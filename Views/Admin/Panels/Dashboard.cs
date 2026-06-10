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
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            this.Load += Dashboard_Load;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private void Dashboard_Load(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Load Transaction History
            var transactions = TransactionRepo.GetAll();
            UpdateGrid(transactions);

            // Load Revenue
            double totalRevenue = TransactionRepo.GetTotalRevenue();
            label4.Text = totalRevenue.ToString("N0");

            // Load Total Products
            var products = ProductRepo.GetAll();
            label6.Text = products.Count.ToString();
        }

        private void UpdateGrid(List<RusdiBakery.Models.Transaction> transactions)
        {
            dataGridView1.DataSource = transactions.Select(t => new
            {
                Code = t.TransactionCode,
                Product = t.Product?.ProductName,
                Qty = t.Qty,
                Total = t.Total
            }).ToList();
            
            // UI Cleanup
            if (dataGridView1.Columns["Total"] != null)
                dataGridView1.Columns["Total"].DefaultCellStyle.Format = "N0";
        }

        private void ComboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string? sortBy = comboBox1.SelectedItem?.ToString();
            var transactions = TransactionRepo.GetAll();

            if (sortBy == "A - Z")
            {
                transactions = transactions.OrderBy(t => t.Product?.ProductName).ToList();
            }
            else if (sortBy == "Z - A")
            {
                transactions = transactions.OrderByDescending(t => t.Product?.ProductName).ToList();
            }
            
            UpdateGrid(transactions);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int radius = 50;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel1.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel1.Width - radius, panel1.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel1.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            panel1.Region = new Region(path);
        }

        private void secondpanel_Paint(object sender, PaintEventArgs e)
        {
            int radius = 50;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(secondpanel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(secondpanel.Width - radius, secondpanel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, secondpanel.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            secondpanel.Region = new Region(path);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            int radius = 50;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(thirdpanel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(thirdpanel.Width - radius, thirdpanel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, thirdpanel.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            thirdpanel.Region = new Region(path);
        }

        private void label6_Click(object sender, EventArgs e) { }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) { }
    }
}
