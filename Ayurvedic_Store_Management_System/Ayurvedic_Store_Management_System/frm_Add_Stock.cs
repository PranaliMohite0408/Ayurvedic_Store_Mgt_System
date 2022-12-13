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
    public partial class frm_Add_Stock : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Ayurvedic_Store_Management_System_DB;Integrated Security=True");

        public frm_Add_Stock()
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
            tb_Product_ID.Text = Convert.ToString(Auto_Incr());
            tb_Product_Name.Text = "";
            tb_Current_Stock.Text = "";
            dtp_Date.Text = "";
            tb_New_Stock.Text = "";
            dtp_Mfg_Date.Text = "";
            dtp_Expiry_Date.Text = "";
            cmb_Product_Category.SelectedIndex = -1;
            tb_Product_ID.Focus();

        }

        int Auto_Incr()
        {
            Con_Open();
            int Cnt = 0;
            SqlCommand Cmd = new SqlCommand();

            Cmd.CommandText = "Select Count(Product_ID) from stock_Details";
            Cmd.Connection = Con;
            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cnt = Cnt + 1;
            }
            else
            {
                Cnt = 1;
            }

            Con_Close();
            return Cnt;
        }

        private void frm_Add_Stock_Load(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand("Select Distinct (Category_Name)from Category_Details", Con);
            var obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Product_Category.Items.Add(obj.GetString(obj.GetOrdinal("Category_Name")));
                
            }

            obj.Dispose();

            tb_Product_ID.Text = Convert.ToString(Auto_Incr());
            tb_Current_Stock.Text = "0";
            tb_New_Stock.Text = "0";
  

            Con_Close();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Char(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

       
        private void btn_Save_Click(object sender, EventArgs e)
        {

            Con_Open();
            if (tb_Product_ID.Text != "" && tb_Product_Name.Text != "" && tb_Current_Stock.Text != "" && tb_New_Stock.Text != "" && dtp_Date.Text != "" && dtp_Mfg_Date.Text != "" && dtp_Expiry_Date.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Con;

                cmd.CommandText = "Insert into Stock_Details(Product_ID,Product_Name,Current_Stock,New_Stock,Date,Mfg_Date,Expiry_Date) Values ('" + tb_Product_ID.Text + "', '" + tb_Product_Name.Text + "', '" + tb_Current_Stock.Text + "', '" + tb_New_Stock.Text + "', '" + dtp_Date.Text + "', '" + dtp_Mfg_Date.Text + "', '" + dtp_Expiry_Date.Text + "')";

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved Succefully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();

            }
            else
            {
                MessageBox.Show("first fill all the fields!!!");
            }

            Con_Close();

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();
            SqlCommand cmd = new SqlCommand("Select * from Product_Details where Product_ID = " + tb_Product_ID.Text + " ", Con);
            var obj = cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Product_Name.Text = obj.GetString(obj.GetOrdinal("Product_Name"));
                cmb_Product_Category.Text = obj.GetString(obj.GetOrdinal("Category"));
                tb_Current_Stock.Text = (obj["Stock"].ToString());
               
            }
            else
            {
                MessageBox.Show("Invalid Stock !!!");
                tb_Product_ID.Clear();
                tb_Product_ID.Focus();
            }
            Con_Close();
        }

       
    }
}

