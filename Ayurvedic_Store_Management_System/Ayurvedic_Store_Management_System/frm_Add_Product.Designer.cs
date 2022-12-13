namespace Ayurvedic_Store_Management_System
{
    partial class frm_Add_Product
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
            this.pnl_Add_Product = new System.Windows.Forms.Panel();
            this.lbl_Add_Product = new System.Windows.Forms.Label();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.dtp_Expiry_Date = new System.Windows.Forms.DateTimePicker();
            this.dtp_Mfg_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.tb_Sales_Price = new System.Windows.Forms.TextBox();
            this.tb_Stock = new System.Windows.Forms.TextBox();
            this.tb_Perchase_Price = new System.Windows.Forms.TextBox();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_Expiry_Date = new System.Windows.Forms.Label();
            this.lbl_Mfg_Date = new System.Windows.Forms.Label();
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.lbl_Sales_Price = new System.Windows.Forms.Label();
            this.lbl_Purchase_Price = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Product_ID = new System.Windows.Forms.Label();
            this.pnl_Add_Product.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Add_Product
            // 
            this.pnl_Add_Product.BackColor = System.Drawing.Color.Purple;
            this.pnl_Add_Product.Controls.Add(this.lbl_Add_Product);
            this.pnl_Add_Product.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Add_Product.Location = new System.Drawing.Point(0, 0);
            this.pnl_Add_Product.Name = "pnl_Add_Product";
            this.pnl_Add_Product.Size = new System.Drawing.Size(1878, 104);
            this.pnl_Add_Product.TabIndex = 43;
            // 
            // lbl_Add_Product
            // 
            this.lbl_Add_Product.AutoSize = true;
            this.lbl_Add_Product.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Add_Product.Font = new System.Drawing.Font("Modern No. 20", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Product.ForeColor = System.Drawing.Color.White;
            this.lbl_Add_Product.Location = new System.Drawing.Point(688, 13);
            this.lbl_Add_Product.Name = "lbl_Add_Product";
            this.lbl_Add_Product.Size = new System.Drawing.Size(377, 69);
            this.lbl_Add_Product.TabIndex = 23;
            this.lbl_Add_Product.Text = "Add Product";
            // 
            // cmb_Category
            // 
            this.cmb_Category.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(482, 323);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(421, 45);
            this.cmb_Category.TabIndex = 2;
            this.cmb_Category.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // dtp_Expiry_Date
            // 
            this.dtp_Expiry_Date.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Expiry_Date.Location = new System.Drawing.Point(1401, 406);
            this.dtp_Expiry_Date.Name = "dtp_Expiry_Date";
            this.dtp_Expiry_Date.Size = new System.Drawing.Size(403, 46);
            this.dtp_Expiry_Date.TabIndex = 8;
            // 
            // dtp_Mfg_Date
            // 
            this.dtp_Mfg_Date.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Mfg_Date.Location = new System.Drawing.Point(1404, 288);
            this.dtp_Mfg_Date.Name = "dtp_Mfg_Date";
            this.dtp_Mfg_Date.Size = new System.Drawing.Size(403, 46);
            this.dtp_Mfg_Date.TabIndex = 7;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(891, 822);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(228, 78);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Description
            // 
            this.tb_Description.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Description.Location = new System.Drawing.Point(1401, 525);
            this.tb_Description.MaxLength = 250;
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(403, 162);
            this.tb_Description.TabIndex = 10;
            this.tb_Description.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // tb_Sales_Price
            // 
            this.tb_Sales_Price.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sales_Price.Location = new System.Drawing.Point(482, 655);
            this.tb_Sales_Price.Name = "tb_Sales_Price";
            this.tb_Sales_Price.Size = new System.Drawing.Size(421, 46);
            this.tb_Sales_Price.TabIndex = 5;
            this.tb_Sales_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Is_Price);
            // 
            // tb_Stock
            // 
            this.tb_Stock.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stock.Location = new System.Drawing.Point(1401, 191);
            this.tb_Stock.Name = "tb_Stock";
            this.tb_Stock.Size = new System.Drawing.Size(403, 46);
            this.tb_Stock.TabIndex = 6;
            this.tb_Stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Perchase_Price
            // 
            this.tb_Perchase_Price.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Perchase_Price.Location = new System.Drawing.Point(482, 536);
            this.tb_Perchase_Price.Name = "tb_Perchase_Price";
            this.tb_Perchase_Price.Size = new System.Drawing.Size(421, 46);
            this.tb_Perchase_Price.TabIndex = 4;
            this.tb_Perchase_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Is_Price);
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Name.Location = new System.Drawing.Point(482, 432);
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(421, 46);
            this.tb_Product_Name.TabIndex = 3;
            this.tb_Product_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Alpha_Numeric);
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.Enabled = false;
            this.tb_Product_ID.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_ID.Location = new System.Drawing.Point(482, 201);
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(421, 46);
            this.tb_Product_ID.TabIndex = 1;
            this.tb_Product_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Description.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Description.Location = new System.Drawing.Point(1057, 529);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(267, 53);
            this.lbl_Description.TabIndex = 40;
            this.lbl_Description.Text = "Description";
            // 
            // lbl_Expiry_Date
            // 
            this.lbl_Expiry_Date.AutoSize = true;
            this.lbl_Expiry_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Expiry_Date.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expiry_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Expiry_Date.Location = new System.Drawing.Point(1057, 398);
            this.lbl_Expiry_Date.Name = "lbl_Expiry_Date";
            this.lbl_Expiry_Date.Size = new System.Drawing.Size(281, 53);
            this.lbl_Expiry_Date.TabIndex = 38;
            this.lbl_Expiry_Date.Text = "Expiry Date";
            // 
            // lbl_Mfg_Date
            // 
            this.lbl_Mfg_Date.AutoSize = true;
            this.lbl_Mfg_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mfg_Date.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mfg_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Mfg_Date.Location = new System.Drawing.Point(1060, 291);
            this.lbl_Mfg_Date.Name = "lbl_Mfg_Date";
            this.lbl_Mfg_Date.Size = new System.Drawing.Size(221, 53);
            this.lbl_Mfg_Date.TabIndex = 36;
            this.lbl_Mfg_Date.Text = "Mfg Date";
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.AutoSize = true;
            this.lbl_Stock.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Stock.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Stock.Location = new System.Drawing.Point(1073, 191);
            this.lbl_Stock.Name = "lbl_Stock";
            this.lbl_Stock.Size = new System.Drawing.Size(137, 53);
            this.lbl_Stock.TabIndex = 35;
            this.lbl_Stock.Text = "Stock";
            // 
            // lbl_Sales_Price
            // 
            this.lbl_Sales_Price.AutoSize = true;
            this.lbl_Sales_Price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Sales_Price.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sales_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Sales_Price.Location = new System.Drawing.Point(97, 655);
            this.lbl_Sales_Price.Name = "lbl_Sales_Price";
            this.lbl_Sales_Price.Size = new System.Drawing.Size(255, 53);
            this.lbl_Sales_Price.TabIndex = 32;
            this.lbl_Sales_Price.Text = "Sales Price";
            // 
            // lbl_Purchase_Price
            // 
            this.lbl_Purchase_Price.AutoSize = true;
            this.lbl_Purchase_Price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Purchase_Price.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Purchase_Price.Location = new System.Drawing.Point(88, 536);
            this.lbl_Purchase_Price.Name = "lbl_Purchase_Price";
            this.lbl_Purchase_Price.Size = new System.Drawing.Size(343, 53);
            this.lbl_Purchase_Price.TabIndex = 30;
            this.lbl_Purchase_Price.Text = "Purchase Price";
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Product_Name.Location = new System.Drawing.Point(91, 422);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(324, 53);
            this.lbl_Product_Name.TabIndex = 29;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Category.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Category.Location = new System.Drawing.Point(95, 304);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(201, 53);
            this.lbl_Category.TabIndex = 26;
            this.lbl_Category.Text = "Category";
            // 
            // lbl_Product_ID
            // 
            this.lbl_Product_ID.AutoSize = true;
            this.lbl_Product_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Product_ID.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Product_ID.Location = new System.Drawing.Point(95, 189);
            this.lbl_Product_ID.Name = "lbl_Product_ID";
            this.lbl_Product_ID.Size = new System.Drawing.Size(263, 53);
            this.lbl_Product_ID.TabIndex = 25;
            this.lbl_Product_ID.Text = "Product ID";
            // 
            // frm_Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1878, 1024);
            this.Controls.Add(this.pnl_Add_Product);
            this.Controls.Add(this.cmb_Category);
            this.Controls.Add(this.dtp_Expiry_Date);
            this.Controls.Add(this.dtp_Mfg_Date);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Description);
            this.Controls.Add(this.tb_Sales_Price);
            this.Controls.Add(this.tb_Stock);
            this.Controls.Add(this.tb_Perchase_Price);
            this.Controls.Add(this.tb_Product_Name);
            this.Controls.Add(this.tb_Product_ID);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.lbl_Expiry_Date);
            this.Controls.Add(this.lbl_Mfg_Date);
            this.Controls.Add(this.lbl_Stock);
            this.Controls.Add(this.lbl_Sales_Price);
            this.Controls.Add(this.lbl_Purchase_Price);
            this.Controls.Add(this.lbl_Product_Name);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.lbl_Product_ID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_Product";
            this.Text = "Add Product";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_Product_Load);
            this.pnl_Add_Product.ResumeLayout(false);
            this.pnl_Add_Product.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Add_Product;
        private System.Windows.Forms.Label lbl_Add_Product;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.DateTimePicker dtp_Expiry_Date;
        private System.Windows.Forms.DateTimePicker dtp_Mfg_Date;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Description;
        private System.Windows.Forms.TextBox tb_Sales_Price;
        private System.Windows.Forms.TextBox tb_Stock;
        private System.Windows.Forms.TextBox tb_Perchase_Price;
        private System.Windows.Forms.TextBox tb_Product_Name;
        private System.Windows.Forms.TextBox tb_Product_ID;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_Expiry_Date;
        private System.Windows.Forms.Label lbl_Mfg_Date;
        private System.Windows.Forms.Label lbl_Stock;
        private System.Windows.Forms.Label lbl_Sales_Price;
        private System.Windows.Forms.Label lbl_Purchase_Price;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Product_ID;
    }
}