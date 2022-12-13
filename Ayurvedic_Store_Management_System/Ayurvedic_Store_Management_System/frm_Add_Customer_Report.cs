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
    public partial class frm_Add_Customer_Report : Form
    {
        Customer_Report5 crpt = new Customer_Report5();

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Ayurvedic_Store_Management_System_DB;Integrated Security=True");

        public frm_Add_Customer_Report()
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

        private void frm_Add_Customer_Report_Load(object sender, EventArgs e)
        {
             Con_Open();

            DataSet ds = new DataSet();

            SqlDataAdapter sda = new SqlDataAdapter("Select * from Customer_Details ", Con);
            sda.Fill(ds, "Customer_Details");
            crpt.SetDataSource(ds);
            rpt_Customer_Report_Viewer.ReportSource = crpt;
            Con_Close();
        }
      }
  }

