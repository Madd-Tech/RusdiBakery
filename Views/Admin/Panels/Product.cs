using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace RusdiBakery.Views.Admin.Panels
{
    public partial class Product : UserControl
    {
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

        private void Product_Load(object sender, EventArgs e)
        {

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
            int radius = 30;

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button2.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(button2.Width - radius, button2.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, button2.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            button2.Region = new Region(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int radius = 30;

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button1.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(button1.Width - radius, button1.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, button1.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            button1.Region = new Region(path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int radius = 30;

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button3.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(button3.Width - radius, button3.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, button3.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            button3.Region = new Region(path);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int radius = 30;

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button4.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(button4.Width - radius, button4.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, button4.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            button4.Region = new Region(path);
        }
    }
}
