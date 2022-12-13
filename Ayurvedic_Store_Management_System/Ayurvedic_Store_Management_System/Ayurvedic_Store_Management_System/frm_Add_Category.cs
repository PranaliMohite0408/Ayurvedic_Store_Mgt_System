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
    public partial class frm_Add_Category : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Ayurvedic_Store_Management_System_DB;Integrated Security=True");
        public frm_Add_Category()
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
            tb_Categary_ID.Text = Convert.ToString(Auto_Incr());
            tb_Category_Name.Focus();
            tb_Category_Name.Text = "";
        }

        int Auto_Incr()
        {
            int Cnt = 0;
            Con_Open();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(Category_ID) from Category_Details";
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

        private void frm_Add_Category_Load(object sender, EventArgs e)
        {
            tb_Categary_ID.Text = Convert.ToString(Auto_Incr());
            tb_Category_Name.Focus();
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

            if (tb_Categary_ID.Text != "" && tb_Category_Name.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Con;

                cmd.CommandText = "Insert into Category_Details Values (" + tb_Categary_ID.Text + ", '" + tb_Category_Name.Text + "')";

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Save Successfully !!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("first fill all the fields!!!");
            }

            Clear_Controls();
            Con_Close();
        }
     }
}
