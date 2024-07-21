namespace Resturant_management_system
{
    partial class Product_Inventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Updatebutton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Namebox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.Supplierbox = new System.Windows.Forms.TextBox();
            this.Qtybox = new System.Windows.Forms.TextBox();
            this.Pricebox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Datebox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IDbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.InventoryGridview = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // Updatebutton
            // 
            this.Updatebutton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebutton.Location = new System.Drawing.Point(38, 540);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(262, 56);
            this.Updatebutton.TabIndex = 20;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(48, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 67);
            this.label7.TabIndex = 12;
            this.label7.Text = "Inventory Management Table";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Deletebutton
            // 
            this.Deletebutton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.Location = new System.Drawing.Point(38, 478);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(262, 56);
            this.Deletebutton.TabIndex = 19;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = true;
            // 
            // Addbutton
            // 
            this.Addbutton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.Location = new System.Drawing.Point(38, 416);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(262, 56);
            this.Addbutton.TabIndex = 18;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.Updatebutton);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Namebox);
            this.panel1.Controls.Add(this.Deletebutton);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.Supplierbox);
            this.panel1.Controls.Add(this.Addbutton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Qtybox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Pricebox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Datebox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.IDbox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 774);
            this.panel1.TabIndex = 14;
            // 
            // Namebox
            // 
            this.Namebox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namebox.ForeColor = System.Drawing.Color.White;
            this.Namebox.Location = new System.Drawing.Point(136, 242);
            this.Namebox.Name = "Namebox";
            this.Namebox.Size = new System.Drawing.Size(165, 22);
            this.Namebox.TabIndex = 9;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(38, 354);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(262, 56);
            this.ClearButton.TabIndex = 17;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // Supplierbox
            // 
            this.Supplierbox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplierbox.ForeColor = System.Drawing.Color.White;
            this.Supplierbox.Location = new System.Drawing.Point(136, 314);
            this.Supplierbox.Name = "Supplierbox";
            this.Supplierbox.Size = new System.Drawing.Size(165, 22);
            this.Supplierbox.TabIndex = 11;
            // 
            // Qtybox
            // 
            this.Qtybox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qtybox.ForeColor = System.Drawing.Color.White;
            this.Qtybox.Location = new System.Drawing.Point(136, 278);
            this.Qtybox.Name = "Qtybox";
            this.Qtybox.Size = new System.Drawing.Size(165, 22);
            this.Qtybox.TabIndex = 10;
            // 
            // Pricebox
            // 
            this.Pricebox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pricebox.ForeColor = System.Drawing.Color.White;
            this.Pricebox.Location = new System.Drawing.Point(137, 207);
            this.Pricebox.Name = "Pricebox";
            this.Pricebox.Size = new System.Drawing.Size(165, 22);
            this.Pricebox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Supplier:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Datebox
            // 
            this.Datebox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datebox.ForeColor = System.Drawing.Color.White;
            this.Datebox.Location = new System.Drawing.Point(136, 171);
            this.Datebox.Name = "Datebox";
            this.Datebox.Size = new System.Drawing.Size(165, 22);
            this.Datebox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price:";
            // 
            // IDbox
            // 
            this.IDbox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDbox.ForeColor = System.Drawing.Color.White;
            this.IDbox.Location = new System.Drawing.Point(136, 135);
            this.IDbox.Name = "IDbox";
            this.IDbox.Size = new System.Drawing.Size(165, 22);
            this.IDbox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(34, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InventoryGridview
            // 
            this.InventoryGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InventoryGridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(84)))));
            this.InventoryGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryGridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryGridview.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.InventoryGridview.Location = new System.Drawing.Point(0, 0);
            this.InventoryGridview.Name = "InventoryGridview";
            this.InventoryGridview.Size = new System.Drawing.Size(1229, 774);
            this.InventoryGridview.TabIndex = 15;
            // 
            // Product_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 774);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InventoryGridview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product_Inventory";
            this.Text = "Product_Inventory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Namebox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox Supplierbox;
        private System.Windows.Forms.TextBox Qtybox;
        private System.Windows.Forms.TextBox Pricebox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Datebox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IDbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView InventoryGridview;
    }
}