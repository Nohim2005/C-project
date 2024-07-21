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
    public partial class Table_Reservations : Form
    {
        DataTable Reservation = new DataTable();
        private int selectedRowIndex = -1;
        public Table_Reservations()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            CIDBox.Text = "";
            CNameBox.Text = "";
            TableNoBox.Text = "";
            BookedTimeBox.Text = "";
            ReservationBox.Text = "";
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {

            String CID = CIDBox.Text;
            String Cname = CNameBox.Text;
            String TableNo = TableNoBox.Text;
            String BookedTime = BookedTimeBox.Text;
            String ReservationDate = ReservationBox.Text;

            if (selectedRowIndex >= 0)
            {
                // Update existing row
                Reservation.Rows[selectedRowIndex]["Customer ID"] = CID;
                Reservation.Rows[selectedRowIndex]["Customer Name"] = Cname;
                Reservation.Rows[selectedRowIndex]["Customer Contact"] = TableNo;
                Reservation.Rows[selectedRowIndex]["Booked Time"] = BookedTime;
                Reservation.Rows[selectedRowIndex]["Reservation Date"] = ReservationDate;

                selectedRowIndex = -1; // Reset the selected row index
            }
            else
            {
                // Add new row
                Reservation.Rows.Add(CID, Cname, TableNo, BookedTime, Reservation);
            }

            ClearButton_Click(sender, e); // Clear the input fields
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                Reservation.Rows[dataGridView1.CurrentCell.RowIndex].Delete();
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

                CIDBox.Text = Reservation.Rows[selectedRowIndex].ItemArray[0].ToString();
                CNameBox.Text = Reservation.Rows[selectedRowIndex].ItemArray[1].ToString();
                TableNoBox.Text = Reservation.Rows[selectedRowIndex].ItemArray[2].ToString();
                BookedTimeBox.Text = Reservation.Rows[selectedRowIndex].ItemArray[3].ToString();
                ReservationBox.Text = Reservation.Rows[selectedRowIndex].ItemArray[4].ToString();
            }
            catch (Exception Error)
            {
                Console.WriteLine("There has been an error " + Error);
            }
        }

        private void Table_Reservations_Load(object sender, EventArgs e)
        {
            Reservation.Columns.Add("Customer ID");
            Reservation.Columns.Add("Customer Name");
            Reservation.Columns.Add("Table No");
            Reservation.Columns.Add("Booked Time");
            Reservation.Columns.Add("Reservation Date");

            dataGridView1.DataSource = Reservation;
        }
    }
}
