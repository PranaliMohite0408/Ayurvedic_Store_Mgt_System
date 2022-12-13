namespace Ayurvedic_Store_Management_System
{
    partial class frm_View_Customer
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
            this.lbl_View_All_Customer = new System.Windows.Forms.Label();
            this.ayurvedic_Store_Management_System_DBDataSet1 = new Ayurvedic_Store_Management_System.Ayurvedic_Store_Management_System_DBDataSet1();
            this.customerBillDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customer_Bill_DetailsTableAdapter = new Ayurvedic_Store_Management_System.Ayurvedic_Store_Management_System_DBDataSet1TableAdapters.Customer_Bill_DetailsTableAdapter();
            this.ayurvedic_Store_Management_System_DBDataSet2 = new Ayurvedic_Store_Management_System.Ayurvedic_Store_Management_System_DBDataSet2();
            this.customerBillDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customer_Bill_DetailsTableAdapter1 = new Ayurvedic_Store_Management_System.Ayurvedic_Store_Management_System_DBDataSet2TableAdapters.Customer_Bill_DetailsTableAdapter();
            this.dgv_Customer_Details = new System.Windows.Forms.DataGridView();
            this.pnl_View_Custmor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ayurvedic_Store_Management_System_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBillDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayurvedic_Store_Management_System_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBillDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer_Details)).BeginInit();
            this.pnl_View_Custmor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_View_All_Customer
            // 
            this.lbl_View_All_Customer.AutoSize = true;
            this.lbl_View_All_Customer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_View_All_Customer.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_All_Customer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_View_All_Customer.Location = new System.Drawing.Point(604, 13);
            this.lbl_View_All_Customer.Name = "lbl_View_All_Customer";
            this.lbl_View_All_Customer.Size = new System.Drawing.Size(460, 62);
            this.lbl_View_All_Customer.TabIndex = 0;
            this.lbl_View_All_Customer.Text = "View All Custmor";
            // 
            // ayurvedic_Store_Management_System_DBDataSet1
            // 
            this.ayurvedic_Store_Management_System_DBDataSet1.DataSetName = "Ayurvedic_Store_Management_System_DBDataSet1";
            this.ayurvedic_Store_Management_System_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBillDetailsBindingSource
            // 
            this.customerBillDetailsBindingSource.DataMember = "Customer_Bill_Details";
            this.customerBillDetailsBindingSource.DataSource = this.ayurvedic_Store_Management_System_DBDataSet1;
            // 
            // customer_Bill_DetailsTableAdapter
            // 
            this.customer_Bill_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // ayurvedic_Store_Management_System_DBDataSet2
            // 
            this.ayurvedic_Store_Management_System_DBDataSet2.DataSetName = "Ayurvedic_Store_Management_System_DBDataSet2";
            this.ayurvedic_Store_Management_System_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBillDetailsBindingSource1
            // 
            this.customerBillDetailsBindingSource1.DataMember = "Customer_Bill_Details";
            this.customerBillDetailsBindingSource1.DataSource = this.ayurvedic_Store_Management_System_DBDataSet2;
            // 
            // customer_Bill_DetailsTableAdapter1
            // 
            this.customer_Bill_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // dgv_Customer_Details
            // 
            this.dgv_Customer_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customer_Details.Location = new System.Drawing.Point(61, 177);
            this.dgv_Customer_Details.Name = "dgv_Customer_Details";
            this.dgv_Customer_Details.RowTemplate.Height = 28;
            this.dgv_Customer_Details.Size = new System.Drawing.Size(1659, 617);
            this.dgv_Customer_Details.TabIndex = 3;
            // 
            // pnl_View_Custmor
            // 
            this.pnl_View_Custmor.BackColor = System.Drawing.Color.Purple;
            this.pnl_View_Custmor.Controls.Add(this.lbl_View_All_Customer);
            this.pnl_View_Custmor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_View_Custmor.Location = new System.Drawing.Point(0, 0);
            this.pnl_View_Custmor.Name = "pnl_View_Custmor";
            this.pnl_View_Custmor.Size = new System.Drawing.Size(1878, 100);
            this.pnl_View_Custmor.TabIndex = 4;
            // 
            // frm_View_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1878, 944);
            this.Controls.Add(this.pnl_View_Custmor);
            this.Controls.Add(this.dgv_Customer_Details);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Customer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_View_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ayurvedic_Store_Management_System_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBillDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayurvedic_Store_Management_System_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBillDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer_Details)).EndInit();
            this.pnl_View_Custmor.ResumeLayout(false);
            this.pnl_View_Custmor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_All_Customer;
        private Ayurvedic_Store_Management_System_DBDataSet1 ayurvedic_Store_Management_System_DBDataSet1;
        private System.Windows.Forms.BindingSource customerBillDetailsBindingSource;
        private Ayurvedic_Store_Management_System_DBDataSet1TableAdapters.Customer_Bill_DetailsTableAdapter customer_Bill_DetailsTableAdapter;
        private Ayurvedic_Store_Management_System_DBDataSet2 ayurvedic_Store_Management_System_DBDataSet2;
        private System.Windows.Forms.BindingSource customerBillDetailsBindingSource1;
        private Ayurvedic_Store_Management_System_DBDataSet2TableAdapters.Customer_Bill_DetailsTableAdapter customer_Bill_DetailsTableAdapter1;
        private System.Windows.Forms.DataGridView dgv_Customer_Details;
        private System.Windows.Forms.Panel pnl_View_Custmor;
    }
}