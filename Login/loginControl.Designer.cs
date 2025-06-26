namespace LMSv2.Login
{
    partial class loginControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginControl));
            label1 = new Label();
            label2 = new Label();
            emailBox = new TextBox();
            passBox = new TextBox();
            label3 = new Label();
            rememberMe = new CheckBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            loginBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(89, 105);
            label1.Name = "label1";
            label1.Size = new Size(73, 32);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(67, 185);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 1;
            label2.Text = "Email or phone";
            // 
            // emailBox
            // 
            emailBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailBox.Location = new Point(68, 211);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(239, 27);
            emailBox.TabIndex = 2;
            // 
            // passBox
            // 
            passBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passBox.Location = new Point(68, 267);
            passBox.Name = "passBox";
            passBox.PasswordChar = '•';
            passBox.Size = new Size(239, 27);
            passBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(67, 241);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // rememberMe
            // 
            rememberMe.AutoSize = true;
            rememberMe.Cursor = Cursors.Hand;
            rememberMe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rememberMe.ForeColor = Color.White;
            rememberMe.Location = new Point(68, 304);
            rememberMe.Name = "rememberMe";
            rememberMe.Size = new Size(104, 19);
            rememberMe.TabIndex = 5;
            rememberMe.Text = "Remember me";
            rememberMe.UseVisualStyleBackColor = true;
            rememberMe.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(154, 105);
            label4.Name = "label4";
            label4.Size = new Size(143, 32);
            label4.TabIndex = 7;
            label4.Text = "to BookLore";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(158, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 68);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.DodgerBlue;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Popup;
            loginBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(67, 343);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(240, 34);
            loginBtn.TabIndex = 9;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click_1;
            // 
            // loginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 22, 25);
            Controls.Add(loginBtn);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(rememberMe);
            Controls.Add(passBox);
            Controls.Add(label3);
            Controls.Add(emailBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "loginControl";
            Size = new Size(384, 500);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox emailBox;
        private TextBox passBox;
        private Label label3;
        private CheckBox rememberMe;
        private Label label4;
        private PictureBox pictureBox1;
        private Button loginBtn;
    }
}
