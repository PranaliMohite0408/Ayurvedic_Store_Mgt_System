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
    public partial class Add_New_Customer : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Ayurvedic_Store_Management_System_DB;Integrated Security=True");
        public Add_New_Customer()
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
            tb_Customer_ID.Text = Convert.ToString(Auto_Incr());
            tb_Customer_Name.Text = "";
            dtp_Date.Text = "";
            tb_Mobile_Number.Text = "";
            cmb_Category_Name.SelectedIndex = -1;
            cmb_Product_Name.SelectedIndex = -1;
            tb_Quantity.Text = "";
            tb_Price.Text = "";
            tb_Total_Price.Text = "";
            tb_Bill.Text = "";
            tb_GST.Text = "";
            tb_Final_Bill.Text = "";
            tb_Customer_ID.Focus();
        }

        int Auto_Incr()
        {
            int Cnt = 0;
            Con_Open();
            SqlCommand Cmd = new SqlCommand();

            Cmd.CommandText = "Select Count(Customer_ID) from Customer_Details";
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

        private void Add_New_Customer_Load(object sender, EventArgs e)
        {
            Con_Open();
            SqlCommand Cmd = new SqlCommand("Select Distinct(Category_Name) from Category_Details", Con);
            var obj = Cmd.ExecuteReader();
            while (obj.Read())
            {
                cmb_Category_Name.Items.Add(obj.GetString(obj.GetOrdinal("Category_Name")));
            }
            obj.Dispose();
            tb_Customer_ID.Text = Convert.ToString(Auto_Incr());
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

        private void Is_Price(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Con_Open();
            if (tb_Customer_ID.Text != "" && tb_Customer_Name.Text != "" && dtp_Date.Text != "" && cmb_Category_Name.Text != "" && cmb_Product_Name.Text != "" && tb_Quantity.Text != "" && tb_Price.Text != "" && tb_Total_Price.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Con;

                cmd.CommandText = "Insert into Purchase_Details(Category_Name,Product_Name,Quantity,Price,Total_Price) Values ('" + cmb_Category_Name.Text + "','" + cmb_Product_Name.Text + "','" + tb_Quantity.Text + "','" + tb_Price.Text + "','" + tb_Total_Price.Text + "')";

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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();
            if (tb_Customer_ID.Text != "" && tb_Customer_Name.Text != "" && dtp_Date.Text != "" && cmb_Category_Name.Text != "" && cmb_Product_Name.Text != "" && tb_Quantity.Text != "" && tb_Price.Text != "" && tb_Total_Price.Text != "" && tb_Bill.Text != "" && tb_GST.Text != "" && tb_Final_Bill.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Con;

                cmd.CommandText = "Insert into  Customer_Details(Customer_ID,Customer_Name,Date,Mobile_Number,Category_Name,Product_Name,Quantity,Price,Total_Price,Bill,GST,Final_Bill) Values ('" + tb_Customer_ID.Text + "', '" + tb_Customer_Name.Text + "','" + dtp_Date.Text + "','" + tb_Mobile_Number.Text + "','" + cmb_Category_Name.Text + "','" + cmb_Product_Name.Text + "','" + tb_Quantity.Text + "','" + tb_Price.Text + "','" + tb_Total_Price.Text + "','" + tb_Bill.Text + "','" + tb_GST.Text + "','" + tb_Final_Bill.Text + "')";

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
            tb_Customer_ID.Clear();
            tb_Customer_Name.Clear();
            tb_Mobile_Number.Clear();
            cmb_Category_Name.SelectedIndex = -1;
            cmb_Product_Name.SelectedIndex = -1;
            tb_Quantity.Clear();
            tb_Price.Clear();
            tb_Total_Price.Clear();
            tb_Bill.Clear();
            tb_GST.Clear();
            tb_Final_Bill.Clear();

        }

        private void cmb_Category_Selected(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand("Select Product_Name from Product_Details Where Category = '" + cmb_Category_Name.Text + "'", Con);
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
