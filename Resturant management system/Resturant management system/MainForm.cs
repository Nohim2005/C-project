using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Resturant_management_system
{
    public partial class Main_Form : Form
    {
        private Form activeForm = null;

        public Main_Form()
        {
            InitializeComponent();
            this.FormClosing += Main_Form_FormClosing;
            this.Load += Main_Form_Load;
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogoutAllUsers(); 
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            UpdateLoginButtonText();
        }

        
        private void panel_Nav_Paint(object sender, PaintEventArgs e)
        {
           
        }

        

        private void hideSubMenu()
        {
            if (panel_KitchenSub.Visible == true)
                panel_KitchenSub.Visible = false;
            if (panel_StaffSub.Visible == true)
                panel_StaffSub.Visible = false;
            if (panel_ProductSub.Visible == true)
                panel_ProductSub.Visible = false;
            if (panel_TableSub.Visible == true)
                panel_TableSub.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_ChildSpawn.Controls.Add(childForm);
            panel_ChildSpawn.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_Kitchen_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_KitchenSub);
        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_StaffSub);
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_ProductSub);
        }

        private void btn_Table_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_TableSub);
        }

        private void btn_KitchenSub_Menu_Click(object sender, EventArgs e)
        {
            openChildForm(new Kitchen_MenuOptions());
        }

        private void btn_KitchenSub_Orders_Click(object sender, EventArgs e)
        {
            openChildForm(new Kitchen_Orders());
        }

        private void btn_KitchenSub_Reports_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_StaffSub_EmployeeProfile_Click(object sender, EventArgs e)
        {
            openChildForm(new Employee_Profiles());
        }

        private void btn_StaffSub_Tasks_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_StaffSub_Schedule_Click(object sender, EventArgs e)
        {
            openChildForm(new Shift_Scheduling_Tasks());
        }

        private void btn_ProductSub_Inventory_Click(object sender, EventArgs e)
        {
            openChildForm(new Product_Inventory());
        }

        private void btn_ProductSub_Suppliers_Click(object sender, EventArgs e)
        {
            openChildForm(new Product_Supplier());
        }

        private void btn_TableSub_Reservations_Click(object sender, EventArgs e)
        {
            openChildForm(new Table_Reservations());
        }

        private void btn_TableSub_Cleaning_Click(object sender, EventArgs e)
        {
            openChildForm(new Table_Cleaning());
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (IsAnyUserLoggedIn())
            {
                LogoutAllUsers();
                btn_login.Text = "Login";
                btn_login.Enabled = true;
            }
            else
            {
                Login loginForm = new Login();
                loginForm.LoginSuccessful += LoginForm_LoginSuccessful;
                openChildForm(loginForm);
            }
        }

        private void LoginForm_LoginSuccessful(object sender, string username)
        {
            btn_login.Text = $"Logged in as: {username}";
            btn_login.Enabled = true;
        }

        private bool IsAnyUserLoggedIn()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Chani\OneDrive - NSBM\Visual studio\Resturant management system\Resturant management system\Resturant Management DB.mdf"";Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(1) FROM Login WHERE Logged_In = 1";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        int loggedInCount = (int)cmd.ExecuteScalar();
                        return loggedInCount > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return false;
                }
            }
        }

        private void LogoutAllUsers()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Chani\OneDrive - NSBM\Visual studio\Resturant management system\Resturant management system\Resturant Management DB.mdf"";Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Login SET Logged_In = 0 WHERE Logged_In = 1";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while logging out users: " + ex.Message);
                }
            }
        }

        private void UpdateLoginButtonText()
        {
            if (IsAnyUserLoggedIn())
            {
                string loggedInUser = GetLoggedInUsername();
                if (!string.IsNullOrEmpty(loggedInUser))
                {
                    btn_login.Text = $"Logged in as: {loggedInUser}";
                    btn_login.Enabled = true; // Enable or disable based on your requirements
                }
            }
            else
            {
                btn_login.Text = "Login";
                btn_login.Enabled = true;
            }
        }

        private string GetLoggedInUsername()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Chani\OneDrive - NSBM\Visual studio\Resturant management system\Resturant management system\Resturant Management DB.mdf"";Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT TOP 1 EmpUname FROM Login WHERE Logged_In = 1";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        return (string)cmd.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return string.Empty;
                }
            }
        }
    }
}
