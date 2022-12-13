namespace Ayurvedic_Store_Management_System
{
    partial class frm_Add_Customer_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_Customer_Report));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Customer_Report = new System.Windows.Forms.Label();
            this.rpt_Customer_Report_Viewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1130, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(602, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Customer_Report
            // 
            this.lbl_Customer_Report.AutoSize = true;
            this.lbl_Customer_Report.Font = new System.Drawing.Font("Modern No. 20", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Report.ForeColor = System.Drawing.Color.SlateBlue;
            this.lbl_Customer_Report.Location = new System.Drawing.Point(714, 28);
            this.lbl_Customer_Report.Name = "lbl_Customer_Report";
            this.lbl_Customer_Report.Size = new System.Drawing.Size(400, 58);
            this.lbl_Customer_Report.TabIndex = 22;
            this.lbl_Customer_Report.Text = "Customer Report";
            // 
            // rpt_Customer_Report_Viewer
            // 
            this.rpt_Customer_Report_Viewer.ActiveViewIndex = -1;
            this.rpt_Customer_Report_Viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpt_Customer_Report_Viewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpt_Customer_Report_Viewer.Location = new System.Drawing.Point(23, 153);
            this.rpt_Customer_Report_Viewer.Name = "rpt_Customer_Report_Viewer";
            this.rpt_Customer_Report_Viewer.Size = new System.Drawing.Size(1741, 823);
            this.rpt_Customer_Report_Viewer.TabIndex = 25;
            // 
            // frm_Add_Customer_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1878, 1024);
            this.Controls.Add(this.rpt_Customer_Report_Viewer);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Customer_Report);
            this.Name = "frm_Add_Customer_Report";
            this.Text = "frm_Add_Customer_Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_Customer_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Customer_Report;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpt_Customer_Report_Viewer;
    }
}