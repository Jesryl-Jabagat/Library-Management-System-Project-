using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMSv2.Login
{
    public partial class mainFormLogin : Form
    {
        public mainFormLogin()
        {
            InitializeComponent();
            formControl.Load(loginPanel, "Login");
        }

        private void switcherSign_Click(object sender, EventArgs e)
        {
            var currentText = switcherSign.Text.ToLower();

            if (currentText == "signup")
            {
                formControl.Load(loginPanel, "Signup");
                switcherSign.Text = "Login";
                labelerAccount.Text = "Already have an account?";
            }
            else if (currentText == "login")
            {
                formControl.Load(loginPanel, "Login");
                switcherSign.Text = "Signup";
                labelerAccount.Text = "Dont have an account?";
            }
        }
    }
}
