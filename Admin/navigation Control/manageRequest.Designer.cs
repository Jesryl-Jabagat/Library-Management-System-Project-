namespace LMSv2.Admin.navigation_Control
{
    partial class manageRequest
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
            label5 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            label5.Size = new Size(305, 25);
            label5.TabIndex = 8;
            label5.Text = "MANAGE BORROWING REQUEST";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 155);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 10;
            label2.Text = "Pending Request";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(50, 51, 53);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 178);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(862, 176);
            dataGridView1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 385);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 12;
            label1.Text = "Recent Request Activity";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.FromArgb(50, 51, 53);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(27, 408);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(862, 176);
            dataGridView2.TabIndex = 11;
            // 
            // manageRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 22, 25);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Name = "manageRequest";
            Size = new Size(915, 644);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private DataGridView dataGridView2;
    }
}
