namespace Ayurvedic_Store_Management_System
{
    partial class Add_New_Customer
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
            this.lbl_Add_New_Customer = new System.Windows.Forms.Label();
            this.gb_Customer_Details = new System.Windows.Forms.GroupBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Mobile_Number = new System.Windows.Forms.TextBox();
            this.tb_Customer_Name = new System.Windows.Forms.TextBox();
            this.tb_Customer_ID = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_Number = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Customer_Name = new System.Windows.Forms.Label();
            this.lbl_Customer_ID = new System.Windows.Forms.Label();
            this.pnl_Heading = new System.Windows.Forms.Panel();
            this.gb_Purchase_Details = new System.Windows.Forms.GroupBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tb_Total_Price = new System.Windows.Forms.TextBox();
            this.dgv_Purchase_Details = new System.Windows.Forms.DataGridView();
            this.lbl_Total_Price = new System.Windows.Forms.Label();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.cmb_Category_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.gb_Bill_Details = new System.Windows.Forms.GroupBox();
            this.lbl_Bill = new System.Windows.Forms.Label();
            this.lbl_GST = new System.Windows.Forms.Label();
            this.lbl_Final_Bill = new System.Windows.Forms.Label();
            this.tb_Bill = new System.Windows.Forms.TextBox();
            this.lbl_Per = new System.Windows.Forms.Label();
            this.tb_GST = new System.Windows.Forms.TextBox();
            this.tb_Final_Bill = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gb_Customer_Details.SuspendLayout();
            this.pnl_Heading.SuspendLayout();
            this.gb_Purchase_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Purchase_Details)).BeginInit();
            this.gb_Bill_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Add_New_Customer
            // 
            this.lbl_Add_New_Customer.AutoSize = true;
            this.lbl_Add_New_Customer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Add_New_Customer.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Customer.ForeColor = System.Drawing.Color.White;
            this.lbl_Add_New_Customer.Location = new System.Drawing.Point(553, 9);
            this.lbl_Add_New_Customer.Name = "lbl_Add_New_Customer";
            this.lbl_Add_New_Customer.Size = new System.Drawing.Size(598, 75);
            this.lbl_Add_New_Customer.TabIndex = 33;
            this.lbl_Add_New_Customer.Text = "Add New Customer";
            // 
            // gb_Customer_Details
            // 
            this.gb_Customer_Details.Controls.Add(this.dtp_Date);
            this.gb_Customer_Details.Controls.Add(this.tb_Mobile_Number);
            this.gb_Customer_Details.Controls.Add(this.tb_Customer_Name);
            this.gb_Customer_Details.Controls.Add(this.tb_Customer_ID);
            this.gb_Customer_Details.Controls.Add(this.lbl_Mobile_Number);
            this.gb_Customer_Details.Controls.Add(this.lbl_Date);
            this.gb_Customer_Details.Controls.Add(this.lbl_Customer_Name);
            this.gb_Customer_Details.Controls.Add(this.lbl_Customer_ID);
            this.gb_Customer_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Customer_Details.Location = new System.Drawing.Point(30, 126);
            this.gb_Customer_Details.Name = "gb_Customer_Details";
            this.gb_Customer_Details.Size = new System.Drawing.Size(1796, 227);
            this.gb_Customer_Details.TabIndex = 34;
            this.gb_Customer_Details.TabStop = false;
            this.gb_Customer_Details.Text = "Customer Details";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(1343, 51);
            this.dtp_Date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(291, 46);
            this.dtp_Date.TabIndex = 34;
            // 
            // tb_Mobile_Number
            // 
            this.tb_Mobile_Number.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_Number.Location = new System.Drawing.Point(1324, 135);
            this.tb_Mobile_Number.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Mobile_Number.Name = "tb_Mobile_Number";
            this.tb_Mobile_Number.Size = new System.Drawing.Size(355, 46);
            this.tb_Mobile_Number.TabIndex = 35;
            this.tb_Mobile_Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Customer_Name
            // 
            this.tb_Customer_Name.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_Name.Location = new System.Drawing.Point(338, 146);
            this.tb_Customer_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Customer_Name.Name = "tb_Customer_Name";
            this.tb_Customer_Name.Size = new System.Drawing.Size(582, 46);
            this.tb_Customer_Name.TabIndex = 33;
            this.tb_Customer_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // tb_Customer_ID
            // 
            this.tb_Customer_ID.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_ID.Location = new System.Drawing.Point(338, 66);
            this.tb_Customer_ID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Customer_ID.Name = "tb_Customer_ID";
            this.tb_Customer_ID.Size = new System.Drawing.Size(296, 46);
            this.tb_Customer_ID.TabIndex = 32;
            this.tb_Customer_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Mobile_Number
            // 
            this.lbl_Mobile_Number.AutoSize = true;
            this.lbl_Mobile_Number.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mobile_Number.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_Number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Mobile_Number.Location = new System.Drawing.Point(981, 142);
            this.lbl_Mobile_Number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Mobile_Number.Name = "lbl_Mobile_Number";
            this.lbl_Mobile_Number.Size = new System.Drawing.Size(243, 37);
            this.lbl_Mobile_Number.TabIndex = 39;
            this.lbl_Mobile_Number.Text = "Mobile Number";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Date.Location = new System.Drawing.Point(1001, 51);
            this.lbl_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(85, 37);
            this.lbl_Date.TabIndex = 38;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_Customer_Name
            // 
            this.lbl_Customer_Name.AutoSize = true;
            this.lbl_Customer_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Customer_Name.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Customer_Name.Location = new System.Drawing.Point(83, 149);
            this.lbl_Customer_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Customer_Name.Name = "lbl_Customer_Name";
            this.lbl_Customer_Name.Size = new System.Drawing.Size(243, 37);
            this.lbl_Customer_Name.TabIndex = 37;
            this.lbl_Customer_Name.Text = "Customer Name";
            // 
            // lbl_Customer_ID
            // 
            this.lbl_Customer_ID.AutoSize = true;
            this.lbl_Customer_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Customer_ID.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Customer_ID.Location = new System.Drawing.Point(83, 69);
            this.lbl_Customer_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Customer_ID.Name = "lbl_Customer_ID";
            this.lbl_Customer_ID.Size = new System.Drawing.Size(201, 37);
            this.lbl_Customer_ID.TabIndex = 36;
            this.lbl_Customer_ID.Text = "Customer ID";
            // 
            // pnl_Heading
            // 
            this.pnl_Heading.BackColor = System.Drawing.Color.Purple;
            this.pnl_Heading.Controls.Add(this.lbl_Add_New_Customer);
            this.pnl_Heading.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Heading.Location = new System.Drawing.Point(0, 0);
            this.pnl_Heading.Name = "pnl_Heading";
            this.pnl_Heading.Size = new System.Drawing.Size(1878, 100);
            this.pnl_Heading.TabIndex = 35;
            // 
            // gb_Purchase_Details
            // 
            this.gb_Purchase_Details.Controls.Add(this.btn_Add);
            this.gb_Purchase_Details.Controls.Add(this.tb_Total_Price);
            this.gb_Purchase_Details.Controls.Add(this.dgv_Purchase_Details);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Total_Price);
            this.gb_Purchase_Details.Controls.Add(this.tb_Quantity);
            this.gb_Purchase_Details.Controls.Add(this.tb_Price);
            this.gb_Purchase_Details.Controls.Add(this.cmb_Product_Name);
            this.gb_Purchase_Details.Controls.Add(this.cmb_Category_Name);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Quantity);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Price);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Product_Name);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Category_Name);
            this.gb_Purchase_Details.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Purchase_Details.Location = new System.Drawing.Point(30, 378);
            this.gb_Purchase_Details.Name = "gb_Purchase_Details";
            this.gb_Purchase_Details.Size = new System.Drawing.Size(1796, 332);
            this.gb_Purchase_Details.TabIndex = 36;
            this.gb_Purchase_Details.TabStop = false;
            this.gb_Purchase_Details.Text = "Purchase Details";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Add.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(1570, 35);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(163, 58);
            this.btn_Add.TabIndex = 35;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tb_Total_Price
            // 
            this.tb_Total_Price.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Price.Location = new System.Drawing.Point(1268, 83);
            this.tb_Total_Price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Total_Price.Name = "tb_Total_Price";
            this.tb_Total_Price.Size = new System.Drawing.Size(201, 44);
            this.tb_Total_Price.TabIndex = 34;
            this.tb_Total_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Is_Price);
            // 
            // dgv_Purchase_Details
            // 
            this.dgv_Purchase_Details.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_Purchase_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Purchase_Details.Location = new System.Drawing.Point(50, 137);
            this.dgv_Purchase_Details.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_Purchase_Details.Name = "dgv_Purchase_Details";
            this.dgv_Purchase_Details.Size = new System.Drawing.Size(1648, 169);
            this.dgv_Purchase_Details.TabIndex = 36;
            // 
            // lbl_Total_Price
            // 
            this.lbl_Total_Price.AutoSize = true;
            this.lbl_Total_Price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Total_Price.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Total_Price.Location = new System.Drawing.Point(1286, 29);
            this.lbl_Total_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Total_Price.Name = "lbl_Total_Price";
            this.lbl_Total_Price.Size = new System.Drawing.Size(180, 37);
            this.lbl_Total_Price.TabIndex = 41;
            this.lbl_Total_Price.Text = "Total Price";
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantity.Location = new System.Drawing.Point(716, 83);
            this.tb_Quantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(255, 44);
            this.tb_Quantity.TabIndex = 32;
            this.tb_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Price
            // 
            this.tb_Price.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(1025, 83);
            this.tb_Price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(182, 44);
            this.tb_Price.TabIndex = 33;
            this.tb_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Is_Price);
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(374, 82);
            this.cmb_Product_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(302, 45);
            this.cmb_Product_Name.TabIndex = 31;
            // 
            // cmb_Category_Name
            // 
            this.cmb_Category_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category_Name.FormattingEnabled = true;
            this.cmb_Category_Name.Location = new System.Drawing.Point(50, 82);
            this.cmb_Category_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_Category_Name.Name = "cmb_Category_Name";
            this.cmb_Category_Name.Size = new System.Drawing.Size(274, 45);
            this.cmb_Category_Name.TabIndex = 30;
            this.cmb_Category_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_Selected);
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Quantity.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Quantity.Location = new System.Drawing.Point(764, 29);
            this.lbl_Quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(145, 37);
            this.lbl_Quantity.TabIndex = 40;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Price.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Price.Location = new System.Drawing.Point(1062, 29);
            this.lbl_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(94, 37);
            this.lbl_Price.TabIndex = 39;
            this.lbl_Price.Text = "Price";
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Product_Name.Location = new System.Drawing.Point(406, 29);
            this.lbl_Product_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(224, 37);
            this.lbl_Product_Name.TabIndex = 38;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Category_Name.Location = new System.Drawing.Point(72, 35);
            this.lbl_Category_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(233, 37);
            this.lbl_Category_Name.TabIndex = 37;
            this.lbl_Category_Name.Text = "Category Name";
            // 
            // gb_Bill_Details
            // 
            this.gb_Bill_Details.Controls.Add(this.lbl_Bill);
            this.gb_Bill_Details.Controls.Add(this.lbl_GST);
            this.gb_Bill_Details.Controls.Add(this.lbl_Final_Bill);
            this.gb_Bill_Details.Controls.Add(this.tb_Bill);
            this.gb_Bill_Details.Controls.Add(this.lbl_Per);
            this.gb_Bill_Details.Controls.Add(this.tb_GST);
            this.gb_Bill_Details.Controls.Add(this.tb_Final_Bill);
            this.gb_Bill_Details.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Bill_Details.Location = new System.Drawing.Point(30, 738);
            this.gb_Bill_Details.Name = "gb_Bill_Details";
            this.gb_Bill_Details.Size = new System.Drawing.Size(1796, 117);
            this.gb_Bill_Details.TabIndex = 37;
            this.gb_Bill_Details.TabStop = false;
            this.gb_Bill_Details.Text = "Bill Details";
            // 
            // lbl_Bill
            // 
            this.lbl_Bill.AutoSize = true;
            this.lbl_Bill.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Bill.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Bill.Location = new System.Drawing.Point(61, 45);
            this.lbl_Bill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Bill.Name = "lbl_Bill";
            this.lbl_Bill.Size = new System.Drawing.Size(77, 37);
            this.lbl_Bill.TabIndex = 28;
            this.lbl_Bill.Text = "Bill";
            // 
            // lbl_GST
            // 
            this.lbl_GST.AutoSize = true;
            this.lbl_GST.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GST.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GST.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_GST.Location = new System.Drawing.Point(598, 42);
            this.lbl_GST.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_GST.Name = "lbl_GST";
            this.lbl_GST.Size = new System.Drawing.Size(82, 37);
            this.lbl_GST.TabIndex = 30;
            this.lbl_GST.Text = "GST";
            // 
            // lbl_Final_Bill
            // 
            this.lbl_Final_Bill.AutoSize = true;
            this.lbl_Final_Bill.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Final_Bill.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Final_Bill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Final_Bill.Location = new System.Drawing.Point(1141, 51);
            this.lbl_Final_Bill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Final_Bill.Name = "lbl_Final_Bill";
            this.lbl_Final_Bill.Size = new System.Drawing.Size(167, 37);
            this.lbl_Final_Bill.TabIndex = 33;
            this.lbl_Final_Bill.Text = "Final Bill";
            // 
            // tb_Bill
            // 
            this.tb_Bill.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Bill.Location = new System.Drawing.Point(252, 42);
            this.tb_Bill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Bill.Name = "tb_Bill";
            this.tb_Bill.Size = new System.Drawing.Size(223, 46);
            this.tb_Bill.TabIndex = 29;
            this.tb_Bill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Is_Price);
            // 
            // lbl_Per
            // 
            this.lbl_Per.AutoSize = true;
            this.lbl_Per.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Per.ForeColor = System.Drawing.Color.Black;
            this.lbl_Per.Location = new System.Drawing.Point(949, 45);
            this.lbl_Per.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Per.Name = "lbl_Per";
            this.lbl_Per.Size = new System.Drawing.Size(33, 37);
            this.lbl_Per.TabIndex = 34;
            this.lbl_Per.Text = "%";
            // 
            // tb_GST
            // 
            this.tb_GST.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GST.Location = new System.Drawing.Point(782, 42);
            this.tb_GST.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_GST.Name = "tb_GST";
            this.tb_GST.Size = new System.Drawing.Size(159, 46);
            this.tb_GST.TabIndex = 31;
            this.tb_GST.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Final_Bill
            // 
            this.tb_Final_Bill.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Final_Bill.Location = new System.Drawing.Point(1395, 42);
            this.tb_Final_Bill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Final_Bill.Name = "tb_Final_Bill";
            this.tb_Final_Bill.Size = new System.Drawing.Size(263, 46);
            this.tb_Final_Bill.TabIndex = 32;
            this.tb_Final_Bill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Is_Price);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(938, 875);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(182, 64);
            this.btn_Refresh.TabIndex = 39;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(512, 875);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(218, 64);
            this.btn_Save.TabIndex = 38;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Add_New_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1878, 1024);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.gb_Bill_Details);
            this.Controls.Add(this.gb_Purchase_Details);
            this.Controls.Add(this.pnl_Heading);
            this.Controls.Add(this.gb_Customer_Details);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_New_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Customer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Add_New_Customer_Load);
            this.gb_Customer_Details.ResumeLayout(false);
            this.gb_Customer_Details.PerformLayout();
            this.pnl_Heading.ResumeLayout(false);
            this.pnl_Heading.PerformLayout();
            this.gb_Purchase_Details.ResumeLayout(false);
            this.gb_Purchase_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Purchase_Details)).EndInit();
            this.gb_Bill_Details.ResumeLayout(false);
            this.gb_Bill_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_New_Customer;
        private System.Windows.Forms.GroupBox gb_Customer_Details;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.TextBox tb_Mobile_Number;
        private System.Windows.Forms.TextBox tb_Customer_Name;
        private System.Windows.Forms.TextBox tb_Customer_ID;
        private System.Windows.Forms.Label lbl_Mobile_Number;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Customer_Name;
        private System.Windows.Forms.Label lbl_Customer_ID;
        private System.Windows.Forms.Panel pnl_Heading;
        private System.Windows.Forms.GroupBox gb_Purchase_Details;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox tb_Total_Price;
        private System.Windows.Forms.DataGridView dgv_Purchase_Details;
        private System.Windows.Forms.Label lbl_Total_Price;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.ComboBox cmb_Product_Name;
        private System.Windows.Forms.ComboBox cmb_Category_Name;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_Category_Name;
        private System.Windows.Forms.GroupBox gb_Bill_Details;
        private System.Windows.Forms.Label lbl_Bill;
        private System.Windows.Forms.Label lbl_GST;
        private System.Windows.Forms.Label lbl_Final_Bill;
        private System.Windows.Forms.TextBox tb_Bill;
        private System.Windows.Forms.Label lbl_Per;
        private System.Windows.Forms.TextBox tb_GST;
        private System.Windows.Forms.TextBox tb_Final_Bill;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
    }
}