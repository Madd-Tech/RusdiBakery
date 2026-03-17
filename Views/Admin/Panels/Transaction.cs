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
    public partial class Transaction : UserControl
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int radius = 40;

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel1.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel1.Width - radius, panel1.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel1.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            panel1.Region = new Region(path);
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            int radius = 40;

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel3.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel3.Width - radius, panel3.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel3.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            panel3.Region = new Region(path);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            int radius = 40;

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel4.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel4.Width - radius, panel4.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel4.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            panel4.Region = new Region(path);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
