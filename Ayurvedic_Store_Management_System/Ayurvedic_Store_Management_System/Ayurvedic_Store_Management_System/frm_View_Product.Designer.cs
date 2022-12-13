namespace Ayurvedic_Store_Management_System
{
    partial class frm_View_Product
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
            this.lbl_View_Product = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.productDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ayurvedic_Store_Management_System_DBDataSet = new Ayurvedic_Store_Management_System.Ayurvedic_Store_Management_System_DBDataSet();
            this.product_DetailsTableAdapter = new Ayurvedic_Store_Management_System.Ayurvedic_Store_Management_System_DBDataSetTableAdapters.Product_DetailsTableAdapter();
            this.dgv_Product_Details = new System.Windows.Forms.DataGridView();
            this.pnl_View_Product = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayurvedic_Store_Management_System_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_Details)).BeginInit();
            this.pnl_View_Product.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_View_Product
            // 
            this.lbl_View_Product.AutoSize = true;
            this.lbl_View_Product.BackColor = System.Drawing.Color.Transparent;
            this.lbl_View_Product.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Product.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_View_Product.Location = new System.Drawing.Point(642, 20);
            this.lbl_View_Product.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_View_Product.Name = "lbl_View_Product";
            this.lbl_View_Product.Size = new System.Drawing.Size(371, 62);
            this.lbl_View_Product.TabIndex = 0;
            this.lbl_View_Product.Text = "View Product";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Category.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Category.Location = new System.Drawing.Point(337, 179);
            this.lbl_Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(201, 53);
            this.lbl_Category.TabIndex = 1;
            this.lbl_Category.Text = "Category";
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Product_Name.Location = new System.Drawing.Point(337, 287);
            this.lbl_Product_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(324, 53);
            this.lbl_Product_Name.TabIndex = 2;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // cmb_Category
            // 
            this.cmb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(735, 179);
            this.cmb_Category.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(445, 42);
            this.cmb_Category.TabIndex = 1;
            this.cmb_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_selectedIndex_Changed);
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product_Name.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(735, 287);
            this.cmb_Product_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(445, 42);
            this.cmb_Product_Name.TabIndex = 2;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Refresh.Location = new System.Drawing.Point(748, 787);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(265, 69);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // productDetailsBindingSource
            // 
            this.productDetailsBindingSource.DataMember = "Product_Details";
            this.productDetailsBindingSource.DataSource = this.ayurvedic_Store_Management_System_DBDataSet;
            // 
            // ayurvedic_Store_Management_System_DBDataSet
            // 
            this.ayurvedic_Store_Management_System_DBDataSet.DataSetName = "Ayurvedic_Store_Management_System_DBDataSet";
            this.ayurvedic_Store_Management_System_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // product_DetailsTableAdapter
            // 
            this.product_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // dgv_Product_Details
            // 
            this.dgv_Product_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product_Details.Location = new System.Drawing.Point(157, 402);
            this.dgv_Product_Details.Name = "dgv_Product_Details";
            this.dgv_Product_Details.RowTemplate.Height = 28;
            this.dgv_Product_Details.Size = new System.Drawing.Size(1479, 368);
            this.dgv_Product_Details.TabIndex = 7;
            // 
            // pnl_View_Product
            // 
            this.pnl_View_Product.BackColor = System.Drawing.Color.Purple;
            this.pnl_View_Product.Controls.Add(this.lbl_View_Product);
            this.pnl_View_Product.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_View_Product.Location = new System.Drawing.Point(0, 0);
            this.pnl_View_Product.Name = "pnl_View_Product";
            this.pnl_View_Product.Size = new System.Drawing.Size(1778, 99);
            this.pnl_View_Product.TabIndex = 8;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Search.Location = new System.Drawing.Point(1252, 212);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(265, 69);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Text = "Search ";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // frm_View_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1778, 894);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.pnl_View_Product);
            this.Controls.Add(this.dgv_Product_Details);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.cmb_Product_Name);
            this.Controls.Add(this.cmb_Category);
            this.Controls.Add(this.lbl_Product_Name);
            this.Controls.Add(this.lbl_Category);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm View Product";
            this.Load += new System.EventHandler(this.frm_View_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayurvedic_Store_Management_System_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_Details)).EndInit();
            this.pnl_View_Product.ResumeLayout(false);
            this.pnl_View_Product.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_Product;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.ComboBox cmb_Product_Name;
        private System.Windows.Forms.Button btn_Refresh;
        private Ayurvedic_Store_Management_System_DBDataSet ayurvedic_Store_Management_System_DBDataSet;
        private System.Windows.Forms.BindingSource productDetailsBindingSource;
        private Ayurvedic_Store_Management_System_DBDataSetTableAdapters.Product_DetailsTableAdapter product_DetailsTableAdapter;
        private System.Windows.Forms.DataGridView dgv_Product_Details;
        private System.Windows.Forms.Panel pnl_View_Product;
        private System.Windows.Forms.Button btn_Search;
    }
}