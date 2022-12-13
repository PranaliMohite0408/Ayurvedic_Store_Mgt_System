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
    public partial class frm_Category_Report : Form
    {
        Category_Report1 crpt = new Category_Report1();

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Ayurvedic_Store_Management_System_DB;Integrated Security=True");

        public frm_Category_Report()
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

        private void frm_Category_Report_Load(object sender, EventArgs e)
        {
            Con_Open();

            DataSet ds = new DataSet();

            SqlDataAdapter sda = new SqlDataAdapter("Select * from Category_Details ", Con);
            sda.Fill(ds, "Category_Details");
            crpt.SetDataSource(ds);
            rpt_Category_Report_Viewer.ReportSource = crpt;
            Con_Close();
        }
    }
}
