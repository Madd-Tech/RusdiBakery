using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using RusdiBakery;
using RusdiBakery.repos;
using RusdiBakery.Views.Admin.Panels;
using RusdiBakery.Views.Public.Panels;

namespace RusdiBakery.Views.Admin
{
    public partial class AdminLayout : Form
    {
        private object panelContent;

        public AdminLayout()
        {
            InitializeComponent();
            MainPanels.Controls.Clear();
            MainPanels.Controls.Add(new Dashboard());



        }

        private void recipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanels.Controls.Clear();
            MainPanels.Controls.Add(new Product());
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanels.Controls.Clear();
            MainPanels.Controls.Add(new Transaction());
        }

        private void MainPanels_Paint(object sender, PaintEventArgs e)
        {
            int radius = 65;

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(MainPanels.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(MainPanels.Width - radius, MainPanels.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, MainPanels.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            MainPanels.Region = new Region(path);
        }

        private void filesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanels.Controls.Clear();
            MainPanels.Controls.Add(new Dashboard());
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanels.Controls.Clear();
            MainPanels.Controls.Add(new Stock());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Confirmation",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // Clear session if any (currently SessionManager only handles Customer, but it's good practice)
                SessionManager.Clear();

                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
        }
    }
}
