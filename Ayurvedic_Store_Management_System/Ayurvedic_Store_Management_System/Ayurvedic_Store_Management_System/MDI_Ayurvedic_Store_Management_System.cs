using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ayurvedic_Store_Management_System
{
    public partial class MDI_Ayurvedic_Store_Management_System : Form
    {      

        public MDI_Ayurvedic_Store_Management_System()
        {
            InitializeComponent();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_New_Customer obj = new Add_New_Customer();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void viewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_Customer obj = new frm_View_Customer();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Category obj = new frm_Add_Category();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Normal;
            obj.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Product obj = new frm_Add_Product();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void updateProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Product obj = new frm_Update_Product();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }
        
        private void viewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_Product obj = new frm_View_Product();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Stock obj = new frm_Add_Stock();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.WindowState = FormWindowState.Normal;
            obj.Show();
        }

        private void distributorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Distributor obj = new frm_Distributor();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }
    }
}
