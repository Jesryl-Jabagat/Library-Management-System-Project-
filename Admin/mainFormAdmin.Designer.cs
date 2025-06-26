namespace LMSv2.Admin
{
    partial class mainFormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFormAdmin));
            panel2 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            navPanel = new FlowLayoutPanel();
            panel4 = new Panel();
            dashboardBtn = new Button();
            panel6 = new Panel();
            addBooksBtn = new Button();
            panel7 = new Panel();
            viewBooksBtn = new Button();
            panel8 = new Panel();
            manageRequestBtn = new Button();
            panel9 = new Panel();
            manageUserBtn = new Button();
            panel10 = new Panel();
            panel5 = new Panel();
            button1 = new Button();
            mainPanel = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            navPanel.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(nightControlBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1185, 31);
            panel2.TabIndex = 1;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(1046, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 67);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 141);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(99, 72);
            label3.Name = "label3";
            label3.Size = new Size(150, 13);
            label3.TabIndex = 9;
            label3.Text = "Library Management System";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(95, 37);
            label4.Name = "label4";
            label4.Size = new Size(114, 32);
            label4.TabIndex = 8;
            label4.Text = "BookLore";
            // 
            // navPanel
            // 
            navPanel.Controls.Add(panel1);
            navPanel.Controls.Add(panel4);
            navPanel.Controls.Add(panel6);
            navPanel.Controls.Add(panel7);
            navPanel.Controls.Add(panel8);
            navPanel.Controls.Add(panel9);
            navPanel.Controls.Add(panel10);
            navPanel.Controls.Add(panel5);
            navPanel.Dock = DockStyle.Left;
            navPanel.Location = new Point(0, 31);
            navPanel.Margin = new Padding(0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(270, 644);
            navPanel.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Controls.Add(dashboardBtn);
            panel4.Location = new Point(0, 141);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(270, 50);
            panel4.TabIndex = 7;
            // 
            // dashboardBtn
            // 
            dashboardBtn.FlatAppearance.BorderSize = 0;
            dashboardBtn.FlatStyle = FlatStyle.Flat;
            dashboardBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboardBtn.ForeColor = Color.White;
            dashboardBtn.Image = (Image)resources.GetObject("dashboardBtn.Image");
            dashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardBtn.Location = new Point(0, 0);
            dashboardBtn.Margin = new Padding(0);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Padding = new Padding(80, 0, 0, 0);
            dashboardBtn.Size = new Size(270, 50);
            dashboardBtn.TabIndex = 8;
            dashboardBtn.Text = "       Dashboard";
            dashboardBtn.TextAlign = ContentAlignment.MiddleLeft;
            dashboardBtn.UseVisualStyleBackColor = true;
            dashboardBtn.Click += dashboardBtn_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(addBooksBtn);
            panel6.Location = new Point(0, 191);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(270, 50);
            panel6.TabIndex = 10;
            // 
            // addBooksBtn
            // 
            addBooksBtn.FlatAppearance.BorderSize = 0;
            addBooksBtn.FlatStyle = FlatStyle.Flat;
            addBooksBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBooksBtn.ForeColor = Color.White;
            addBooksBtn.Image = (Image)resources.GetObject("addBooksBtn.Image");
            addBooksBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addBooksBtn.Location = new Point(0, 0);
            addBooksBtn.Margin = new Padding(0);
            addBooksBtn.Name = "addBooksBtn";
            addBooksBtn.Padding = new Padding(80, 0, 0, 0);
            addBooksBtn.Size = new Size(270, 50);
            addBooksBtn.TabIndex = 8;
            addBooksBtn.Text = "       Add Books";
            addBooksBtn.TextAlign = ContentAlignment.MiddleLeft;
            addBooksBtn.UseVisualStyleBackColor = true;
            addBooksBtn.Click += addBooksBtn_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(viewBooksBtn);
            panel7.Location = new Point(0, 241);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(270, 50);
            panel7.TabIndex = 10;
            // 
            // viewBooksBtn
            // 
            viewBooksBtn.FlatAppearance.BorderSize = 0;
            viewBooksBtn.FlatStyle = FlatStyle.Flat;
            viewBooksBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewBooksBtn.ForeColor = Color.White;
            viewBooksBtn.Image = (Image)resources.GetObject("viewBooksBtn.Image");
            viewBooksBtn.ImageAlign = ContentAlignment.MiddleLeft;
            viewBooksBtn.Location = new Point(0, 0);
            viewBooksBtn.Margin = new Padding(0);
            viewBooksBtn.Name = "viewBooksBtn";
            viewBooksBtn.Padding = new Padding(80, 0, 0, 0);
            viewBooksBtn.Size = new Size(270, 50);
            viewBooksBtn.TabIndex = 8;
            viewBooksBtn.Text = "       View Book";
            viewBooksBtn.TextAlign = ContentAlignment.MiddleLeft;
            viewBooksBtn.UseVisualStyleBackColor = true;
            viewBooksBtn.Click += viewBooksBtn_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(manageRequestBtn);
            panel8.Location = new Point(0, 291);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(270, 50);
            panel8.TabIndex = 10;
            // 
            // manageRequestBtn
            // 
            manageRequestBtn.FlatAppearance.BorderSize = 0;
            manageRequestBtn.FlatStyle = FlatStyle.Flat;
            manageRequestBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            manageRequestBtn.ForeColor = Color.White;
            manageRequestBtn.Image = (Image)resources.GetObject("manageRequestBtn.Image");
            manageRequestBtn.ImageAlign = ContentAlignment.MiddleLeft;
            manageRequestBtn.Location = new Point(0, 0);
            manageRequestBtn.Margin = new Padding(0);
            manageRequestBtn.Name = "manageRequestBtn";
            manageRequestBtn.Padding = new Padding(80, 0, 0, 0);
            manageRequestBtn.Size = new Size(270, 50);
            manageRequestBtn.TabIndex = 8;
            manageRequestBtn.Text = "       Manage Request";
            manageRequestBtn.TextAlign = ContentAlignment.MiddleLeft;
            manageRequestBtn.UseVisualStyleBackColor = true;
            manageRequestBtn.Click += manageRequestBtn_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(manageUserBtn);
            panel9.Location = new Point(0, 341);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Size = new Size(270, 50);
            panel9.TabIndex = 10;
            // 
            // manageUserBtn
            // 
            manageUserBtn.FlatAppearance.BorderSize = 0;
            manageUserBtn.FlatStyle = FlatStyle.Flat;
            manageUserBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            manageUserBtn.ForeColor = Color.White;
            manageUserBtn.Image = (Image)resources.GetObject("manageUserBtn.Image");
            manageUserBtn.ImageAlign = ContentAlignment.MiddleLeft;
            manageUserBtn.Location = new Point(0, 0);
            manageUserBtn.Margin = new Padding(0);
            manageUserBtn.Name = "manageUserBtn";
            manageUserBtn.Padding = new Padding(80, 0, 0, 0);
            manageUserBtn.Size = new Size(270, 50);
            manageUserBtn.TabIndex = 8;
            manageUserBtn.Text = "       Manage User";
            manageUserBtn.TextAlign = ContentAlignment.MiddleLeft;
            manageUserBtn.UseVisualStyleBackColor = true;
            manageUserBtn.Click += manageUserBtn_Click;
            // 
            // panel10
            // 
            panel10.Location = new Point(3, 394);
            panel10.Name = "panel10";
            panel10.Size = new Size(270, 196);
            panel10.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.Controls.Add(button1);
            panel5.Location = new Point(0, 593);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(270, 50);
            panel5.TabIndex = 9;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Padding = new Padding(80, 0, 0, 0);
            button1.Size = new Size(270, 50);
            button1.TabIndex = 8;
            button1.Text = "       Logout";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(270, 31);
            mainPanel.Margin = new Padding(0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(915, 644);
            mainPanel.TabIndex = 6;
            // 
            // mainFormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 22, 25);
            ClientSize = new Size(1185, 675);
            Controls.Add(mainPanel);
            Controls.Add(navPanel);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mainFormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mainFormAdmin";
            Load += mainFormAdmin_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            navPanel.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private FlowLayoutPanel navPanel;
        private Label label4;
        private Label label3;
        private Panel panel4;
        private Button dashboardBtn;
        private Panel panel5;
        private Button button1;
        private Panel panel6;
        private Button addBooksBtn;
        private Panel panel7;
        private Button viewBooksBtn;
        private Panel panel8;
        private Button manageRequestBtn;
        private Panel panel9;
        private Button manageUserBtn;
        private Panel panel10;
        private Panel mainPanel;
    }
}