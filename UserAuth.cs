using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMSv2.Admin;
using LMSv2.Login;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;

namespace LMSv2
{
    public class UserAuth
    {
        private DatabaseConnection _dbConnection = new DatabaseConnection();
        
        // Method for user registration
        public void RegisterUser(string email, string fullName, string password, string confirm, string role = "user")
        {
            try
            {
                // Basic validation
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(confirm))
                {
                    MessageBox.Show("Please fill out all fields.");
                    return;
                }

                // Password and confirmation match validation
                if (password != confirm)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }

                // Check if the email already exists in the database
                if (IsEmailRegistered(email))
                {
                    MessageBox.Show("Email is already registered.");
                    return;
                }

                // Hash the password using bcrypt
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                // Query to insert the new user into the database
                string insertQuery = "INSERT INTO users (email, fullName, password, role) VALUES (@Email, @FullName, @Password, @Role)";

                MySqlParameter[] insertParameters = new MySqlParameter[]
                {
                    new MySqlParameter("@Email", email),
                    new MySqlParameter("@FullName", fullName),
                    new MySqlParameter("@Password", hashedPassword),
                    new MySqlParameter("@Role", role)
                };

                // Execute the insert query
                int result = _dbConnection.ExecuteInsert(insertQuery, insertParameters);

                // Check if the registration was successful
                if (result > 0)
                {
                    MessageBox.Show("Registration successful.");
                }
                else
                {
                    MessageBox.Show("An error occurred during registration.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during registration: {ex.Message}");
            }
        }

        // Method for login validation
        public string ValidateLogin(string email, string pass)
        {
            try
            {
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass))
                {
                    MessageBox.Show("Please enter both email and password.");
                    return null;
                }

                string query = "SELECT * FROM users WHERE email = @Email";
                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@Email", email)
                };

                DataTable dt = _dbConnection.ExecuteSelect(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    string storedHashedPassword = dt.Rows[0]["password"].ToString();
                    string userRole = dt.Rows[0]["role"].ToString();

                    if (BCrypt.Net.BCrypt.Verify(pass, storedHashedPassword))
                    {
                        MessageBox.Show("Login successful.");
                        RedirectToUI(userRole);
                        return userRole;
                    }
                }
                
                MessageBox.Show("Invalid email or password.");
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during login: {ex.Message}");
                return null;
            }
        }

        private void RedirectToUI(string role)
        {
            try
            {
                if (role.Equals("admin", StringComparison.OrdinalIgnoreCase))
                {
                    var loginForm = Application.OpenForms.OfType<mainFormLogin>().FirstOrDefault();
                    if (loginForm != null)
                    {
                        var adminForm = new mainFormAdmin();
                        adminForm.Show();
                       
                        
                    }
                }
                else if (role.Equals("user", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Redirecting to user UI.");
                    
                }
                else
                {
                    MessageBox.Show("Role not recognized.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during redirection: {ex.Message}");
            }
        }

        private bool IsEmailRegistered(string email)
        {
            try
            {
                string checkEmailQuery = "SELECT COUNT(*) FROM users WHERE email = @Email";
                MySqlParameter[] checkEmailParameters = new MySqlParameter[]
                {
                    new MySqlParameter("@Email", email)
                };

                DataTable dt = _dbConnection.ExecuteSelect(checkEmailQuery, checkEmailParameters);
                return Convert.ToInt32(dt.Rows[0][0]) > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking email: {ex.Message}");
                return false;
            }
        }
    }
}
