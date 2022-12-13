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
    public partial class frm_Add_Product : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Ayurvedic_Store_Management_System_DB;Integrated Security=True");
        public frm_Add_Product()
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
            cmb_Category.SelectedIndex = -1;
            tb_Product_Name.Text = "";
            tb_Perchase_Price.Text = "";
            tb_Sales_Price.Text = "";
            tb_Stock.Text = "";
            dtp_Mfg_Date.Text = "";
            dtp_Expiry_Date.Text = "";
            tb_Description.Text = "";
        }

        int Auto_Incr()
        {
            int Cnt = 0;
            Con_Open();
            SqlCommand Cmd = new SqlCommand();

            Cmd.CommandText = "Select Count(Product_ID) from Product_Details";
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

        private void frm_Add_Product_Load(object sender, EventArgs e)
        {
            Con_Open();
            SqlCommand Cmd = new SqlCommand("Select Distinct(Category_Name) from Category_Details",Con);
            var obj = Cmd.ExecuteReader();
            while (obj.Read())
            {
                cmb_Category.Items.Add(obj.GetString(obj.GetOrdinal("Category_Name")));
            }
            obj.Dispose();
            tb_Product_ID.Text = Convert.ToString(Auto_Incr());
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

        private void Alpha_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetterOrDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Is_Price(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {

                Con_Open();
                if (tb_Product_ID.Text != "" && cmb_Category.Text != "" && tb_Product_Name.Text != "" && tb_Perchase_Price.Text != "" && tb_Sales_Price.Text != "" && tb_Stock.Text != "" && dtp_Mfg_Date.Text != "" && dtp_Expiry_Date.Text != "" && tb_Description.Text != "")
                {
                    SqlCommand Cmd = new SqlCommand("Insert into Product_Details values(" + tb_Product_ID.Text + ",'" + cmb_Category.Text + "','" + tb_Product_Name.Text + "'," + tb_Perchase_Price.Text + "," + tb_Sales_Price.Text + ", " + tb_Stock.Text + ",'" + dtp_Mfg_Date.Text + "','" + dtp_Expiry_Date.Text + "','" + tb_Description.Text + "')", Con);
                    Cmd.ExecuteNonQuery(); 

                    MessageBox.Show("Record Saved Succefully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    Clear_Controls();
                }
                else
                {
                    MessageBox.Show("first fill all the fields!!!");
                }

                Con_Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);                
            }
        }

        

    }
}
