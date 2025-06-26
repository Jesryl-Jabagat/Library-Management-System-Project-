namespace LMSv2.Admin.navigation_Control
{
    partial class dashboard
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
            label3 = new Label();
            totalBooksCount = new Label();
            label1 = new Label();
            panel5 = new Panel();
            label4 = new Label();
            availBooksCount = new Label();
            label6 = new Label();
            panel6 = new Panel();
            label7 = new Label();
            borrowedBooksCount = new Label();
            label9 = new Label();
            panel7 = new Panel();
            label10 = new Label();
            pendingRequestCount = new Label();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 51, 53);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(totalBooksCount);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(27, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 110);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(15, 83);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 5;
            label3.Text = "Titles in the library";
            // 
            // totalBooksCount
            // 
            totalBooksCount.AutoSize = true;
            totalBooksCount.BackColor = Color.Transparent;
            totalBooksCount.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalBooksCount.ForeColor = Color.White;
            totalBooksCount.Location = new Point(7, 35);
            totalBooksCount.Name = "totalBooksCount";
            totalBooksCount.Size = new Size(39, 47);
            totalBooksCount.TabIndex = 5;
            totalBooksCount.Text = "8";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 13);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 4;
            label1.Text = " TOTAL BOOKS";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(50, 51, 53);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(availBooksCount);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(253, 108);
            panel5.Name = "panel5";
            panel5.Size = new Size(184, 110);
            panel5.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(15, 83);
            label4.Name = "label4";
            label4.Size = new Size(147, 15);
            label4.TabIndex = 5;
            label4.Text = "Books ready for borrowing";
            // 
            // availBooksCount
            // 
            availBooksCount.AutoSize = true;
            availBooksCount.BackColor = Color.Transparent;
            availBooksCount.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            availBooksCount.ForeColor = Color.White;
            availBooksCount.Location = new Point(7, 35);
            availBooksCount.Name = "availBooksCount";
            availBooksCount.Size = new Size(58, 47);
            availBooksCount.TabIndex = 5;
            availBooksCount.Text = "11";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(9, 13);
            label6.Name = "label6";
            label6.Size = new Size(133, 20);
            label6.TabIndex = 4;
            label6.Text = "AVAILABLE BOOKS";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(50, 51, 53);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(borrowedBooksCount);
            panel6.Controls.Add(label9);
            panel6.Location = new Point(479, 108);
            panel6.Name = "panel6";
            panel6.Size = new Size(184, 110);
            panel6.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(15, 83);
            label7.Name = "label7";
            label7.Size = new Size(112, 15);
            label7.TabIndex = 5;
            label7.Text = "Currently with users";
            // 
            // borrowedBooksCount
            // 
            borrowedBooksCount.AutoSize = true;
            borrowedBooksCount.BackColor = Color.Transparent;
            borrowedBooksCount.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            borrowedBooksCount.ForeColor = Color.White;
            borrowedBooksCount.Location = new Point(7, 35);
            borrowedBooksCount.Name = "borrowedBooksCount";
            borrowedBooksCount.Size = new Size(39, 47);
            borrowedBooksCount.TabIndex = 5;
            borrowedBooksCount.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(9, 13);
            label9.Name = "label9";
            label9.Size = new Size(143, 20);
            label9.TabIndex = 4;
            label9.Text = "BORROWED BOOKS";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(50, 51, 53);
            panel7.Controls.Add(label10);
            panel7.Controls.Add(pendingRequestCount);
            panel7.Controls.Add(label12);
            panel7.Location = new Point(705, 108);
            panel7.Name = "panel7";
            panel7.Size = new Size(184, 110);
            panel7.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(15, 83);
            label10.Name = "label10";
            label10.Size = new Size(103, 15);
            label10.TabIndex = 5;
            label10.Text = "Awaiting approval";
            // 
            // pendingRequestCount
            // 
            pendingRequestCount.AutoSize = true;
            pendingRequestCount.BackColor = Color.Transparent;
            pendingRequestCount.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingRequestCount.ForeColor = Color.White;
            pendingRequestCount.Location = new Point(7, 35);
            pendingRequestCount.Name = "pendingRequestCount";
            pendingRequestCount.Size = new Size(39, 47);
            pendingRequestCount.TabIndex = 5;
            pendingRequestCount.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(9, 13);
            label12.Name = "label12";
            label12.Size = new Size(138, 20);
            label12.TabIndex = 4;
            label12.Text = "PENDING REQUEST";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(50, 51, 53);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 277);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(862, 340);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 249);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 8;
            label2.Text = "Recent Activity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(27, 31);
            label5.Name = "label5";
            label5.Size = new Size(201, 25);
            label5.TabIndex = 6;
            label5.Text = "ADMIN DASHBOARD";
            label5.Click += label5_Click;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 22, 25);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Margin = new Padding(0);
            Name = "dashboard";
            Size = new Size(915, 644);
            Load += dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label totalBooksCount;
        private Panel panel5;
        private Label label4;
        private Label availBooksCount;
        private Label label6;
        private Panel panel6;
        private Label label7;
        private Label borrowedBooksCount;
        private Label label9;
        private Panel panel7;
        private Label label10;
        private Label pendingRequestCount;
        private Label label12;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label5;
    }
}
