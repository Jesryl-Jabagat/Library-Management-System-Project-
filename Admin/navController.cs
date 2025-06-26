using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMSv2.Admin.navigation_Control;
using LMSv2.Login;

namespace LMSv2.Admin
{
    public class navController
    {
        public static void Load(Panel panel, string controlName)
        {
            UserControl control = null;

            switch (controlName)
            {
                case "Dashboard":
                    control = new dashboard();
                    break;
                case "AddBook":
                    control = new addBooks();
                    break;
                case "ViewBook":
                    control = new viewBooks();
                    break;
                case "ManageRequest":
                    control = new manageRequest();
                    break;
                case "ManageUser":
                    control = new manageUsers();
                    break;

                default:
                    return;
            }

            panel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panel.Controls.Add(control);
        }
    }
}
