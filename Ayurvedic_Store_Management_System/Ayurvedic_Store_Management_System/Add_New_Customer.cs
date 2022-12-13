﻿using System;
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

        int pCnt = 1, Current_Stock = 0;

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
                Cnt = Cnt + 10001;
            }
            else
            {
                Cnt = 10001;
            }
            Con_Close();
            return Cnt;
        }

        private void Add_New_Customer_Load(object sender, EventArgs e)
        {
            Clear_Controls();

            tb_Customer_Name.Focus();
            Bind_ComboBox();
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

        void Bind_ComboBox()
        {
            Con_Open();

            cmb_Category_Name.Items.Clear();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "Select Distinct(Category_Name) From Category_Details";
            cmd.Connection = Con;

            SqlDataReader obj = cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Category_Name.Items.Add(obj.GetString(obj.GetOrdinal("Category_Name")));
            }

            obj.Dispose();
            cmd.Dispose();

            Con_Close();
        }

        void Clear_Controls()
        {
            tb_Customer_ID.Text = Convert.ToString(Auto_Incr());

            tb_Customer_Name.Clear();
            dtp_Date.ResetText();
            tb_Mobile_Number.Clear();

            tb_Quantity.Text = "0";
            tb_Price.Text = "0";
            tb_Total_Price.Text = "0";
            tb_Bill.Text = "0";
            tb_GST.Text = "0";
            tb_Final_Bill.Text = "0";
            dgv_Purchase_Details.Rows.Clear();

            cmb_Category_Name.SelectedIndex = -1;
            cmb_Product_Name.SelectedIndex = -1;

        }

        private void cmb_Category_Selected(object sender, EventArgs e)
        {
            Con_Open();

            cmb_Product_Name.Items.Clear();

            SqlCommand Cmd = new SqlCommand("Select Product_Name from Product_Details Where Category = '" + cmb_Category_Name.Text + "'", Con);

            SqlDataReader obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Product_Name.Items.Add(obj.GetString(obj.GetOrdinal("Product_Name")));
            }

            obj.Dispose();
            Cmd.Dispose();

            Con_Close();
        }

        private void cmb_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand("Select Sales_Price From Product_Details where Category = '" + cmb_Category_Name.Text + "' And Product_Name =  '" + cmb_Product_Name.Text + "' ", Con);

            SqlDataReader obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                tb_Price.Text = (obj["Sales_Price"].ToString());
            }

            tb_Quantity.Enabled = true;

            obj.Dispose();
            Cmd.Dispose();

            Con_Close();

        }

        private void tb_Quantity_TextChanged(object sender, EventArgs e)
        {
            double Total_Price = 0;

            if (tb_Quantity.Text != "" && (Convert.ToInt32(tb_Quantity.Text) > 0))
            {
                Total_Price = Convert.ToDouble(tb_Quantity.Text) * Convert.ToDouble(tb_Price.Text);

                tb_Total_Price.Text = Convert.ToString(Total_Price);
            }

            btn_Add.Enabled = true;
        }

        private void tb_Quantity_Leave(object sender, EventArgs e)
        {
            if (cmb_Category_Name.Text != "" &&  cmb_Product_Name.Text != "" && (tb_Quantity.Text == "" || tb_Quantity.Text == "0"))
            {
                MessageBox.Show("Invalid Quantity!!!");
                tb_Quantity.Text = "0";
                tb_Quantity.Focus();
                btn_Add.Enabled = false;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int flag = -1;

            for (int i = 0; i <= dgv_Purchase_Details.Rows.Count - 1; i++)
            {
                if (Convert.ToString(dgv_Purchase_Details.Rows[i].Cells[2].Value) == cmb_Product_Name.Text)
                {
                    flag = 0;

                    int Qty = Convert.ToInt32(dgv_Purchase_Details.Rows[i].Cells[3].Value);

                    Qty += Convert.ToInt32(tb_Quantity.Text);

                    double Total_Price = Convert.ToDouble(Qty) * Convert.ToDouble(tb_Price.Text);

                    dgv_Purchase_Details.Rows[i].Cells[3].Value = Qty;
                    dgv_Purchase_Details.Rows[i].Cells[5].Value = Total_Price;
                }
            }

            if (flag != 0)
            {
                dgv_Purchase_Details.Rows.Add(cmb_Category_Name.Text, cmb_Product_Name.Text, tb_Quantity.Text, tb_Price.Text, tb_Total_Price.Text);

                double Bill = Convert.ToDouble(tb_Bill.Text) + Convert.ToDouble(tb_Total_Price.Text);

                tb_Bill.Text = Convert.ToString(Bill);
                tb_Final_Bill.Text = Convert.ToString(Bill);

                pCnt++;
            }

            cmb_Category_Name.SelectedIndex = -1;
            cmb_Product_Name.SelectedIndex = -1;

            tb_Quantity.Text = "0";
            tb_Price.Clear();
            tb_Total_Price.Clear();
            cmb_Category_Name.Focus();

            btn_Add.Enabled = false;
        }
            
        private void tb_GST_TextChanged(object sender, EventArgs e)
        {
            if (tb_GST.Text != "")
            {
                double GST = Convert.ToDouble(tb_Bill.Text) * (Convert.ToDouble(tb_GST.Text) / 100);

                double Final_Bill = Convert.ToDouble(tb_Bill.Text) + GST;

                tb_Final_Bill.Text = Convert.ToString(Final_Bill);

                btn_Save.Enabled = true;
            }
        }

        private void tb_GST_Leave(object sender, EventArgs e)
        {
            if (tb_GST.Text == "")
            {
                MessageBox.Show("GST Should be Zero or Positive Values!!!");
                tb_GST.Text = "0";
                tb_GST.Focus();
                btn_Save.Enabled = false;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Customer_ID.Text != "" && tb_Customer_Name.Text != "" && dtp_Date.Text != "" && tb_Mobile_Number.Text != "" && pCnt > 1 && tb_Bill.Text != "" && tb_Final_Bill.Text != "" && tb_GST.Text != "")
            {
                Con_Open();

                SqlCommand cmd = new SqlCommand("Insert Into Customer_Details Values (@Customer_ID, @Customer_Name, @Mobile_Number, @Date, @Bill, @GST, @Final_Bill )", Con);

                cmd.Parameters.Add("@Customer_ID", SqlDbType.Int).Value = tb_Customer_ID.Text;
                cmd.Parameters.Add("@Customer_Name", SqlDbType.NVarChar).Value = tb_Customer_Name.Text;
                cmd.Parameters.Add("@Date", SqlDbType.Date).Value = dtp_Date.Value.Date;
                cmd.Parameters.Add("@Mobile_Number", SqlDbType.Decimal).Value = tb_Mobile_Number.Text;
                cmd.Parameters.Add("@Bill", SqlDbType.Money).Value = tb_Bill.Text;
                cmd.Parameters.Add("@GST", SqlDbType.Float).Value = tb_GST.Text;
                cmd.Parameters.Add("@Final_Bill", SqlDbType.Money).Value = tb_Final_Bill.Text;

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                for (int i = 0; i <= dgv_Purchase_Details.Rows.Count - 1; i++)
                {
                    SqlCommand cmd1 = new SqlCommand("Insert Into Purchase_Details Values (@Customer_ID, @Category_Name, @Product_Name, @Quantity, @Price, @Total_Price )", Con);

                    cmd1.Parameters.Add("@Customer_ID", SqlDbType.Int).Value = tb_Customer_ID.Text;
                    cmd1.Parameters.Add("@Category_Name", SqlDbType.NVarChar).Value = dgv_Purchase_Details.Rows[i].Cells[0].Value;
                    cmd1.Parameters.Add("@Product_Name", SqlDbType.NVarChar).Value = dgv_Purchase_Details.Rows[i].Cells[1].Value;
                    cmd1.Parameters.Add("@Quantity", SqlDbType.Int).Value = dgv_Purchase_Details.Rows[i].Cells[2].Value;
                    cmd1.Parameters.Add("@Price", SqlDbType.Money).Value = dgv_Purchase_Details.Rows[i].Cells[3].Value;
                    cmd1.Parameters.Add("@Total_Price", SqlDbType.Money).Value = dgv_Purchase_Details.Rows[i].Cells[4].Value;

                    cmd1.ExecuteNonQuery();
                    cmd1.Dispose();

                    int Saled_Quantity = Convert.ToInt32(dgv_Purchase_Details.Rows[i].Cells[2].Value); 
                    int Product_Current_Stock = 0;
                    int Product_ID = 0;
                    int New_Stock = 0;

                    cmd1.CommandText = "Select Product_ID, Stock From Product_Details where Category = '" + dgv_Purchase_Details.Rows[i].Cells[0].Value + "' And Product_Name = '" + dgv_Purchase_Details.Rows[i].Cells[1].Value + "'";
                    cmd1.Connection = Con;

                    var obj = cmd1.ExecuteReader();

                    if (obj.Read())
                    {
                        Product_ID = Convert.ToInt32((obj["Product_ID"].ToString()));   
                        Product_Current_Stock = Convert.ToInt32((obj["Stock"].ToString())); 
                    }

                    New_Stock = Product_Current_Stock - Saled_Quantity;   
                    obj.Close();
                    cmd1.Dispose();

                    SqlDataAdapter sda = new SqlDataAdapter(" Update Product_Details Set Stock = " + New_Stock + " where Product_ID = " + Product_ID + "", Con);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                }

                MessageBox.Show("Customer Details Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
                Con_Close();
            }
            else
            {
                MessageBox.Show("Fill Customer & Purchase Details Properly", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DialogResult Res = System.Windows.Forms.DialogResult.Yes;

            if (tb_Customer_Name.Text != "" || tb_Mobile_Number.Text != "" || pCnt > 1 || tb_Bill.Text != "" || tb_Final_Bill.Text != "" || tb_GST.Text != "")
            {
                Res = MessageBox.Show("Are You Sure Data Entered Will Be Lost?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            if (Res == System.Windows.Forms.DialogResult.Yes)
            {
                Clear_Controls();
            }

        }


    }
}
    

