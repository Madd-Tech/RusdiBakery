namespace RusdiBakery.Views.Admin.Panels
{
    partial class Product
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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label8 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            thirdpanel = new Panel();
            label6 = new Label();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            label3 = new Label();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            thirdpanel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.download__21___1_;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(39, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(705, 543);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.PaleTurquoise;
            button2.Location = new Point(502, 467);
            button2.Name = "button2";
            button2.Size = new Size(166, 56);
            button2.TabIndex = 9;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 192);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.PaleTurquoise;
            button1.Location = new Point(35, 467);
            button1.Name = "button1";
            button1.Size = new Size(166, 56);
            button1.TabIndex = 8;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "A - Z", "Z - A", "Most Ordered" });
            comboBox1.Location = new Point(430, 112);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(238, 33);
            comboBox1.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.LavenderBlush;
            label8.Location = new Point(333, 122);
            label8.Name = "label8";
            label8.Size = new Size(92, 23);
            label8.TabIndex = 4;
            label8.Text = "Sort By :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cooper Black", 20F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LavenderBlush;
            label2.Location = new Point(35, 20);
            label2.Name = "label2";
            label2.Size = new Size(602, 46);
            label2.TabIndex = 2;
            label2.Text = "Admin Product Management";
            label2.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(633, 277);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LavenderBlush;
            label1.Location = new Point(47, 113);
            label1.Name = "label1";
            label1.Size = new Size(112, 32);
            label1.TabIndex = 0;
            label1.Text = "Entries";
            // 
            // thirdpanel
            // 
            thirdpanel.BackColor = Color.MediumOrchid;
            thirdpanel.BackgroundImage = Properties.Resources.Diamond_Close_up_Mobile_Wallpaper;
            thirdpanel.Controls.Add(label6);
            thirdpanel.Controls.Add(textBox1);
            thirdpanel.Controls.Add(comboBox2);
            thirdpanel.Controls.Add(label3);
            thirdpanel.Location = new Point(788, 90);
            thirdpanel.Name = "thirdpanel";
            thirdpanel.Size = new Size(390, 355);
            thirdpanel.TabIndex = 3;
            thirdpanel.Paint += thirdpanel_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LavenderBlush;
            label6.Location = new Point(38, 173);
            label6.Name = "label6";
            label6.Size = new Size(133, 28);
            label6.TabIndex = 8;
            label6.Text = "Category :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(38, 74);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(312, 36);
            textBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "A - Z", "Z - A", "Most Ordered" });
            comboBox2.Location = new Point(38, 204);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(312, 33);
            comboBox2.TabIndex = 6;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LavenderBlush;
            label3.Location = new Point(38, 33);
            label3.Name = "label3";
            label3.Size = new Size(185, 28);
            label3.TabIndex = 6;
            label3.Text = "Product Name:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumOrchid;
            panel2.BackgroundImage = Properties.Resources.Diamond_Close_up_Mobile_Wallpaper;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Location = new Point(788, 497);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 88);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 192, 0);
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.PaleTurquoise;
            button4.Location = new Point(252, 20);
            button4.Name = "button4";
            button4.Size = new Size(118, 53);
            button4.TabIndex = 11;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Plum;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.PaleTurquoise;
            button3.Location = new Point(20, 20);
            button3.Name = "button3";
            button3.Size = new Size(118, 53);
            button3.TabIndex = 10;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LavenderBlush;
            label4.Location = new Point(788, 42);
            label4.Name = "label4";
            label4.Size = new Size(255, 32);
            label4.TabIndex = 6;
            label4.Text = "Add New Product";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LavenderBlush;
            label5.Location = new Point(788, 462);
            label5.Name = "label5";
            label5.Size = new Size(103, 32);
            label5.TabIndex = 7;
            label5.Text = "Action";
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(thirdpanel);
            Controls.Add(panel1);
            Name = "Product";
            Size = new Size(1220, 633);
            Load += Product_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            thirdpanel.ResumeLayout(false);
            thirdpanel.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBox1;
        private Label label8;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private Panel thirdpanel;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private Label label5;
        private ComboBox comboBox2;
        private Label label6;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button3;
    }
}
