namespace LMSv2.Login
{
    partial class signupControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signupControl));
            pictureBox1 = new PictureBox();
            label4 = new Label();
            registerBtn = new Button();
            passRegisterBox = new TextBox();
            label3 = new Label();
            fullnameRegisterBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            confirmPassRegisterBox = new TextBox();
            label5 = new Label();
            emailRegisterBox = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(158, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 68);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(162, 105);
            label4.Name = "label4";
            label4.Size = new Size(143, 32);
            label4.TabIndex = 15;
            label4.Text = "to BookLore";
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.DodgerBlue;
            registerBtn.Cursor = Cursors.Hand;
            registerBtn.FlatAppearance.BorderSize = 0;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerBtn.ForeColor = Color.White;
            registerBtn.Location = new Point(67, 393);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(240, 34);
            registerBtn.TabIndex = 14;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // passRegisterBox
            // 
            passRegisterBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passRegisterBox.Location = new Point(68, 289);
            passRegisterBox.Name = "passRegisterBox";
            passRegisterBox.PasswordChar = '•';
            passRegisterBox.Size = new Size(239, 27);
            passRegisterBox.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(67, 263);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 12;
            label3.Text = "Password";
            // 
            // fullnameRegisterBox
            // 
            fullnameRegisterBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fullnameRegisterBox.Location = new Point(68, 233);
            fullnameRegisterBox.Name = "fullnameRegisterBox";
            fullnameRegisterBox.Size = new Size(239, 27);
            fullnameRegisterBox.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(67, 207);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 10;
            label2.Text = "Fullname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(70, 105);
            label1.Name = "label1";
            label1.Size = new Size(99, 32);
            label1.TabIndex = 9;
            label1.Text = "Register";
            // 
            // confirmPassRegisterBox
            // 
            confirmPassRegisterBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmPassRegisterBox.Location = new Point(68, 345);
            confirmPassRegisterBox.Name = "confirmPassRegisterBox";
            confirmPassRegisterBox.PasswordChar = '•';
            confirmPassRegisterBox.Size = new Size(239, 27);
            confirmPassRegisterBox.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(67, 319);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 17;
            label5.Text = "Confirm password";
            // 
            // emailRegisterBox
            // 
            emailRegisterBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailRegisterBox.Location = new Point(68, 177);
            emailRegisterBox.Name = "emailRegisterBox";
            emailRegisterBox.Size = new Size(239, 27);
            emailRegisterBox.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(67, 151);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 19;
            label6.Text = "Email or phone";
            // 
            // signupControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 22, 25);
            Controls.Add(emailRegisterBox);
            Controls.Add(label6);
            Controls.Add(confirmPassRegisterBox);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(registerBtn);
            Controls.Add(passRegisterBox);
            Controls.Add(label3);
            Controls.Add(fullnameRegisterBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "signupControl";
            Size = new Size(384, 500);
            Load += signupControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label4;
        private Button registerBtn;
        private TextBox passRegisterBox;
        private Label label3;
        private TextBox fullnameRegisterBox;
        private Label label2;
        private Label label1;
        private TextBox confirmPassRegisterBox;
        private Label label5;
        private TextBox emailRegisterBox;
        private Label label6;
    }
}
