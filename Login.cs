using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          
                // Get user input
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                // Define SQL connection string
                string connectionString = "Data Source=DESKTOP-QDUVD0V;Initial Catalog=LoginDB;Integrated Security=True;";

                // SQL query to check if the username and password exist
                string query = "SELECT COUNT(1) FROM Users WHERE Username=@Username AND Password=@Password";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        // Open SQL connection
                        connection.Open();

                        // Create a SqlCommand
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            // Add parameters to prevent SQL Injection
                            cmd.Parameters.AddWithValue("@Username", username);
                            cmd.Parameters.AddWithValue("@Password", password); // Use a hashed password in real applications

                            // Execute the command and get the result
                            int count = Convert.ToInt32(cmd.ExecuteScalar());

                            // If count == 1, login is successful
                            if (count == 1)
                            {
                                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Optionally, open the dashboard or another form
                                // DashboardForm dashboard = new DashboardForm();
                                // dashboard.Show();
                                // this.Hide(); // Hide the login form
                            }
                            else
                            {
                                MessageBox.Show("Invalid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Display error if any
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            DashBord db=new DashBord();
            db.Show();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

