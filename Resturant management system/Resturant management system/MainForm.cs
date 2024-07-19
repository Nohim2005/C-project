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

    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }
        #region Flowmenus/Submenu hide/show

        //DO NOT MESS WITH "hideSubMenu()" and "showSubMenu" DO NOT!!!!
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
        #endregion

        private Form activeForm = null;
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

        #region Main Buttons (nothing more to do here)
        private void btn_Kitchen_Click(object sender, EventArgs e)
        {
            
            showSubMenu(panel_KitchenSub);

        }

        private void panel_Nav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            //hideSubMenu();
            showSubMenu(panel_StaffSub);

        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            //hideSubMenu();
            showSubMenu(panel_ProductSub);
        }

        private void btn_Table_Click(object sender, EventArgs e)
        {
            //hideSubMenu();
            showSubMenu(panel_TableSub);
        }
        #endregion

        #region //Kitchen Sub Buttons (your code goes here)//
        private void btn_KitchenSub_Menu_Click(object sender, EventArgs e)
        {
            openChildForm(new MenuOptions());
        }

        private void btn_KitchenSub_Orders_Click(object sender, EventArgs e)
        {
            openChildForm(new Orders());
        }

        private void btn_KitchenSub_Reports_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region //Staff Sub Buttons (your code goes here)//

        private void btn_StaffSub_EmployeeProfile_Click(object sender, EventArgs e)
        {

        }

        private void btn_StaffSub_Tasks_Click(object sender, EventArgs e)
        {

        }

        private void btn_StaffSub_Schedule_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region //Products Sub Buttons (your code goes here)//

        private void btn_ProductSub_Inventory_Click(object sender, EventArgs e)
        {

        }

        private void btn_ProductSub_Suppliers_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region //Table Sub Buttons (your code goes here)//
        private void btn_TableSub_Reservations_Click(object sender, EventArgs e)
        {

        }

        private void btn_TableSub_Cleaning_Click(object sender, EventArgs e)
        {

        }
        #endregion




    }
}
