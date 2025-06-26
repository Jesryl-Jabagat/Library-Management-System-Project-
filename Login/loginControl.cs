using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMSv2.Admin;
using MySql.Data.MySqlClient;

namespace LMSv2.Login
{
    public partial class loginControl : UserControl
    {
        private string settingsFilePath = Path.Combine(Application.StartupPath, "settings.txt");

        public loginControl()
        {
            InitializeComponent();
            rememberMe.CheckedChanged += new EventHandler(rememberMe_CheckedChanged);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void rememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (rememberMe.Checked)
            {

                SaveCredentials();
            }
            else
            {

                ClearCredentials();
            }
        }


        private void SaveCredentials()
        {

            File.WriteAllLines(settingsFilePath, new string[]
            {
                "true",
                emailBox.Text,
                passBox.Text
            });
        }


        private void ClearCredentials()
        {
            if (File.Exists(settingsFilePath))
            {
                File.Delete(settingsFilePath);
            }
        }


        private void LoadRememberMe()
        {
            if (File.Exists(settingsFilePath))
            {

                var lines = File.ReadAllLines(settingsFilePath);

                if (lines.Length >= 3)
                {
                    rememberMe.Checked = lines[0] == "true";
                    emailBox.Text = lines[1];
                    passBox.Text = lines[2];
                }
            }
        }


        private void loginControl_Load(object sender, EventArgs e)
        {
            LoadRememberMe();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                string email = emailBox.Text;
                string password = passBox.Text;

                UserAuth userAuth = new UserAuth();
                string role = userAuth.ValidateLogin(email, password);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
