namespace Resturant_management_system
{
    partial class Login
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
            this.lbl_Display = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.lbl_Uname = new System.Windows.Forms.Label();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_Uname = new System.Windows.Forms.TextBox();
            this.lbl_register = new System.Windows.Forms.Label();
            this.PB_Login = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_output = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Display
            // 
            this.lbl_Display.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Display.AutoSize = true;
            this.lbl_Display.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Display.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Display.Location = new System.Drawing.Point(497, 296);
            this.lbl_Display.Name = "lbl_Display";
            this.lbl_Display.Size = new System.Drawing.Size(282, 16);
            this.lbl_Display.TabIndex = 20;
            this.lbl_Display.Text = "Enter User information to Login to your Account";
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_exit.Location = new System.Drawing.Point(650, 478);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 17;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_login.Location = new System.Drawing.Point(545, 478);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 16;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Pass.Location = new System.Drawing.Point(542, 408);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(56, 13);
            this.lbl_Pass.TabIndex = 15;
            this.lbl_Pass.Text = "Password:";
            // 
            // lbl_Uname
            // 
            this.lbl_Uname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Uname.AutoSize = true;
            this.lbl_Uname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Uname.Location = new System.Drawing.Point(542, 359);
            this.lbl_Uname.Name = "lbl_Uname";
            this.lbl_Uname.Size = new System.Drawing.Size(58, 13);
            this.lbl_Uname.TabIndex = 14;
            this.lbl_Uname.Text = "Username:";
            // 
            // txt_Pass
            // 
            this.txt_Pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Pass.Location = new System.Drawing.Point(545, 424);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '*';
            this.txt_Pass.Size = new System.Drawing.Size(180, 20);
            this.txt_Pass.TabIndex = 13;
            // 
            // txt_Uname
            // 
            this.txt_Uname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Uname.Location = new System.Drawing.Point(545, 375);
            this.txt_Uname.Name = "txt_Uname";
            this.txt_Uname.Size = new System.Drawing.Size(180, 20);
            this.txt_Uname.TabIndex = 12;
            // 
            // lbl_register
            // 
            this.lbl_register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_register.AutoSize = true;
            this.lbl_register.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_register.Location = new System.Drawing.Point(428, 574);
            this.lbl_register.Name = "lbl_register";
            this.lbl_register.Size = new System.Drawing.Size(438, 13);
            this.lbl_register.TabIndex = 22;
            this.lbl_register.Text = "To register an Employee head over to the employee profiles tab (requires an admin" +
    " account)";
            // 
            // PB_Login
            // 
            this.PB_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PB_Login.BackColor = System.Drawing.Color.Navy;
            this.PB_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_Login.Image = global::Resturant_management_system.Properties.Resources.Login_icon;
            this.PB_Login.Location = new System.Drawing.Point(568, 156);
            this.PB_Login.Name = "PB_Login";
            this.PB_Login.Size = new System.Drawing.Size(132, 116);
            this.PB_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Login.TabIndex = 21;
            this.PB_Login.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(484, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 195);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_output
            // 
            this.lbl_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_output.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_output.Location = new System.Drawing.Point(526, 529);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(220, 19);
            this.lbl_output.TabIndex = 23;
            this.lbl_output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(1275, 656);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.lbl_register);
            this.Controls.Add(this.PB_Login);
            this.Controls.Add(this.lbl_Display);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.lbl_Uname);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_Uname);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login_Signup";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Login;
        private System.Windows.Forms.Label lbl_Display;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.Label lbl_Uname;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_Uname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_register;
        private System.Windows.Forms.Label lbl_output;
    }
}