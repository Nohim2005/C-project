using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace Resturant_management_system
{
    public partial class Employee_Profiles : Form
    {
        string gender;
        bool AdminStatus;
        private Timer messageTimer;
        private void setDefaultView()
        {
            btn_NewEmpSubmit.Enabled = false;
            btn_NewEmpSubmit.Visible = false;
            panel_EmpProfSub.Visible = false;
        }
        public Employee_Profiles()
        {
            InitializeComponent();
            setDefaultView();
            messageTimer = new Timer();
            messageTimer.Interval = 5000; //time for messages
            messageTimer.Tick += new EventHandler(MessageTimer_Tick);
        }

        private void MessageTimer_Tick(object sender, EventArgs e)
        {
            if (lbl_MainDisplay.Text != string.Empty)
                lbl_MainDisplay.Text = string.Empty;
            else 
                lbl_display.Text = string.Empty;
            messageTimer.Stop();
        }
        #region Reset Button commands

        private void clear()
        {
            txt_EmpIDInput.Text = string.Empty;
            txt_EmpID.Text = string.Empty;
            txt_EmpUname.Text = string.Empty;
            txt_EmpFName.Text = string.Empty;
            txt_EmpLName.Text = string.Empty;
            txt_EmpAddress.Text = string.Empty;
            txt_EmpEmail.Text = string.Empty;
            cb_EmpAdminStatus.Checked = false;
            txt_confPass.Text = string.Empty;
            txt_Pass.Text = string.Empty;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
        #endregion

        private void showSubPanel()
        {
            if (panel_EmpProfSub.Visible == false)
            {
                panel_EmpProfSub.Visible = true;  
            }
        }


        private void btn_AddNewEMP_Click(object sender, EventArgs e)
        {
            if (btn_NewEmpSubmit.Visible == false)
            {
                btn_UpdateEmp.Visible = false;
                btn_DeleteEmp.Visible = false;
                txt_Pass.Visible = true;
                lbl_Pass.Visible = true;
                txt_confPass.Visible = true;
                lbl_confPass.Visible = true;
                btn_NewEmpSubmit.Enabled = true;
                btn_NewEmpSubmit.Visible = true;
            }
            showSubPanel();
            clear();
        }

        #region Display Employee Info
        private void button1_Click(object sender, EventArgs e)
        {
            txt_Pass.Visible = true;
            lbl_Pass.Visible = true;
            txt_confPass.Visible = true;
            lbl_confPass.Visible = true;
            if (btn_NewEmpSubmit.Visible == true)
            {
                btn_UpdateEmp.Visible = true;
                btn_DeleteEmp.Visible = true;
                btn_NewEmpSubmit.Enabled = false;
                btn_NewEmpSubmit.Visible = false;
                rbtn_Female.Checked = false;    
                rbtn_Male.Checked = false;
                rbtn_Other.Checked = false;
            }
            

            string ID = txt_EmpIDInput.Text;

            

                if (ID != string.Empty)
                {
                    try
                    {
                        using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Chani\OneDrive - NSBM\Visual studio\Resturant management system\Resturant management system\Resturant Management DB.mdf"";Integrated Security=True"))
                        {
                            Connection.Open();
                            string getquery = $"SELECT EmpID, EmpUname, EmpFName, EmpLName, EmpAddress, EmpEmail, Admin, Gender, Pass, DOB FROM Login WHERE EmpID = @EmpID";
                            using (SqlCommand cmd = new SqlCommand(getquery, Connection))
                            {
                                cmd.Parameters.AddWithValue("@EmpID", ID);

                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        txt_EmpID.Text = reader["EmpID"].ToString();
                                        txt_EmpUname.Text = reader["EmpUname"].ToString();
                                        txt_EmpFName.Text = reader["EmpFName"].ToString();
                                        txt_EmpLName.Text = reader["EmpLName"].ToString();
                                        txt_EmpAddress.Text = reader["EmpAddress"].ToString();
                                        txt_EmpEmail.Text = reader["EmpEmail"].ToString();
                                        dtp_DOB.Text = reader["DOB"].ToString();
                                        
                                        #region Admin check
                                        string admin = reader["Admin"].ToString();
                                        if (admin == "True")
                                        {
                                            cb_EmpAdminStatus.Checked = true;
                                        }
                                        else
                                        {
                                            cb_EmpAdminStatus.Checked = false;
                                        }
                                        #endregion
                                        #region Gender Check
                                        string selectedGender = reader["Gender"].ToString();
                                        if (selectedGender == "Male")
                                        {
                                            rbtn_Male.Checked = true;
                                        }
                                        else if (selectedGender == "Female")
                                        {
                                            rbtn_Female.Checked = true;
                                        }
                                        else if (selectedGender == "Other")
                                        {
                                            rbtn_Other.Checked = true;
                                        }
                                        #endregion
                                        showSubPanel();
                                    }
                                    else
                                    {
                                        MessageBox.Show("No record found with the given ID.");
                                    }
                                }
                            }
                            Connection.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }

                }
                else
                {
                lbl_MainDisplay.ForeColor = Color.Red;
                lbl_MainDisplay.Text = "Please enter a Employee ID to proceed.";
                messageTimer.Start();
                }
        }
        #endregion

        #region Gender Selection
        private void rbtn_Male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void rbtn_Female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void rbtn_Other_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Other";
        }
        #endregion

        #region Add New Employee
        private void btn_NewEmpSubmit_Click(object sender, EventArgs e)
        {
            string ID = txt_EmpID.Text;
            string Uname = txt_EmpUname.Text;
            string Fname = txt_EmpFName.Text;
            string Lname = txt_EmpLName.Text;
            string Address = txt_EmpAddress.Text;
            string Email = txt_EmpEmail.Text;
            string SelectedGender = gender;
            string DOB = dtp_DOB.Text;

            bool AdminStatus = cb_EmpAdminStatus.Checked;
            string Pass = txt_Pass.Text;
            string ConfPass = txt_confPass.Text;

            if ((string.IsNullOrEmpty(ID) || string.IsNullOrEmpty(Uname) || string.IsNullOrEmpty(Fname) || string.IsNullOrEmpty(Lname) || string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Pass) || string.IsNullOrEmpty(ConfPass)) || (rbtn_Male.Checked == false && rbtn_Female.Checked == false && rbtn_Other.Checked == false))
            {
                lbl_display.ForeColor = System.Drawing.Color.Red;
                lbl_display.Text = "Please fill all above fields to proceed";
                messageTimer.Start();
            }
            else
            {
                // Validate password
                if (txt_confPass.Text != txt_Pass.Text)
                {
                    lbl_display.ForeColor = System.Drawing.Color.Red;
                    lbl_display.Text = "The passwords don't match, Please re-enter the correct passwords on both fields.";
                    messageTimer.Start();
                }
                else
                {
                    using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Chani\OneDrive - NSBM\Visual studio\Resturant management system\Resturant management system\Resturant Management DB.mdf"";Integrated Security=True"))
                    {
                        Connection.Open();
                        // Check if ID already exists
                        string checkQuery = $"SELECT COUNT(*) FROM Login WHERE EmpID = '{ID}'";
                        SqlCommand checkCmd = new SqlCommand(checkQuery, Connection);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("An employee with the same ID already exists.");
                        }
                        else
                        {
                            string submitquery = $"INSERT INTO Login (EmpID, EmpUname, EmpFName, EmpLName, EmpAddress, EmpEmail, Admin, Gender, Pass, DOB) VALUES ('{ID}', '{Uname}', '{Fname}', '{Lname}', '{Address}', '{Email}', '{AdminStatus}', '{SelectedGender}', '{Pass}', '{DOB}')";

                            try
                            {
                                SqlCommand cmd = new SqlCommand(submitquery, Connection);
                                cmd.ExecuteNonQuery();
                                lbl_display.ForeColor = System.Drawing.Color.DarkGreen;
                                lbl_display.Text = "Information submitted successfully!";
                                messageTimer.Start();
                                clear();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        Connection.Close();
                    }
                }
            }
        }
        #endregion

        private void cb_EmpAdminStatus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_Pass_TextChanged(object sender, EventArgs e)
        {

        }

        #region Delete Employee Record
        private void btn_DeleteEmp_Click(object sender, EventArgs e)
        {
            string ID = txt_EmpID.Text;

            SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Chani\OneDrive - NSBM\Visual studio\Resturant management system\Resturant management system\Resturant Management DB.mdf"";Integrated Security=True");
            if (!string.IsNullOrEmpty(ID))
            {
                try
                {
                    Connection.Open();
                    string deleteQuery = "DELETE FROM Login WHERE EmpID = @ID";

                    SqlCommand cmd = new SqlCommand(deleteQuery, Connection);
                    cmd.Parameters.AddWithValue("@ID", ID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        lbl_display.ForeColor = Color.Red;
                        lbl_display.Text = $"Employee record of Employee ID '{ID}' deleted successfully!";
                        messageTimer.Start();
                    }
                    else
                    {
                        MessageBox.Show("No record found with the given Employee ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    Connection.Close();
                }
            }
            else
            {
                lbl_display.ForeColor = Color.Red;
                lbl_display.Text = "Please Enter Employee ID in above field of the Form";
                messageTimer.Start();
            }
            
        }
        #endregion

        #region Update Employee Record
        private void btn_UpdateEmp_Click(object sender, EventArgs e)
        {
            string ID = txt_EmpID.Text;
            string Uname = txt_EmpUname.Text;
            string Fname = txt_EmpFName.Text;
            string Lname = txt_EmpLName.Text;
            string Address = txt_EmpAddress.Text;
            string Email = txt_EmpEmail.Text;
            string SelectedGender = gender;
            string DOB = dtp_DOB.Text;

            bool AdminStatus = cb_EmpAdminStatus.Checked;
            string Pass = txt_Pass.Text;
            string ConfPass = txt_confPass.Text;

            //Debugs
            /*
            if (string.IsNullOrEmpty(ID)) MessageBox.Show("ID is empty");
            if (string.IsNullOrEmpty(Uname)) MessageBox.Show("Uname is empty");
            if (string.IsNullOrEmpty(Fname)) MessageBox.Show("Fname is empty");
            if (string.IsNullOrEmpty(Lname)) MessageBox.Show("Lname is empty");
            if (string.IsNullOrEmpty(Address)) MessageBox.Show("Address is empty");
            if (string.IsNullOrEmpty(Email)) MessageBox.Show("Email is empty");
            if (string.IsNullOrEmpty(Pass)) MessageBox.Show("Pass is empty");
            if (string.IsNullOrEmpty(ConfPass)) MessageBox.Show("ConfPass is empty");
            if (!rbtn_Male.Checked && !rbtn_Female.Checked && !rbtn_Other.Checked) MessageBox.Show("Gender is not selected");
            */

            if (!string.IsNullOrEmpty(Pass) && !string.IsNullOrEmpty(ConfPass))
            {

                if ((string.IsNullOrEmpty(ID) || string.IsNullOrEmpty(Uname) || string.IsNullOrEmpty(Fname) || string.IsNullOrEmpty(Lname) || string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Pass) || string.IsNullOrEmpty(ConfPass)) || (rbtn_Male.Checked == false && rbtn_Female.Checked == false && rbtn_Other.Checked == false))
                {
                    lbl_display.ForeColor = System.Drawing.Color.Red;
                    lbl_display.Text = "Please fill all above fields to proceed";
                    messageTimer.Start();
                }
                else
                {
                    // Validate password
                    if (txt_confPass.Text != txt_Pass.Text)
                    {
                        lbl_display.ForeColor = System.Drawing.Color.Red;
                        lbl_display.Text = "The passwords don't match, Please re-enter the correct passwords on both fields.";
                        messageTimer.Start();
                    }
                    else
                    {
                        using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Chani\OneDrive - NSBM\Visual studio\Resturant management system\Resturant management system\Resturant Management DB.mdf"";Integrated Security=True"))
                        {
                            Connection.Open();
                            // Check if ID exists
                            string checkQuery = $"SELECT COUNT(*) FROM Login WHERE EmpID = '{ID}'";
                            SqlCommand checkCmd = new SqlCommand(checkQuery, Connection);
                            int count = (int)checkCmd.ExecuteScalar();

                            if (count == 0)
                            {
                                MessageBox.Show("No employee with the given ID exists.");
                            }
                            else
                            {
                                string updateQuery = $"UPDATE Login SET EmpUname = @EmpUname, EmpFName = @EmpFName, EmpLName = @EmpLName, EmpAddress = @EmpAddress, EmpEmail = @EmpEmail, Admin = @Admin, Gender = @Gender, Pass = @Pass, DOB = @DOB WHERE EmpID = @EmpID";

                                try
                                {
                                    SqlCommand cmd = new SqlCommand(updateQuery, Connection);
                                    //to stop SQL injection stuff
                                    cmd.Parameters.AddWithValue("@EmpID", ID);
                                    cmd.Parameters.AddWithValue("@EmpUname", Uname);
                                    cmd.Parameters.AddWithValue("@EmpFName", Fname);
                                    cmd.Parameters.AddWithValue("@EmpLName", Lname);
                                    cmd.Parameters.AddWithValue("@EmpAddress", Address);
                                    cmd.Parameters.AddWithValue("@EmpEmail", Email);
                                    cmd.Parameters.AddWithValue("@Admin", AdminStatus);
                                    cmd.Parameters.AddWithValue("@Gender", SelectedGender);
                                    cmd.Parameters.AddWithValue("@Pass", Pass);
                                    cmd.Parameters.AddWithValue("@DOB", DOB);

                                    cmd.ExecuteNonQuery();
                                    lbl_display.ForeColor = System.Drawing.Color.DarkGreen;
                                    lbl_display.Text = "Information updated successfully!";
                                    messageTimer.Start();
                                    clear();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            Connection.Close();
                        }
                    }
                }
            }
            else if (string.IsNullOrEmpty(Pass))
            {
                if ((string.IsNullOrEmpty(ID) || string.IsNullOrEmpty(Uname) || string.IsNullOrEmpty(Fname) || string.IsNullOrEmpty(Lname) || string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(Email)) || (rbtn_Male.Checked == false && rbtn_Female.Checked == false && rbtn_Other.Checked == false))
                {
                    lbl_display.ForeColor = System.Drawing.Color.Red;
                    lbl_display.Text = "Please fill all above fields to proceed";
                    messageTimer.Start();
                }
                else
                {
                    SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Chani\OneDrive - NSBM\Visual studio\Resturant management system\Resturant management system\Resturant Management DB.mdf"";Integrated Security=True");
                
                    Connection.Open();
                    // Check if ID exists
                    string checkQuery = $"SELECT COUNT(*) FROM Login WHERE EmpID = '{ID}'";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, Connection);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("No employee with the given ID exists.");
                    }
                    else
                    {
                        string updateQuery = $"UPDATE Login SET EmpUname = @EmpUname, EmpFName = @EmpFName, EmpLName = @EmpLName, EmpAddress = @EmpAddress, EmpEmail = @EmpEmail, Admin = @Admin, Gender = @Gender, Pass = @Pass, DOB = @DOB WHERE EmpID = @EmpID";

                        try
                        {
                            SqlCommand cmd = new SqlCommand(updateQuery, Connection);
                            //to stop SQL injection stuff
                            cmd.Parameters.AddWithValue("@EmpID", ID);
                            cmd.Parameters.AddWithValue("@EmpUname", Uname);
                            cmd.Parameters.AddWithValue("@EmpFName", Fname);
                            cmd.Parameters.AddWithValue("@EmpLName", Lname);
                            cmd.Parameters.AddWithValue("@EmpAddress", Address);
                            cmd.Parameters.AddWithValue("@EmpEmail", Email);
                            cmd.Parameters.AddWithValue("@Admin", AdminStatus);
                            cmd.Parameters.AddWithValue("@Gender", SelectedGender);
                            cmd.Parameters.AddWithValue("@Pass", Pass);
                            cmd.Parameters.AddWithValue("@DOB", DOB);

                            cmd.ExecuteNonQuery();
                            lbl_display.ForeColor = System.Drawing.Color.DarkGreen;
                            lbl_display.Text = "Information updated successfully!";
                            messageTimer.Start();
                            clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        Connection.Close();
                    }
                    
                }

            }
        }
        #endregion
    }
}
