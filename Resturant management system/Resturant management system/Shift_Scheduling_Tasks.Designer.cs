namespace Resturant_management_system
{
    partial class Shift_Scheduling_Tasks
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
            this.panel_scheduletasks = new System.Windows.Forms.Panel();
            this.panel_Delivery = new System.Windows.Forms.Panel();
            this.panel_Waiting = new System.Windows.Forms.Panel();
            this.panel_Reception = new System.Windows.Forms.Panel();
            this.panel_Kitchen = new System.Windows.Forms.Panel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel_DeliveryLabel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_WaitingLabel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_ReceptionLabel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_KitchenLabel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Emp = new System.Windows.Forms.ComboBox();
            this.CB_Role = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_addtoSchedule = new System.Windows.Forms.Button();
            this.btn_removefromSchedule = new System.Windows.Forms.Button();
            this.lbl_results = new System.Windows.Forms.Label();
            this.panel_scheduletasks.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel_DeliveryLabel.SuspendLayout();
            this.panel_WaitingLabel.SuspendLayout();
            this.panel_ReceptionLabel.SuspendLayout();
            this.panel_KitchenLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_scheduletasks
            // 
            this.panel_scheduletasks.Controls.Add(this.panel_Delivery);
            this.panel_scheduletasks.Controls.Add(this.panel_Waiting);
            this.panel_scheduletasks.Controls.Add(this.panel_Reception);
            this.panel_scheduletasks.Controls.Add(this.panel_Kitchen);
            this.panel_scheduletasks.Controls.Add(this.lbl_Date);
            this.panel_scheduletasks.Location = new System.Drawing.Point(401, 55);
            this.panel_scheduletasks.Name = "panel_scheduletasks";
            this.panel_scheduletasks.Size = new System.Drawing.Size(834, 541);
            this.panel_scheduletasks.TabIndex = 0;
            // 
            // panel_Delivery
            // 
            this.panel_Delivery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Delivery.Location = new System.Drawing.Point(0, 415);
            this.panel_Delivery.Name = "panel_Delivery";
            this.panel_Delivery.Size = new System.Drawing.Size(834, 125);
            this.panel_Delivery.TabIndex = 4;
            this.panel_Delivery.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Border);
            // 
            // panel_Waiting
            // 
            this.panel_Waiting.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Waiting.Location = new System.Drawing.Point(0, 290);
            this.panel_Waiting.Name = "panel_Waiting";
            this.panel_Waiting.Size = new System.Drawing.Size(834, 125);
            this.panel_Waiting.TabIndex = 3;
            this.panel_Waiting.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Border);
            // 
            // panel_Reception
            // 
            this.panel_Reception.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Reception.Location = new System.Drawing.Point(0, 165);
            this.panel_Reception.Name = "panel_Reception";
            this.panel_Reception.Size = new System.Drawing.Size(834, 125);
            this.panel_Reception.TabIndex = 2;
            this.panel_Reception.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Border);
            // 
            // panel_Kitchen
            // 
            this.panel_Kitchen.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Kitchen.Location = new System.Drawing.Point(0, 40);
            this.panel_Kitchen.Name = "panel_Kitchen";
            this.panel_Kitchen.Size = new System.Drawing.Size(834, 125);
            this.panel_Kitchen.TabIndex = 1;
            this.panel_Kitchen.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Border);
            // 
            // lbl_Date
            // 
            this.lbl_Date.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Date.Location = new System.Drawing.Point(0, 0);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(834, 40);
            this.lbl_Date.TabIndex = 0;
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel_DeliveryLabel);
            this.panel5.Controls.Add(this.panel_WaitingLabel);
            this.panel5.Controls.Add(this.panel_ReceptionLabel);
            this.panel5.Controls.Add(this.panel_KitchenLabel);
            this.panel5.Location = new System.Drawing.Point(282, 95);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(122, 501);
            this.panel5.TabIndex = 1;
            // 
            // panel_DeliveryLabel
            // 
            this.panel_DeliveryLabel.Controls.Add(this.label4);
            this.panel_DeliveryLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_DeliveryLabel.Location = new System.Drawing.Point(0, 375);
            this.panel_DeliveryLabel.Name = "panel_DeliveryLabel";
            this.panel_DeliveryLabel.Size = new System.Drawing.Size(122, 126);
            this.panel_DeliveryLabel.TabIndex = 3;
            this.panel_DeliveryLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Border);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(18, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 76);
            this.label4.TabIndex = 1;
            this.label4.Text = "Delivery";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_WaitingLabel
            // 
            this.panel_WaitingLabel.Controls.Add(this.label3);
            this.panel_WaitingLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_WaitingLabel.Location = new System.Drawing.Point(0, 250);
            this.panel_WaitingLabel.Name = "panel_WaitingLabel";
            this.panel_WaitingLabel.Size = new System.Drawing.Size(122, 125);
            this.panel_WaitingLabel.TabIndex = 2;
            this.panel_WaitingLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Border);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(18, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 75);
            this.label3.TabIndex = 1;
            this.label3.Text = "Waiting";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_ReceptionLabel
            // 
            this.panel_ReceptionLabel.Controls.Add(this.label2);
            this.panel_ReceptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ReceptionLabel.Location = new System.Drawing.Point(0, 125);
            this.panel_ReceptionLabel.Name = "panel_ReceptionLabel";
            this.panel_ReceptionLabel.Size = new System.Drawing.Size(122, 125);
            this.panel_ReceptionLabel.TabIndex = 1;
            this.panel_ReceptionLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Border);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(18, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 75);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reception";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_KitchenLabel
            // 
            this.panel_KitchenLabel.Controls.Add(this.label1);
            this.panel_KitchenLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_KitchenLabel.Location = new System.Drawing.Point(0, 0);
            this.panel_KitchenLabel.Name = "panel_KitchenLabel";
            this.panel_KitchenLabel.Size = new System.Drawing.Size(122, 125);
            this.panel_KitchenLabel.TabIndex = 0;
            this.panel_KitchenLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Border);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitchen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CB_Emp
            // 
            this.CB_Emp.FormattingEnabled = true;
            this.CB_Emp.Location = new System.Drawing.Point(35, 141);
            this.CB_Emp.Name = "CB_Emp";
            this.CB_Emp.Size = new System.Drawing.Size(188, 21);
            this.CB_Emp.TabIndex = 2;
            // 
            // CB_Role
            // 
            this.CB_Role.FormattingEnabled = true;
            this.CB_Role.Items.AddRange(new object[] {
            "Kitchen",
            "Reception",
            "Waiting",
            "Delivery"});
            this.CB_Role.Location = new System.Drawing.Point(35, 244);
            this.CB_Role.Name = "CB_Role";
            this.CB_Role.Size = new System.Drawing.Size(188, 21);
            this.CB_Role.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(35, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select Employee:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(35, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Select Role:";
            // 
            // btn_addtoSchedule
            // 
            this.btn_addtoSchedule.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_addtoSchedule.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_addtoSchedule.Location = new System.Drawing.Point(56, 322);
            this.btn_addtoSchedule.Name = "btn_addtoSchedule";
            this.btn_addtoSchedule.Size = new System.Drawing.Size(148, 23);
            this.btn_addtoSchedule.TabIndex = 17;
            this.btn_addtoSchedule.Text = "Add to schedule";
            this.btn_addtoSchedule.UseVisualStyleBackColor = false;
            this.btn_addtoSchedule.Click += new System.EventHandler(this.btn_addtoSchedule_Click);
            // 
            // btn_removefromSchedule
            // 
            this.btn_removefromSchedule.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_removefromSchedule.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_removefromSchedule.Location = new System.Drawing.Point(56, 362);
            this.btn_removefromSchedule.Name = "btn_removefromSchedule";
            this.btn_removefromSchedule.Size = new System.Drawing.Size(148, 23);
            this.btn_removefromSchedule.TabIndex = 18;
            this.btn_removefromSchedule.Text = "Remove from schedule";
            this.btn_removefromSchedule.UseVisualStyleBackColor = false;
            this.btn_removefromSchedule.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_results
            // 
            this.lbl_results.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_results.Location = new System.Drawing.Point(12, 288);
            this.lbl_results.Name = "lbl_results";
            this.lbl_results.Size = new System.Drawing.Size(264, 22);
            this.lbl_results.TabIndex = 19;
            this.lbl_results.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Shift_Scheduling_Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(1275, 656);
            this.Controls.Add(this.lbl_results);
            this.Controls.Add(this.btn_removefromSchedule);
            this.Controls.Add(this.btn_addtoSchedule);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CB_Role);
            this.Controls.Add(this.CB_Emp);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel_scheduletasks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Shift_Scheduling_Tasks";
            this.Text = "Shift_Scheduling_Tasks";
            this.panel_scheduletasks.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel_DeliveryLabel.ResumeLayout(false);
            this.panel_WaitingLabel.ResumeLayout(false);
            this.panel_ReceptionLabel.ResumeLayout(false);
            this.panel_KitchenLabel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_scheduletasks;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Panel panel_Kitchen;
        private System.Windows.Forms.Panel panel_Delivery;
        private System.Windows.Forms.Panel panel_Waiting;
        private System.Windows.Forms.Panel panel_Reception;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel_DeliveryLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_WaitingLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_ReceptionLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_KitchenLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Emp;
        private System.Windows.Forms.ComboBox CB_Role;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_addtoSchedule;
        private System.Windows.Forms.Button btn_removefromSchedule;
        private System.Windows.Forms.Label lbl_results;
    }
}