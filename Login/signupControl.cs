using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using MySql.Data.MySqlClient;

namespace LMSv2.Login
{
    public partial class signupControl : UserControl
    {
        public signupControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signupControl_Load(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            var email = emailRegisterBox.Text;
            var fullName = fullnameRegisterBox.Text;
            var password = passRegisterBox.Text;
            var confirm = confirmPassRegisterBox.Text;

           UserAuth userAuth = new UserAuth();
           userAuth.RegisterUser(email, fullName, password, confirm, "user");

            
            

        }
       
    }
}
