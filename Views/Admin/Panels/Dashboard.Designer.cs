namespace RusdiBakery.Views.Admin.Panels
{
    partial class Dashboard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            secondpanel = new Panel();
            thirdpanel = new Panel();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            secondpanel.SuspendLayout();
            thirdpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.download__21___1_;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(38, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(705, 543);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LavenderBlush;
            label1.Location = new Point(35, 177);
            label1.Name = "label1";
            label1.Size = new Size(215, 32);
            label1.TabIndex = 0;
            label1.Text = "Orders History";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // secondpanel
            // 
            secondpanel.BackColor = Color.Orchid;
            secondpanel.Controls.Add(label4);
            secondpanel.Controls.Add(label3);
            secondpanel.Location = new Point(784, 41);
            secondpanel.Name = "secondpanel";
            secondpanel.Size = new Size(390, 132);
            secondpanel.TabIndex = 1;
            secondpanel.Paint += secondpanel_Paint;
            // 
            // thirdpanel
            // 
            thirdpanel.BackColor = Color.MediumOrchid;
            thirdpanel.Controls.Add(label7);
            thirdpanel.Controls.Add(label6);
            thirdpanel.Controls.Add(label5);
            thirdpanel.Location = new Point(784, 218);
            thirdpanel.Name = "thirdpanel";
            thirdpanel.Size = new Size(390, 271);
            thirdpanel.TabIndex = 2;
            thirdpanel.Paint += panel2_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 219);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(633, 277);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cooper Black", 20F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LavenderBlush;
            label2.Location = new Point(35, 20);
            label2.Name = "label2";
            label2.Size = new Size(558, 46);
            label2.TabIndex = 2;
            label2.Text = "Admin Dashboard Control";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LavenderBlush;
            label3.Location = new Point(17, 20);
            label3.Name = "label3";
            label3.Size = new Size(211, 32);
            label3.TabIndex = 3;
            label3.Text = "Total Revenue";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LavenderBlush;
            label4.Location = new Point(250, 84);
            label4.Name = "label4";
            label4.Size = new Size(115, 32);
            label4.TabIndex = 4;
            label4.Text = "$ 74.00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LavenderBlush;
            label5.Location = new Point(17, 23);
            label5.Name = "label5";
            label5.Size = new Size(336, 32);
            label5.TabIndex = 5;
            label5.Text = "Total Product Available";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LavenderBlush;
            label6.Location = new Point(27, 90);
            label6.Name = "label6";
            label6.Size = new Size(65, 32);
            label6.TabIndex = 5;
            label6.Text = "245";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.LavenderBlush;
            label7.Location = new Point(17, 198);
            label7.Name = "label7";
            label7.Size = new Size(206, 32);
            label7.TabIndex = 6;
            label7.Text = "Categories : 6";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.LavenderBlush;
            label8.Location = new Point(332, 184);
            label8.Name = "label8";
            label8.Size = new Size(92, 23);
            label8.TabIndex = 4;
            label8.Text = "Sort By :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "A - Z", "Z - A", "Most Ordered" });
            comboBox1.Location = new Point(430, 177);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(238, 33);
            comboBox1.TabIndex = 5;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(thirdpanel);
            Controls.Add(secondpanel);
            Controls.Add(panel1);
            Name = "Dashboard";
            Size = new Size(1220, 633);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            secondpanel.ResumeLayout(false);
            secondpanel.PerformLayout();
            thirdpanel.ResumeLayout(false);
            thirdpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private NotifyIcon notifyIcon1;
        private Panel secondpanel;
        private Panel thirdpanel;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private ComboBox comboBox1;
        private Label label8;
        private Label label7;
    }
}
