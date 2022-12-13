namespace Ayurvedic_Store_Management_System
{
    partial class frm_Add_Category
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
            this.gb_Add_Category = new System.Windows.Forms.GroupBox();
            this.pnl_Add_Category = new System.Windows.Forms.Panel();
            this.lbl_Add_Category = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Category_Name = new System.Windows.Forms.TextBox();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.tb_Categary_ID = new System.Windows.Forms.TextBox();
            this.gb_Add_Category.SuspendLayout();
            this.pnl_Add_Category.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Add_Category
            // 
            this.gb_Add_Category.BackColor = System.Drawing.Color.LightSeaGreen;
            this.gb_Add_Category.Controls.Add(this.pnl_Add_Category);
            this.gb_Add_Category.Controls.Add(this.btn_Save);
            this.gb_Add_Category.Controls.Add(this.tb_Category_Name);
            this.gb_Add_Category.Controls.Add(this.lbl_Category_Name);
            this.gb_Add_Category.Controls.Add(this.lbl_ID);
            this.gb_Add_Category.Controls.Add(this.tb_Categary_ID);
            this.gb_Add_Category.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Add_Category.ForeColor = System.Drawing.Color.Black;
            this.gb_Add_Category.Location = new System.Drawing.Point(207, 79);
            this.gb_Add_Category.Name = "gb_Add_Category";
            this.gb_Add_Category.Size = new System.Drawing.Size(1434, 610);
            this.gb_Add_Category.TabIndex = 0;
            this.gb_Add_Category.TabStop = false;
            // 
            // pnl_Add_Category
            // 
            this.pnl_Add_Category.BackColor = System.Drawing.Color.Purple;
            this.pnl_Add_Category.Controls.Add(this.lbl_Add_Category);
            this.pnl_Add_Category.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Add_Category.Location = new System.Drawing.Point(3, 25);
            this.pnl_Add_Category.Name = "pnl_Add_Category";
            this.pnl_Add_Category.Size = new System.Drawing.Size(1428, 100);
            this.pnl_Add_Category.TabIndex = 42;
            // 
            // lbl_Add_Category
            // 
            this.lbl_Add_Category.AutoSize = true;
            this.lbl_Add_Category.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Add_Category.Font = new System.Drawing.Font("Modern No. 20", 30F);
            this.lbl_Add_Category.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Add_Category.Location = new System.Drawing.Point(525, 21);
            this.lbl_Add_Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Add_Category.Name = "lbl_Add_Category";
            this.lbl_Add_Category.Size = new System.Drawing.Size(351, 62);
            this.lbl_Add_Category.TabIndex = 23;
            this.lbl_Add_Category.Text = "Add Category";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(574, 501);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(258, 79);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Category_Name
            // 
            this.tb_Category_Name.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Category_Name.Location = new System.Drawing.Point(801, 337);
            this.tb_Category_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Category_Name.Name = "tb_Category_Name";
            this.tb_Category_Name.Size = new System.Drawing.Size(371, 55);
            this.tb_Category_Name.TabIndex = 2;
            this.tb_Category_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Modern No. 20", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Category_Name.Location = new System.Drawing.Point(263, 340);
            this.lbl_Category_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(361, 58);
            this.lbl_Category_Name.TabIndex = 40;
            this.lbl_Category_Name.Text = "Category Name";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ID.Font = new System.Drawing.Font("Modern No. 20", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_ID.Location = new System.Drawing.Point(372, 201);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(103, 58);
            this.lbl_ID.TabIndex = 39;
            this.lbl_ID.Text = " ID";
            // 
            // tb_Categary_ID
            // 
            this.tb_Categary_ID.Enabled = false;
            this.tb_Categary_ID.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Categary_ID.Location = new System.Drawing.Point(801, 201);
            this.tb_Categary_ID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Categary_ID.Name = "tb_Categary_ID";
            this.tb_Categary_ID.Size = new System.Drawing.Size(371, 55);
            this.tb_Categary_ID.TabIndex = 1;
            this.tb_Categary_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // frm_Add_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1890, 1036);
            this.Controls.Add(this.gb_Add_Category);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frm_Add_Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Category";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_Category_Load);
            this.gb_Add_Category.ResumeLayout(false);
            this.gb_Add_Category.PerformLayout();
            this.pnl_Add_Category.ResumeLayout(false);
            this.pnl_Add_Category.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Add_Category;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Category_Name;
        private System.Windows.Forms.Label lbl_Category_Name;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox tb_Categary_ID;
        private System.Windows.Forms.Panel pnl_Add_Category;
        private System.Windows.Forms.Label lbl_Add_Category;

    }
}