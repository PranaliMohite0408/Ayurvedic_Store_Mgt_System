using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ayurvedic_Store_Management_System
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            lbl_Note.Text = "Please Enter Your Username and Password";
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text == "s" && tb_Password.Text == "s")
            {
                MessageBox.Show("Login Successfull !!!");
                frm_Login obj = new frm_Login();
                obj.Show();
                this.Hide();
            }

            else
            {
                lbl_Note.Text = "Please Enter Your Details";

            }

            tb_Username.Text = "";
            tb_Password.Text = "";

            tb_Username.Focus();
        }

     
    }
}
