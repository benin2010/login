using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class login_form : Form
    {
        persion p = new persion();
        public login_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnl_Click(object sender, EventArgs e)
        {
            if(txtp.Text=="Admin" && txtu.Text=="Admin")
            {
                p.dept1 = "Admin";
                this.Hide();
                main_master m = new main_master();
                m.Show();
            }
           else if (txtp.Text == "Teacher" && txtu.Text == "Teacher")
            {
                p.dept1 = "Teacher";
                this.Hide();
                main_master m = new main_master();
                m.Show();
            }
            else if (txtp.Text == "Library" && txtu.Text == "Library")
            {
                p.dept1 = "Library";
                this.Hide();
                main_master m = new main_master();
                m.Show();
            }
            else if (txtp.Text == "Account" && txtu.Text == "Account")
            {
                p.dept1 = "Account";
                this.Hide();
                main_master m = new main_master();
                m.Show();
            }

        }
    }
}
