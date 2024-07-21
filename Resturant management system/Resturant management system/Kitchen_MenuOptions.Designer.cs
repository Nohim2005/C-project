namespace Resturant_management_system
{
    partial class Kitchen_MenuOptions
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.resturant_Management_DBDataSet = new Resturant_management_system.Resturant_Management_DBDataSet();
            this.resturantManagementDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resturant_Management_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resturantManagementDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 706);
            this.panel1.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.MediumPurple;
            this.panel8.Controls.Add(this.label1);
            this.panel8.Location = new System.Drawing.Point(558, 8);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(168, 69);
            this.panel8.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.resturantManagementDBDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(73, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1125, 584);
            this.dataGridView1.TabIndex = 4;
            // 
            // resturant_Management_DBDataSet
            // 
            this.resturant_Management_DBDataSet.DataSetName = "Resturant_Management_DBDataSet";
            this.resturant_Management_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resturantManagementDBDataSetBindingSource
            // 
            this.resturantManagementDBDataSetBindingSource.DataSource = this.resturant_Management_DBDataSet;
            this.resturantManagementDBDataSetBindingSource.Position = 0;
            // 
            // Kitchen_MenuOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 706);
            this.Controls.Add(this.panel1);
            this.Name = "Kitchen_MenuOptions";
            this.Text = "Kitchen_MenuOptions";
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resturant_Management_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resturantManagementDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource resturantManagementDBDataSetBindingSource;
        private Resturant_Management_DBDataSet resturant_Management_DBDataSet;
    }
}