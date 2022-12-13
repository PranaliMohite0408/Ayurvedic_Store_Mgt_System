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
    public partial class frm_Customer_Bill_Report : Form
    {
        Customer_Purchase__Report6 crpt = new Customer_Purchase__Report6();

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Ayurvedic_Store_Management_System_DB;Integrated Security=True");

        public frm_Customer_Bill_Report()
        {
            InitializeComponent();
        }

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
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

        private void frm_Customer_Bill_Report_Load(object sender, EventArgs e)
        {
            //Con_Open();

            // DataSet ds = new DataSet(); 

            //SqlDataAdapter sda = new SqlDataAdapter("Select * from Customer_Details ", Con);
            //SqlDataAdapter sda1 = new SqlDataAdapter("Select * from Purchase_Details ", Con);
            //sda.Fill(ds, "Customer_Details");
            //sda1.Fill(ds, "Purchase_Details");
            //crpt.SetDataSource(ds);
            // rpt_Customer_Bill_Report_Viewer.ReportSource = crpt;
            //Con_Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Con_Open();

            DataSet ds = new DataSet();

            SqlDataAdapter sda = new SqlDataAdapter("Select Customer_Details.Customer_ID, Customer_Details.Customer_Name, Customer_Details.GST, Customer_Details.Final_Bill, Purchase_Details.Product_Name, Purchase_Details.Quantity, Purchase_Details.Total_Price from Customer_Details INNER JOIN  Purchase_Details ON Customer_Details.Customer_ID = Purchase_Details.Customer_ID where Customer_Details.Customer_ID = " + tb_Customer_ID.Text + " ", Con);

            sda.Fill(ds, "Customer_Details");
            sda.Fill(ds, "Purchase_Details");
            crpt.SetDataSource(ds);
            crpt.Load(@"F:\Ayurvedic_Store_Management_System\Ayurvedic_Store_Management_System\Customer_Purchase__Report6.rpt");
            crpt.SetDataSource(ds);
            rpt_Customer_Bill_Report_Viewer.ReportSource = crpt;

            Con_Close();
        }
    }
}
