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
    public partial class frm_Update_Product : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Ayurvedic_Store_Management_System_DB;Integrated Security=True");
        public frm_Update_Product()
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
        void Clear_Controls()
        {
            cmb_Category.SelectedIndex = -1;
            cmb_Product_Name.SelectedIndex = -1;
            tb_Purchase_Price.Text = "";
            tb_Sales_Price.Text = "";
            tb_Description.Text = "";
            cmb_Category.Focus();
        }

      
        
        private void frm_Update_Product_Load(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand cmd = new SqlCommand("Select Distinct (Category_Name)from Category_Details", Con);
            var obj = cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Category.Items.Add(obj.GetString(obj.GetOrdinal("Category_Name")));
            }

            obj.Dispose();

            Con_Close();

        }

        private void Is_Price(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Alpha_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetterOrDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();
            if (cmb_Category.Text != "" && cmb_Product_Name.Text != "" && tb_Purchase_Price.Text != "" && tb_Sales_Price.Text != "" && tb_Description.Text != "")
            {

                SqlDataAdapter sda = new SqlDataAdapter("Product_Details Set Category = '" + cmb_Category.Text + "',Product_Name = '" + cmb_Product_Name.Text + "', Purchase_price = '" + tb_Purchase_Price.Text + "', Sales_Price = '" + tb_Sales_Price.Text + "',Description = " + tb_Description.Text + "", Con);
                DataTable dt = new DataTable();
         

                MessageBox.Show("Record update Successfully !!!");
                Clear_Controls();
                cmb_Category.Enabled = true;
            }
            else
            {
                MessageBox.Show("first fill all the fields!!!");
            }

            Con_Close();

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();
            if (cmb_Category.Text != "" && cmb_Product_Name.Text != "" && tb_Purchase_Price.Text != "" && tb_Sales_Price.Text != "" && tb_Description.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Con;

                cmd.CommandText = "Insert into Product_Details(Category,Product_Name,Purchase_Price,Sales_Price,Description) values ('" + cmb_Category.Text + "','" + cmb_Product_Name.Text + "','" + tb_Purchase_Price.Text + "','" + tb_Sales_Price.Text + "','" + tb_Description.Text + "')";

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("first fill all the fields!!!");
            }

            Con_Close();

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cmb_Category.SelectedIndex = -1;
            cmb_Product_Name.SelectedIndex = -1;
            tb_Purchase_Price.Clear();
            tb_Sales_Price.Clear();
            tb_Description.Clear();
            cmb_Category.Focus();

        }

        private void cmb_Category_SelectIndexChanged(object sender, EventArgs e)
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
