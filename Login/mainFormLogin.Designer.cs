namespace LMSv2.Login
{
    partial class mainFormLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFormLogin));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            loginPanel = new Panel();
            panel2 = new Panel();
            switcherSign = new Label();
            labelerAccount = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 500);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-28, -22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(405, 541);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // loginPanel
            // 
            loginPanel.Dock = DockStyle.Fill;
            loginPanel.Location = new Point(384, 0);
            loginPanel.Margin = new Padding(0);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(384, 500);
            loginPanel.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(switcherSign);
            panel2.Controls.Add(labelerAccount);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(384, 466);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 34);
            panel2.TabIndex = 2;
            // 
            // switcherSign
            // 
            switcherSign.AutoSize = true;
            switcherSign.Cursor = Cursors.Hand;
            switcherSign.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            switcherSign.ForeColor = Color.White;
            switcherSign.Location = new Point(238, 7);
            switcherSign.Name = "switcherSign";
            switcherSign.Size = new Size(57, 20);
            switcherSign.TabIndex = 1;
            switcherSign.Text = "Signup";
            switcherSign.Click += switcherSign_Click;
            // 
            // labelerAccount
            // 
            labelerAccount.AutoSize = true;
            labelerAccount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelerAccount.ForeColor = Color.White;
            labelerAccount.Location = new Point(65, 7);
            labelerAccount.Name = "labelerAccount";
            labelerAccount.Size = new Size(160, 20);
            labelerAccount.TabIndex = 0;
            labelerAccount.Text = "Dont have an account?";
            // 
            // mainFormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 22, 25);
            ClientSize = new Size(768, 500);
            Controls.Add(panel2);
            Controls.Add(loginPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mainFormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mainFormLogin";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel loginPanel;
        private Panel panel2;
        private Label switcherSign;
        private Label labelerAccount;
    }
}