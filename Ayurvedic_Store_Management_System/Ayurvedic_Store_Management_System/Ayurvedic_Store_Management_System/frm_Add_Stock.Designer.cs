namespace Ayurvedic_Store_Management_System
{
    partial class frm_Add_Stock
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.dtp_Expiry_Date = new System.Windows.Forms.DateTimePicker();
            this.dtp_Mfg_Date = new System.Windows.Forms.DateTimePicker();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_New_Stock = new System.Windows.Forms.TextBox();
            this.tb_Current_Stock = new System.Windows.Forms.TextBox();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Expiry_Date = new System.Windows.Forms.Label();
            this.lbl_Mfg_Date = new System.Windows.Forms.Label();
            this.lbl_New_Stock = new System.Windows.Forms.Label();
            this.lbl_Current_Stock = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Product_ID = new System.Windows.Forms.Label();
            this.lbl_Add_Stock = new System.Windows.Forms.Label();
            this.pnl_Add_Stock = new System.Windows.Forms.Panel();
            this.lbl_Product_Category = new System.Windows.Forms.Label();
            this.cmb_Product_Category = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.pnl_Add_Stock.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(828, 616);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(170, 73);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // dtp_Expiry_Date
            // 
            this.dtp_Expiry_Date.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Expiry_Date.Location = new System.Drawing.Point(1387, 461);
            this.dtp_Expiry_Date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_Expiry_Date.Name = "dtp_Expiry_Date";
            this.dtp_Expiry_Date.Size = new System.Drawing.Size(382, 42);
            this.dtp_Expiry_Date.TabIndex = 6;
            // 
            // dtp_Mfg_Date
            // 
            this.dtp_Mfg_Date.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Mfg_Date.Location = new System.Drawing.Point(1387, 376);
            this.dtp_Mfg_Date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_Mfg_Date.Name = "dtp_Mfg_Date";
            this.dtp_Mfg_Date.Size = new System.Drawing.Size(382, 42);
            this.dtp_Mfg_Date.TabIndex = 5;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(1515, 103);
            this.dtp_Date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(265, 42);
            this.dtp_Date.TabIndex = 37;
            // 
            // tb_New_Stock
            // 
            this.tb_New_Stock.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_New_Stock.Location = new System.Drawing.Point(1387, 289);
            this.tb_New_Stock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_New_Stock.Name = "tb_New_Stock";
            this.tb_New_Stock.Size = new System.Drawing.Size(382, 42);
            this.tb_New_Stock.TabIndex = 4;
            this.tb_New_Stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Current_Stock
            // 
            this.tb_Current_Stock.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Current_Stock.Location = new System.Drawing.Point(1387, 203);
            this.tb_Current_Stock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Current_Stock.Name = "tb_Current_Stock";
            this.tb_Current_Stock.Size = new System.Drawing.Size(382, 42);
            this.tb_Current_Stock.TabIndex = 3;
            this.tb_Current_Stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Name.Location = new System.Drawing.Point(418, 483);
            this.tb_Product_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(382, 42);
            this.tb_Product_Name.TabIndex = 2;
            this.tb_Product_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.Enabled = false;
            this.tb_Product_ID.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_ID.Location = new System.Drawing.Point(418, 210);
            this.tb_Product_ID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(382, 42);
            this.tb_Product_ID.TabIndex = 1;
            this.tb_Product_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.White;
            this.lbl_Date.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Date.Location = new System.Drawing.Point(1374, 103);
            this.lbl_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(104, 45);
            this.lbl_Date.TabIndex = 35;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_Expiry_Date
            // 
            this.lbl_Expiry_Date.AutoSize = true;
            this.lbl_Expiry_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Expiry_Date.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expiry_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Expiry_Date.Location = new System.Drawing.Point(1022, 461);
            this.lbl_Expiry_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Expiry_Date.Name = "lbl_Expiry_Date";
            this.lbl_Expiry_Date.Size = new System.Drawing.Size(281, 53);
            this.lbl_Expiry_Date.TabIndex = 34;
            this.lbl_Expiry_Date.Text = "Expiry Date";
            // 
            // lbl_Mfg_Date
            // 
            this.lbl_Mfg_Date.AutoSize = true;
            this.lbl_Mfg_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mfg_Date.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mfg_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Mfg_Date.Location = new System.Drawing.Point(1022, 365);
            this.lbl_Mfg_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Mfg_Date.Name = "lbl_Mfg_Date";
            this.lbl_Mfg_Date.Size = new System.Drawing.Size(221, 53);
            this.lbl_Mfg_Date.TabIndex = 33;
            this.lbl_Mfg_Date.Text = "Mfg Date";
            // 
            // lbl_New_Stock
            // 
            this.lbl_New_Stock.AutoSize = true;
            this.lbl_New_Stock.BackColor = System.Drawing.Color.Transparent;
            this.lbl_New_Stock.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_New_Stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_New_Stock.Location = new System.Drawing.Point(1022, 277);
            this.lbl_New_Stock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_New_Stock.Name = "lbl_New_Stock";
            this.lbl_New_Stock.Size = new System.Drawing.Size(241, 53);
            this.lbl_New_Stock.TabIndex = 32;
            this.lbl_New_Stock.Text = "New Stock";
            // 
            // lbl_Current_Stock
            // 
            this.lbl_Current_Stock.AutoSize = true;
            this.lbl_Current_Stock.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Current_Stock.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Current_Stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Current_Stock.Location = new System.Drawing.Point(1017, 203);
            this.lbl_Current_Stock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Current_Stock.Name = "lbl_Current_Stock";
            this.lbl_Current_Stock.Size = new System.Drawing.Size(310, 53);
            this.lbl_Current_Stock.TabIndex = 31;
            this.lbl_Current_Stock.Text = "Current Stock";
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Product_Name.Location = new System.Drawing.Point(24, 480);
            this.lbl_Product_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(324, 53);
            this.lbl_Product_Name.TabIndex = 28;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // lbl_Product_ID
            // 
            this.lbl_Product_ID.AutoSize = true;
            this.lbl_Product_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Product_ID.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Product_ID.Location = new System.Drawing.Point(16, 211);
            this.lbl_Product_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Product_ID.Name = "lbl_Product_ID";
            this.lbl_Product_ID.Size = new System.Drawing.Size(276, 53);
            this.lbl_Product_ID.TabIndex = 26;
            this.lbl_Product_ID.Text = " Product ID";
            // 
            // lbl_Add_Stock
            // 
            this.lbl_Add_Stock.AutoSize = true;
            this.lbl_Add_Stock.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Add_Stock.Font = new System.Drawing.Font("Modern No. 20", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Stock.ForeColor = System.Drawing.Color.White;
            this.lbl_Add_Stock.Location = new System.Drawing.Point(678, 21);
            this.lbl_Add_Stock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Add_Stock.Name = "lbl_Add_Stock";
            this.lbl_Add_Stock.Size = new System.Drawing.Size(301, 69);
            this.lbl_Add_Stock.TabIndex = 24;
            this.lbl_Add_Stock.Text = "Add Stock";
            // 
            // pnl_Add_Stock
            // 
            this.pnl_Add_Stock.BackColor = System.Drawing.Color.Purple;
            this.pnl_Add_Stock.Controls.Add(this.lbl_Add_Stock);
            this.pnl_Add_Stock.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Add_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pnl_Add_Stock.Location = new System.Drawing.Point(0, 0);
            this.pnl_Add_Stock.Name = "pnl_Add_Stock";
            this.pnl_Add_Stock.Size = new System.Drawing.Size(1894, 100);
            this.pnl_Add_Stock.TabIndex = 38;
            // 
            // lbl_Product_Category
            // 
            this.lbl_Product_Category.AutoSize = true;
            this.lbl_Product_Category.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Product_Category.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Product_Category.Location = new System.Drawing.Point(17, 342);
            this.lbl_Product_Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Product_Category.Name = "lbl_Product_Category";
            this.lbl_Product_Category.Size = new System.Drawing.Size(381, 53);
            this.lbl_Product_Category.TabIndex = 39;
            this.lbl_Product_Category.Text = "Product Category";
            // 
            // cmb_Product_Category
            // 
            this.cmb_Product_Category.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Category.FormattingEnabled = true;
            this.cmb_Product_Category.Location = new System.Drawing.Point(418, 350);
            this.cmb_Product_Category.Name = "cmb_Product_Category";
            this.cmb_Product_Category.Size = new System.Drawing.Size(382, 45);
            this.cmb_Product_Category.TabIndex = 1;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(835, 202);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(155, 61);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // frm_Add_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1894, 1040);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.cmb_Product_Category);
            this.Controls.Add(this.lbl_Product_Category);
            this.Controls.Add(this.pnl_Add_Stock);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dtp_Expiry_Date);
            this.Controls.Add(this.dtp_Mfg_Date);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.tb_New_Stock);
            this.Controls.Add(this.tb_Current_Stock);
            this.Controls.Add(this.tb_Product_Name);
            this.Controls.Add(this.tb_Product_ID);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Expiry_Date);
            this.Controls.Add(this.lbl_Mfg_Date);
            this.Controls.Add(this.lbl_New_Stock);
            this.Controls.Add(this.lbl_Current_Stock);
            this.Controls.Add(this.lbl_Product_Name);
            this.Controls.Add(this.lbl_Product_ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_Stock_Load);
            this.pnl_Add_Stock.ResumeLayout(false);
            this.pnl_Add_Stock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DateTimePicker dtp_Expiry_Date;
        private System.Windows.Forms.DateTimePicker dtp_Mfg_Date;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.TextBox tb_New_Stock;
        private System.Windows.Forms.TextBox tb_Current_Stock;
        private System.Windows.Forms.TextBox tb_Product_Name;
        private System.Windows.Forms.TextBox tb_Product_ID;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Expiry_Date;
        private System.Windows.Forms.Label lbl_Mfg_Date;
        private System.Windows.Forms.Label lbl_New_Stock;
        private System.Windows.Forms.Label lbl_Current_Stock;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_Product_ID;
        private System.Windows.Forms.Label lbl_Add_Stock;
        private System.Windows.Forms.Panel pnl_Add_Stock;
        private System.Windows.Forms.Label lbl_Product_Category;
        private System.Windows.Forms.ComboBox cmb_Product_Category;
        private System.Windows.Forms.Button btn_Search;
    }
}