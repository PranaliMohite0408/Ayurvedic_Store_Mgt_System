namespace Ayurvedic_Store_Management_System
{
    partial class frm_Distributor
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
            this.pnl_Distributor = new System.Windows.Forms.Panel();
            this.lbl_Distributor = new System.Windows.Forms.Label();
            this.tb_Note = new System.Windows.Forms.TextBox();
            this.tb_Reg_No = new System.Windows.Forms.TextBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.lbl_Reg_No = new System.Windows.Forms.Label();
            this.lbl_Aadhar_Card_No = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Distributor_Name = new System.Windows.Forms.TextBox();
            this.tb_Aadhar_Card_No = new System.Windows.Forms.TextBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Pan_Card_Name = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Phone_No = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.tb_Pan_Card_No = new System.Windows.Forms.TextBox();
            this.tb_Phone_No = new System.Windows.Forms.TextBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Distributor_ID = new System.Windows.Forms.TextBox();
            this.lbl_Distributor_Name = new System.Windows.Forms.Label();
            this.lbl_Distributor_ID = new System.Windows.Forms.Label();
            this.pnl_Distributor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Distributor
            // 
            this.pnl_Distributor.BackColor = System.Drawing.Color.Purple;
            this.pnl_Distributor.Controls.Add(this.lbl_Distributor);
            this.pnl_Distributor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Distributor.Location = new System.Drawing.Point(0, 0);
            this.pnl_Distributor.Name = "pnl_Distributor";
            this.pnl_Distributor.Size = new System.Drawing.Size(1898, 100);
            this.pnl_Distributor.TabIndex = 55;
            // 
            // lbl_Distributor
            // 
            this.lbl_Distributor.AutoSize = true;
            this.lbl_Distributor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Distributor.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Distributor.ForeColor = System.Drawing.Color.White;
            this.lbl_Distributor.Location = new System.Drawing.Point(774, 22);
            this.lbl_Distributor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Distributor.Name = "lbl_Distributor";
            this.lbl_Distributor.Size = new System.Drawing.Size(313, 62);
            this.lbl_Distributor.TabIndex = 56;
            this.lbl_Distributor.Text = "Distributor";
            // 
            // tb_Note
            // 
            this.tb_Note.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Note.Location = new System.Drawing.Point(1300, 569);
            this.tb_Note.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Note.MaxLength = 30;
            this.tb_Note.Multiline = true;
            this.tb_Note.Name = "tb_Note";
            this.tb_Note.Size = new System.Drawing.Size(366, 130);
            this.tb_Note.TabIndex = 10;
            this.tb_Note.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Alpha_Numeric);
            // 
            // tb_Reg_No
            // 
            this.tb_Reg_No.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Reg_No.Location = new System.Drawing.Point(1300, 466);
            this.tb_Reg_No.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Reg_No.MaxLength = 30;
            this.tb_Reg_No.Name = "tb_Reg_No";
            this.tb_Reg_No.Size = new System.Drawing.Size(366, 42);
            this.tb_Reg_No.TabIndex = 9;
            this.tb_Reg_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Address
            // 
            this.tb_Address.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(426, 548);
            this.tb_Address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Address.MaxLength = 30;
            this.tb_Address.Multiline = true;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(386, 130);
            this.tb_Address.TabIndex = 5;
            this.tb_Address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Alpha_Numeric);
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Note.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Note.Location = new System.Drawing.Point(911, 570);
            this.lbl_Note.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(119, 53);
            this.lbl_Note.TabIndex = 54;
            this.lbl_Note.Text = "Note";
            // 
            // lbl_Reg_No
            // 
            this.lbl_Reg_No.AutoSize = true;
            this.lbl_Reg_No.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Reg_No.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Reg_No.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Reg_No.Location = new System.Drawing.Point(895, 467);
            this.lbl_Reg_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Reg_No.Name = "lbl_Reg_No";
            this.lbl_Reg_No.Size = new System.Drawing.Size(175, 53);
            this.lbl_Reg_No.TabIndex = 53;
            this.lbl_Reg_No.Text = "Reg No";
            // 
            // lbl_Aadhar_Card_No
            // 
            this.lbl_Aadhar_Card_No.AutoSize = true;
            this.lbl_Aadhar_Card_No.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Aadhar_Card_No.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Aadhar_Card_No.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Aadhar_Card_No.Location = new System.Drawing.Point(895, 269);
            this.lbl_Aadhar_Card_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Aadhar_Card_No.Name = "lbl_Aadhar_Card_No";
            this.lbl_Aadhar_Card_No.Size = new System.Drawing.Size(365, 53);
            this.lbl_Aadhar_Card_No.TabIndex = 52;
            this.lbl_Aadhar_Card_No.Text = "Aadhar Card No";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(830, 708);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(200, 75);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(1300, 161);
            this.dtp_Date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(366, 42);
            this.dtp_Date.TabIndex = 6;
            // 
            // tb_Distributor_Name
            // 
            this.tb_Distributor_Name.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Distributor_Name.Location = new System.Drawing.Point(426, 262);
            this.tb_Distributor_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Distributor_Name.MaxLength = 30;
            this.tb_Distributor_Name.Name = "tb_Distributor_Name";
            this.tb_Distributor_Name.Size = new System.Drawing.Size(386, 42);
            this.tb_Distributor_Name.TabIndex = 2;
            this.tb_Distributor_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // tb_Aadhar_Card_No
            // 
            this.tb_Aadhar_Card_No.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Aadhar_Card_No.Location = new System.Drawing.Point(1300, 263);
            this.tb_Aadhar_Card_No.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Aadhar_Card_No.MaxLength = 12;
            this.tb_Aadhar_Card_No.Name = "tb_Aadhar_Card_No";
            this.tb_Aadhar_Card_No.Size = new System.Drawing.Size(366, 42);
            this.tb_Aadhar_Card_No.TabIndex = 7;
            this.tb_Aadhar_Card_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Date.Location = new System.Drawing.Point(895, 174);
            this.lbl_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(122, 53);
            this.lbl_Date.TabIndex = 51;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_Pan_Card_Name
            // 
            this.lbl_Pan_Card_Name.AutoSize = true;
            this.lbl_Pan_Card_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Pan_Card_Name.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pan_Card_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Pan_Card_Name.Location = new System.Drawing.Point(895, 364);
            this.lbl_Pan_Card_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Pan_Card_Name.Name = "lbl_Pan_Card_Name";
            this.lbl_Pan_Card_Name.Size = new System.Drawing.Size(292, 53);
            this.lbl_Pan_Card_Name.TabIndex = 50;
            this.lbl_Pan_Card_Name.Text = "Pan Card No";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Address.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Address.Location = new System.Drawing.Point(23, 564);
            this.lbl_Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(188, 53);
            this.lbl_Address.TabIndex = 49;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_Phone_No
            // 
            this.lbl_Phone_No.AutoSize = true;
            this.lbl_Phone_No.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Phone_No.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phone_No.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Phone_No.Location = new System.Drawing.Point(23, 452);
            this.lbl_Phone_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Phone_No.Name = "lbl_Phone_No";
            this.lbl_Phone_No.Size = new System.Drawing.Size(230, 53);
            this.lbl_Phone_No.TabIndex = 48;
            this.lbl_Phone_No.Text = "Phone No";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Mobile_No.Location = new System.Drawing.Point(23, 354);
            this.lbl_Mobile_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(242, 53);
            this.lbl_Mobile_No.TabIndex = 47;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // tb_Pan_Card_No
            // 
            this.tb_Pan_Card_No.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Pan_Card_No.Location = new System.Drawing.Point(1299, 367);
            this.tb_Pan_Card_No.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Pan_Card_No.MaxLength = 15;
            this.tb_Pan_Card_No.Name = "tb_Pan_Card_No";
            this.tb_Pan_Card_No.Size = new System.Drawing.Size(366, 42);
            this.tb_Pan_Card_No.TabIndex = 8;
            this.tb_Pan_Card_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Alpha_Numeric);
            // 
            // tb_Phone_No
            // 
            this.tb_Phone_No.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Phone_No.Location = new System.Drawing.Point(426, 463);
            this.tb_Phone_No.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Phone_No.MaxLength = 10;
            this.tb_Phone_No.Name = "tb_Phone_No";
            this.tb_Phone_No.Size = new System.Drawing.Size(386, 42);
            this.tb_Phone_No.TabIndex = 4;
            this.tb_Phone_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(426, 367);
            this.tb_Mobile_No.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(386, 42);
            this.tb_Mobile_No.TabIndex = 3;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Distributor_ID
            // 
            this.tb_Distributor_ID.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Distributor_ID.Location = new System.Drawing.Point(426, 167);
            this.tb_Distributor_ID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Distributor_ID.MaxLength = 4;
            this.tb_Distributor_ID.Name = "tb_Distributor_ID";
            this.tb_Distributor_ID.Size = new System.Drawing.Size(386, 42);
            this.tb_Distributor_ID.TabIndex = 1;
            this.tb_Distributor_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Distributor_Name
            // 
            this.lbl_Distributor_Name.AutoSize = true;
            this.lbl_Distributor_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Distributor_Name.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Distributor_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Distributor_Name.Location = new System.Drawing.Point(23, 251);
            this.lbl_Distributor_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Distributor_Name.Name = "lbl_Distributor_Name";
            this.lbl_Distributor_Name.Size = new System.Drawing.Size(394, 53);
            this.lbl_Distributor_Name.TabIndex = 46;
            this.lbl_Distributor_Name.Text = "Distributor Name";
            // 
            // lbl_Distributor_ID
            // 
            this.lbl_Distributor_ID.AutoSize = true;
            this.lbl_Distributor_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Distributor_ID.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Distributor_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Distributor_ID.Location = new System.Drawing.Point(29, 167);
            this.lbl_Distributor_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Distributor_ID.Name = "lbl_Distributor_ID";
            this.lbl_Distributor_ID.Size = new System.Drawing.Size(333, 53);
            this.lbl_Distributor_ID.TabIndex = 45;
            this.lbl_Distributor_ID.Text = "Distributor ID";
            // 
            // frm_Distributor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.pnl_Distributor);
            this.Controls.Add(this.tb_Note);
            this.Controls.Add(this.tb_Reg_No);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.lbl_Note);
            this.Controls.Add(this.lbl_Reg_No);
            this.Controls.Add(this.lbl_Aadhar_Card_No);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.tb_Distributor_Name);
            this.Controls.Add(this.tb_Aadhar_Card_No);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Pan_Card_Name);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_Phone_No);
            this.Controls.Add(this.lbl_Mobile_No);
            this.Controls.Add(this.tb_Pan_Card_No);
            this.Controls.Add(this.tb_Phone_No);
            this.Controls.Add(this.tb_Mobile_No);
            this.Controls.Add(this.tb_Distributor_ID);
            this.Controls.Add(this.lbl_Distributor_Name);
            this.Controls.Add(this.lbl_Distributor_ID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Distributor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distributor";
            this.Load += new System.EventHandler(this.frm_Distributor_Load);
            this.pnl_Distributor.ResumeLayout(false);
            this.pnl_Distributor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Distributor;
        private System.Windows.Forms.TextBox tb_Note;
        private System.Windows.Forms.TextBox tb_Reg_No;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.Label lbl_Reg_No;
        private System.Windows.Forms.Label lbl_Aadhar_Card_No;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.TextBox tb_Distributor_Name;
        private System.Windows.Forms.TextBox tb_Aadhar_Card_No;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Pan_Card_Name;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Phone_No;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.TextBox tb_Pan_Card_No;
        private System.Windows.Forms.TextBox tb_Phone_No;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_Distributor_ID;
        private System.Windows.Forms.Label lbl_Distributor_Name;
        private System.Windows.Forms.Label lbl_Distributor_ID;
        private System.Windows.Forms.Label lbl_Distributor;
    }
}