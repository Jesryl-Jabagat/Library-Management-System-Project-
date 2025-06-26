using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMSv2.Admin
{
    public partial class mainFormAdmin : Form
    {
        public mainFormAdmin()
        {
            InitializeComponent();
            navController.Load(mainPanel, "Dashboard");
        }

        private void navPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainFormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            navController.Load(mainPanel, "Dashboard");
        }

        private void addBooksBtn_Click(object sender, EventArgs e)
        {
            navController.Load(mainPanel, "AddBook");
        }

        private void viewBooksBtn_Click(object sender, EventArgs e)
        {
            navController.Load(mainPanel, "ViewBook");
        }

        private void manageRequestBtn_Click(object sender, EventArgs e)
        {
            navController.Load(mainPanel, "ManageRequest");
        }

        private void manageUserBtn_Click(object sender, EventArgs e)
        {
            navController.Load(mainPanel, "ManageUser");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
