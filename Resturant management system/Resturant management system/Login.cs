using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Resturant_management_system
{
    public partial class Login : Form
    {
        public event EventHandler<string> LoginSuccessful;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Uname = txt_Uname.Text;
            string Pass = txt_Pass.Text;

            // Define connection string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Chani\OneDrive - NSBM\Visual studio\Resturant management system\Resturant management system\Resturant Management DB.mdf"";Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(1) FROM Login WHERE EmpUname = @Uname AND Pass = @Pass";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Prevent SQL injection
                        cmd.Parameters.AddWithValue("@Uname", Uname);
                        cmd.Parameters.AddWithValue("@Pass", Pass);

                        int userCount = (int)cmd.ExecuteScalar();

                        if (userCount > 0)
                        {
                            lbl_output.ForeColor = Color.DarkGreen;
                            lbl_output.Text = "Login successful!";

                            // set Logged_In true
                            string updateQuery = "UPDATE Login SET Logged_In = 1 WHERE EmpUname = @Uname";

                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection))
                            {
                                updateCmd.Parameters.AddWithValue("@Uname", Uname);
                                updateCmd.ExecuteNonQuery();
                            }

                            // notify successful login
                            LoginSuccessful?.Invoke(this, Uname);
                            this.Hide();
                        }
                        else
                        {
                            lbl_output.ForeColor = Color.Red;
                            lbl_output.Text = "Invalid username or password. Please try again.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
