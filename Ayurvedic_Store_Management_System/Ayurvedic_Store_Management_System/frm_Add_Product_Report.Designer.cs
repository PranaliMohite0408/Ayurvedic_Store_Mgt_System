namespace Ayurvedic_Store_Management_System
{
    partial class frm_Add_Product_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_Product_Report));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Product_Report = new System.Windows.Forms.Label();
            this.rpt_Product_Report_Viewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1142, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(532, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Product_Report
            // 
            this.lbl_Product_Report.AutoSize = true;
            this.lbl_Product_Report.Font = new System.Drawing.Font("Modern No. 20", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Report.ForeColor = System.Drawing.Color.SlateBlue;
            this.lbl_Product_Report.Location = new System.Drawing.Point(701, 32);
            this.lbl_Product_Report.Name = "lbl_Product_Report";
            this.lbl_Product_Report.Size = new System.Drawing.Size(370, 58);
            this.lbl_Product_Report.TabIndex = 13;
            this.lbl_Product_Report.Text = "Product Report";
            // 
            // rpt_Product_Report_Viewer
            // 
            this.rpt_Product_Report_Viewer.ActiveViewIndex = -1;
            this.rpt_Product_Report_Viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpt_Product_Report_Viewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpt_Product_Report_Viewer.Location = new System.Drawing.Point(39, 150);
            this.rpt_Product_Report_Viewer.Name = "rpt_Product_Report_Viewer";
            this.rpt_Product_Report_Viewer.Size = new System.Drawing.Size(1718, 796);
            this.rpt_Product_Report_Viewer.TabIndex = 19;
            // 
            // frm_Add_Product_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1878, 1024);
            this.Controls.Add(this.rpt_Product_Report_Viewer);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Product_Report);
            this.Name = "frm_Add_Product_Report";
            this.Text = "frm_Add_Product_Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_Product_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Product_Report;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpt_Product_Report_Viewer;
    }
}