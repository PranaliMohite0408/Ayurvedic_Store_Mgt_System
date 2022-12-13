namespace Ayurvedic_Store_Management_System
{
    partial class frm_Customer_Bill_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Customer_Bill_Report));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbl_Customer_Bill_Report = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_Customer_ID = new System.Windows.Forms.TextBox();
            this.lbl_Customer_ID = new System.Windows.Forms.Label();
            this.rpt_Customer_Bill_Report_Viewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1267, 38);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(513, 38);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(77, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            // 
            // lbl_Customer_Bill_Report
            // 
            this.lbl_Customer_Bill_Report.AutoSize = true;
            this.lbl_Customer_Bill_Report.Font = new System.Drawing.Font("Modern No. 20", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Bill_Report.ForeColor = System.Drawing.Color.SlateBlue;
            this.lbl_Customer_Bill_Report.Location = new System.Drawing.Point(661, 30);
            this.lbl_Customer_Bill_Report.Name = "lbl_Customer_Bill_Report";
            this.lbl_Customer_Bill_Report.Size = new System.Drawing.Size(508, 58);
            this.lbl_Customer_Bill_Report.TabIndex = 40;
            this.lbl_Customer_Bill_Report.Text = "Customer Bill Report";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Location = new System.Drawing.Point(1173, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 65);
            this.button1.TabIndex = 39;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_Customer_ID
            // 
            this.tb_Customer_ID.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_ID.Location = new System.Drawing.Point(852, 157);
            this.tb_Customer_ID.Name = "tb_Customer_ID";
            this.tb_Customer_ID.Size = new System.Drawing.Size(193, 46);
            this.tb_Customer_ID.TabIndex = 38;
            // 
            // lbl_Customer_ID
            // 
            this.lbl_Customer_ID.AutoSize = true;
            this.lbl_Customer_ID.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_ID.Location = new System.Drawing.Point(437, 153);
            this.lbl_Customer_ID.Name = "lbl_Customer_ID";
            this.lbl_Customer_ID.Size = new System.Drawing.Size(268, 50);
            this.lbl_Customer_ID.TabIndex = 37;
            this.lbl_Customer_ID.Text = "Customer ID";
            // 
            // rpt_Customer_Bill_Report_Viewer
            // 
            this.rpt_Customer_Bill_Report_Viewer.ActiveViewIndex = -1;
            this.rpt_Customer_Bill_Report_Viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpt_Customer_Bill_Report_Viewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpt_Customer_Bill_Report_Viewer.Location = new System.Drawing.Point(75, 220);
            this.rpt_Customer_Bill_Report_Viewer.Name = "rpt_Customer_Bill_Report_Viewer";
            this.rpt_Customer_Bill_Report_Viewer.Size = new System.Drawing.Size(1703, 721);
            this.rpt_Customer_Bill_Report_Viewer.TabIndex = 43;
            // 
            // frm_Customer_Bill_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1878, 1024);
            this.Controls.Add(this.rpt_Customer_Bill_Report_Viewer);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lbl_Customer_Bill_Report);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_Customer_ID);
            this.Controls.Add(this.lbl_Customer_ID);
            this.Name = "frm_Customer_Bill_Report";
            this.Text = "frm_Customer_Bill_Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Customer_Bill_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbl_Customer_Bill_Report;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_Customer_ID;
        private System.Windows.Forms.Label lbl_Customer_ID;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpt_Customer_Bill_Report_Viewer;
    }
}