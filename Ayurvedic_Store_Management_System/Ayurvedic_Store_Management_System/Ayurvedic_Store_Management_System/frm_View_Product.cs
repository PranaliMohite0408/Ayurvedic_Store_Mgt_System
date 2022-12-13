using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ayurvedic_Store_Management_System
{
    public partial class frm_View_Product : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Ayurvedic_Store_Management_System_DB;Integrated Security=True");

        public frm_View_Product()
        {
            InitializeComponent();
        }

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        private void frm_View_Product_Load(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand cmd = new SqlCommand("Select Distinct (Category_Name)from Category_Details", Con);
            var obj = cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Category.Items.Add(obj.GetString(obj.GetOrdinal("Category_Name")));
            }
            
            obj.Dispose();

            SqlDataAdapter sda = new SqlDataAdapter("Select * from Product_Details", Con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_Product_Details.DataSource = dt;

            Con_Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();
            SqlCommand cmd = new SqlCommand("Select * from Product_Details where Product_ID = " + cmb_Category.Text + " ", Con);
            var obj = cmd.ExecuteReader();

            if (obj.Read())
            {
                cmb_Product_Name.Text = obj.GetString(obj.GetOrdinal("Product_Name"));
            }
            else
            {
                MessageBox.Show("Invalid Stock !!!");
                cmb_Category.SelectedIndex = -1;
                cmb_Category.Focus();
            }
            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {

            cmb_Category.SelectedIndex = -1;
            cmb_Product_Name.SelectedIndex = -1;
        }

        private void cmb_Category_selectedIndex_Changed(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand("Select Product_Name from Product_Details Where Category = '" + cmb_Category.Text + "'", Con);
            var obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Product_Name.Items.Add(obj.GetString(obj.GetOrdinal("Product_Name")));
            }

            obj.Dispose();

            Con_Close();
        }

       
    }
}
