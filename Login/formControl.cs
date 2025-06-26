using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMSv2.Login
{
    public class formControl
    {
        public static void Load(Panel panel, string controlName)
        {
            UserControl control = null;

            switch (controlName)
            {
                case "Login":
                    control = new loginControl();
                    break;
                case "Signup":
                    control = new signupControl();
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
