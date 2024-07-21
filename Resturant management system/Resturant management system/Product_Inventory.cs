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
    public partial class Product_Inventory : Form
    {
        DataTable Inventory = new DataTable();
        private int selectedRowIndex = -1;
        public Product_Inventory()
        {
            InitializeComponent();
        }

        private void Datebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pricebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            IDbox.Text = "";
            Datebox.Text = "";
            Pricebox.Text = "";
            Namebox.Text = "";
            Qtybox.Text = "";
            Supplierbox.Text = "";
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            String ID = IDbox.Text;
            String Price = Pricebox.Text;
            String Name = Namebox.Text;
            String Quantity = Qtybox.Text;
            String Date = Datebox.Text;
            String Supplier = Supplierbox.Text;

            if (selectedRowIndex >= 0)
            {
                // Update existing row
                Inventory.Rows[selectedRowIndex]["ID"] = ID;
                Inventory.Rows[selectedRowIndex]["Price"] = Price;
                Inventory.Rows[selectedRowIndex]["Name"] = Name;
                Inventory.Rows[selectedRowIndex]["Quantity"] = Quantity;
                Inventory.Rows[selectedRowIndex]["Date"] = Date;
                Inventory.Rows[selectedRowIndex]["Supplier"] = Supplier;

                selectedRowIndex = -1; // Reset the selected row index
            }
            else
            {
                // Add new row
                Inventory.Rows.Add(ID, Date, Price, Quantity, Supplier);
            }

            ClearButton_Click(sender, e); // Clear the input fields
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                Inventory.Rows[InventoryGridview.CurrentCell.RowIndex].Delete();
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

        private void InventoryGridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRowIndex = InventoryGridview.CurrentCell.RowIndex;

                IDbox.Text = Inventory.Rows[selectedRowIndex].ItemArray[0].ToString();
                Namebox.Text = Inventory.Rows[selectedRowIndex].ItemArray[1].ToString();
                Pricebox.Text = Inventory.Rows[selectedRowIndex].ItemArray[3].ToString();
                Qtybox.Text = Inventory.Rows[selectedRowIndex].ItemArray[4].ToString();
                Datebox.Text = Inventory.Rows[selectedRowIndex].ItemArray[2].ToString();
                Supplierbox.Text = Inventory.Rows[selectedRowIndex].ItemArray[5].ToString();

            }
            catch (Exception Error)
            {
                Console.WriteLine("There has been an error " + Error);
            }
        }

        private void Product_Inventory_Load(object sender, EventArgs e)
        {

            Inventory.Columns.Add("ID");
            Inventory.Columns.Add("Date");
            Inventory.Columns.Add("Price");
            Inventory.Columns.Add("Name");
            Inventory.Columns.Add("Quantity");
            Inventory.Columns.Add("Supplier");

            InventoryGridview.DataSource = Inventory;
        }
    }
}
