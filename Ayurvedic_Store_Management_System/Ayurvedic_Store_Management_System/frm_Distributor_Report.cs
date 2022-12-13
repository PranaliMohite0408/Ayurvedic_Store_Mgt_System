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
    public partial class frm_Distributor_Report : Form
    {
        Distributor_Report2 crpt = new Distributor_Report2();

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Ayurvedic_Store_Management_System_DB;Integrated Security=True");

        public frm_Distributor_Report()
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

        private void frm_Distributor_Report_Load(object sender, EventArgs e)
        {
            Con_Open();

            DataSet ds = new DataSet();

            SqlDataAdapter sda = new SqlDataAdapter("Select * from Distributor_Details ", Con);
            sda.Fill(ds, "Distributor_Details");
            crpt.SetDataSource(ds);
            rpt_Distributor_Report_Viewer.ReportSource = crpt;
            Con_Close();
        }
    }
}
