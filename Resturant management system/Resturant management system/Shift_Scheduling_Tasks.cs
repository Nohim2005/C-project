using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Resturant_management_system
{
    public partial class Shift_Scheduling_Tasks : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Chani\OneDrive - NSBM\Visual studio\Resturant management system\Resturant management system\Resturant Management DB.mdf"";Integrated Security=True";

        public Shift_Scheduling_Tasks()
        {
            InitializeComponent();
            LoadEmployees();
            DisplayDateAndDay();
            DeleteOutdatedTasks();
            LoadEmployeeTasks();
        }

        private void DisplayDateAndDay()
        {
            try
            {
                DateTime now = DateTime.Now;
                string dayName = now.ToString("dddd");
                string date = now.ToString("MMMM d, yyyy");
                string displayText = $"{dayName}, {date}";

                if (lbl_Date != null)
                {
                    lbl_Date.Text = displayText;
                    lbl_Date.Font = new Font(lbl_Date.Font, FontStyle.Bold);
                    lbl_Date.ForeColor = Color.White;
                }
                else
                {
                    MessageBox.Show("lbl_Date is not initialized.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while setting the date: " + ex.Message);
            }
        }

        private void LoadEmployees()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT EmpID, EmpFName FROM Login";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        CB_Emp.Items.Clear();

                        while (reader.Read())
                        {
                            string empId = reader["EmpID"].ToString();
                            string fName = reader["EmpFName"].ToString();
                            string displayText = $"{empId} - {fName}";

                            CB_Emp.Items.Add(new ComboBoxItem(displayText, empId));
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading employees: " + ex.Message);
            }
        }

        private void LoadEmployeeTasks()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Employee, Task FROM Tasks WHERE Date = @CurrentDate";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        string currentDate = DateTime.Now.ToString("MMMM d, yyyy");
                        cmd.Parameters.AddWithValue("@CurrentDate", currentDate);

                        SqlDataReader reader = cmd.ExecuteReader();
                        ClearEmployeePanels();

                        while (reader.Read())
                        {
                            string empId = reader["Employee"].ToString();
                            string task = reader["Task"].ToString();

                            string empName = GetEmployeeNameById(empId);

                            if (!string.IsNullOrEmpty(empName) && !string.IsNullOrEmpty(task))
                            {
                                AddEmployeeBox(task, $"{empId} - {empName}");
                            }
                        }
                        reader.Close();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading employee tasks: " + ex.Message);
            }
        }

        private string GetEmployeeNameById(string empId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT EmpFName FROM Login WHERE EmpID = @EmpID";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@EmpID", empId);
                        return cmd.ExecuteScalar()?.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching employee name: " + ex.Message);
                return string.Empty;
            }
        }

        private void ClearEmployeePanels()
        {
            panel_Kitchen.Controls.Clear();
            panel_Reception.Controls.Clear();
            panel_Waiting.Controls.Clear();
            panel_Delivery.Controls.Clear();
        }

        private void AddEmployeeBox(string role, string displayText)
        {
            Panel employeePanel = new Panel
            {
                Size = new Size(122, 125),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.LightGray,
            };

            Label employeeLabel = new Label
            {
                Text = displayText,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
            };

            employeePanel.Controls.Add(employeeLabel);

            switch (role.ToLower())
            {
                case "kitchen":
                    panel_Kitchen.Controls.Add(employeePanel);
                    break;
                case "reception":
                    panel_Reception.Controls.Add(employeePanel);
                    break;
                case "waiting":
                    panel_Waiting.Controls.Add(employeePanel);
                    break;
                case "delivery":
                    panel_Delivery.Controls.Add(employeePanel);
                    break;
                default:
                    MessageBox.Show($"Unknown role: {role}");
                    break;
            }
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public ComboBoxItem(string text, string value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private void btn_addtoSchedule_Click(object sender, EventArgs e)
        {
            string name = CB_Emp.Text;
            string task = CB_Role.Text;
            string date = lbl_Date.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string checkTaskQuery = "SELECT COUNT(*) FROM Tasks WHERE Employee = @Name AND Task = @Task AND Date = @Date";
                    using (SqlCommand checkTaskCmd = new SqlCommand(checkTaskQuery, connection))
                    {
                        checkTaskCmd.Parameters.AddWithValue("@Name", name);
                        checkTaskCmd.Parameters.AddWithValue("@Task", task);
                        checkTaskCmd.Parameters.AddWithValue("@Date", date);

                        int taskCount = (int)checkTaskCmd.ExecuteScalar();

                        if (taskCount > 0)
                        {
                            lbl_results.ForeColor = Color.Red;
                            lbl_results.Text = "Task already exists.";
                            return;
                        }
                    }

                    string checkEmployeeQuery = "SELECT COUNT(*) FROM Tasks WHERE Employee = @Name AND Date = @Date";
                    using (SqlCommand checkEmployeeCmd = new SqlCommand(checkEmployeeQuery, connection))
                    {
                        checkEmployeeCmd.Parameters.AddWithValue("@Name", name);
                        checkEmployeeCmd.Parameters.AddWithValue("@Date", date);

                        int employeeCount = (int)checkEmployeeCmd.ExecuteScalar();

                        if (employeeCount > 0)
                        {
                            lbl_results.ForeColor = Color.Red;
                            lbl_results.Text = "Employee is already assigned to a task on this date.";
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO Tasks (Employee, Task, Date) VALUES (@Name, @Task, @Date)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@Name", name);
                        insertCmd.Parameters.AddWithValue("@Task", task);
                        insertCmd.Parameters.AddWithValue("@Date", date);
                        insertCmd.ExecuteNonQuery();
                    }

                    lbl_results.ForeColor = Color.DarkGreen;
                    lbl_results.Text = "Task added successfully.";

                    AddEmployeeBox(task, name); // Add the new task box immediately
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the task: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = CB_Emp.Text;
            string task = CB_Role.Text;
            string date = lbl_Date.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Tasks WHERE Employee = @Name AND Task = @Task AND Date = @Date";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Task", task);
                        cmd.Parameters.AddWithValue("@Date", date);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            lbl_results.ForeColor = Color.DarkGreen;
                            lbl_results.Text = "Task deleted successfully.";
                            LoadEmployeeTasks(); // Refresh the employee tasks after deletion
                        }
                        else
                        {
                            lbl_results.ForeColor = Color.Red;
                            lbl_results.Text = "No task found to delete.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the task: " + ex.Message);
            }
        }

        private void DeleteOutdatedTasks()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Tasks WHERE Date != @CurrentDate";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        string currentDate = DateTime.Now.ToString("MMMM d, yyyy");
                        cmd.Parameters.AddWithValue("@CurrentDate", currentDate);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting outdated tasks: " + ex.Message);
            }
        }

        private void panel_Border(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                int borderWidth = 2;
                Color borderColor = Color.White;
                ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, borderColor, borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid);
            }
        }
    }
}
