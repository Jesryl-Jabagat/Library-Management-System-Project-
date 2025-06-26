namespace LMSv2.Admin.navigation_Control
{
    partial class viewBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewBooks));
            label5 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(27, 31);
            label5.Name = "label5";
            label5.Size = new Size(165, 25);
            label5.TabIndex = 8;
            label5.Text = "BOOKS CATALOG";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(27, 143);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search by title or author";
            textBox1.Size = new Size(532, 29);
            textBox1.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(562, 141);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(122, 31);
            button1.TabIndex = 16;
            button1.Text = "   Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(50, 51, 53);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 210);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(855, 407);
            dataGridView1.TabIndex = 17;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "sort by title", "sort by author", "sort by availability", "sort by dateAdded" });
            comboBox1.Location = new Point(711, 143);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 29);
            comboBox1.TabIndex = 18;
            comboBox1.Text = "sort by availability";
            // 
            // viewBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 22, 25);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Name = "viewBooks";
            Size = new Size(915, 644);
            Load += viewBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
    }
}
