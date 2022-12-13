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
    public partial class frm_Distributor : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Ayurvedic_Store_Management_System_DB;Integrated Security=True");
        public frm_Distributor()
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
            tb_Distributor_ID.Text = Convert.ToString(Auto_Incr());
            tb_Distributor_Name.Text = "";
            tb_Mobile_No.Text = "";
            tb_Phone_No.Text = "";
            tb_Address.Text = "";
            dtp_Date.Text = "";
            tb_Aadhar_Card_No.Text = "";
            tb_Pan_Card_No.Text = "";
            tb_Reg_No.Text = "";
            tb_Note.Text = "";
            tb_Distributor_ID.Focus();

        }

        int Auto_Incr()
        {
            Con_Open();
            int Cnt = 0;
            SqlCommand Cmd = new SqlCommand();

            Cmd.CommandText = "Select Count(Distributor_ID) from Distributor_Details";
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

            Con_Open();
            return Cnt;
           
        }

        private void frm_Distributor_Load(object sender, EventArgs e)
        {
            tb_Distributor_ID.Text = Convert.ToString(Auto_Incr());
            dtp_Date.Text = "";
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

        private void btn_Save_Click(object sender, EventArgs e)
        {

            Con_Open();

            if (tb_Distributor_ID.Text != "" && tb_Distributor_Name.Text != "" && tb_Mobile_No.Text != "" && tb_Phone_No.Text != "" && tb_Address.Text != "" && dtp_Date.Text != "" && tb_Aadhar_Card_No.Text != "" && tb_Pan_Card_No.Text != "" && tb_Reg_No.Text != "" && tb_Note.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Con;

                cmd.CommandText = "Insert into Distributor_Details(Distributor_ID,Distributor_Name,Mobile_No,Phone_No,Address,Date,Aadhar_Card_No,Pan_Card_No,Reg_No,Note)Values('" + tb_Distributor_ID.Text + "', '" + tb_Distributor_Name.Text + "', '" + tb_Mobile_No.Text + "', '" + tb_Phone_No.Text + "', '" + tb_Address.Text + "', '" + dtp_Date.Text + "', '" + tb_Aadhar_Card_No.Text + "', '" + tb_Pan_Card_No.Text + "', '" + tb_Reg_No.Text + "', '" + tb_Note.Text + "')";

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

     }
}
