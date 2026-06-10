namespace RusdiBakery.Views.Public.Panels
{
    partial class ProductList
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label9 = new Label();
            productEntriesPanel = new FlowLayoutPanel();
            cartPanel1 = new RusdiBakery.Views.Public.Panels.Components.CartPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Indigo;
            label1.Font = new Font("Noto Sans SC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSteelBlue;
            label1.Location = new Point(41, 15);
            label1.Name = "label1";
            label1.Size = new Size(228, 52);
            label1.TabIndex = 1;
            label1.Text = "Welcome to";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Indigo;
            label2.Font = new Font("Noto Sans SC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightPink;
            label2.Location = new Point(41, 67);
            label2.Name = "label2";
            label2.Size = new Size(329, 52);
            label2.TabIndex = 2;
            label2.Text = "Product List Page";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(583, 40);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(333, 46);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Plum;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.PaleTurquoise;
            button1.Location = new Point(935, 40);
            button1.Name = "button1";
            button1.Size = new Size(166, 46);
            button1.TabIndex = 8;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.LavenderBlush;
            label9.Location = new Point(573, 9);
            label9.Name = "label9";
            label9.Size = new Size(124, 28);
            label9.TabIndex = 19;
            label9.Text = "Cari produk";
            // 
            // productEntriesPanel
            // 
            productEntriesPanel.AutoScroll = true;
            productEntriesPanel.BackColor = Color.Transparent;
            productEntriesPanel.Location = new Point(30, 140);
            productEntriesPanel.Name = "productEntriesPanel";
            productEntriesPanel.Size = new Size(680, 520);
            productEntriesPanel.TabIndex = 20;
            productEntriesPanel.Paint += productEntriesPanel_Paint;
            // 
            // cartPanel1
            // 
            cartPanel1.BackColor = Color.Indigo;
            cartPanel1.Location = new Point(730, 140);
            cartPanel1.Name = "cartPanel1";
            cartPanel1.Size = new Size(430, 480);
            cartPanel1.TabIndex = 21;
            // 
            // ProductList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(cartPanel1);
            Controls.Add(productEntriesPanel);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductList";
            Size = new Size(1188, 682);
            Load += ProductList_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Label label9;
        private FlowLayoutPanel productEntriesPanel;
        private Components.CartPanel cartPanel1;
    }
}