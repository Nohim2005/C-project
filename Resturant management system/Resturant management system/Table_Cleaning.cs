using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_management_system
{
    public partial class Table_Cleaning : Form
    {
        DataTable Cleaning = new DataTable();
        private int selectedRowIndex = -1;
        public Table_Cleaning()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            EIDBox.Text = "";
            ENameBox.Text = "";
            TableNoBox.Text = "";
            AssignedTimeBox.Text = "";
            EDatebox.Text = "";
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            String EID = EIDBox.Text;
            String Ename = ENameBox.Text;
            String TableNo = TableNoBox.Text;
            String AssignedTime = AssignedTimeBox.Text;
            String Date = EDatebox.Text;

            if (selectedRowIndex >= 0)
            {
                // Update existing row
                Cleaning.Rows[selectedRowIndex]["Employee ID"] = EID;
                Cleaning.Rows[selectedRowIndex]["Employee Name"] = Ename;
                Cleaning.Rows[selectedRowIndex]["Table No"] = TableNo;
                Cleaning.Rows[selectedRowIndex]["Assigned Time"] = AssignedTime;
                Cleaning.Rows[selectedRowIndex]["Employed Date"] = Date;

                selectedRowIndex = -1; // Reset the selected row index
            }
            else
            {
                // Add new row
                Cleaning.Rows.Add(EID, Ename, TableNo, AssignedTime, Date);
            }

            ClearButton_Click(sender, e); // Clear the input fields
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                Cleaning.Rows[dataGridView1.CurrentCell.RowIndex].Delete();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error);
            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            Addbutton_Click(sender, e);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

                EIDBox.Text = Cleaning.Rows[selectedRowIndex].ItemArray[0].ToString();
                ENameBox.Text = Cleaning.Rows[selectedRowIndex].ItemArray[1].ToString();
                TableNoBox.Text = Cleaning.Rows[selectedRowIndex].ItemArray[2].ToString();
                AssignedTimeBox.Text = Cleaning.Rows[selectedRowIndex].ItemArray[3].ToString();
                EDatebox.Text = Cleaning.Rows[selectedRowIndex].ItemArray[4].ToString();
            }
            catch (Exception Error)
            {
                Console.WriteLine("There has been an error " + Error);
            }
        }

        private void Table_Cleaning_Load(object sender, EventArgs e)
        {
            Cleaning.Columns.Add("Employee ID");
            Cleaning.Columns.Add("Employee Name");
            Cleaning.Columns.Add("Table No");
            Cleaning.Columns.Add("Assigned Time");
            Cleaning.Columns.Add("Employed Date");

            dataGridView1.DataSource = Cleaning;
        }
    }
}
