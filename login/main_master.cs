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
    public partial class main_master : Form
    {
        public main_master()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn2.Visible = true;
            btn1.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login_form f = new login_form();
            f.Show();
            this.Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.Visible = false;
            btn1.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void panalform(object form)
        {
            if (this.panalCont.Controls.Count > 0)
                this.panalCont.Controls.RemoveAt(0);
            Form fm = form as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.panalCont.Controls.Add(fm);
            this.panalCont.Tag = fm;
            fm.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if(this.panelmenu.Width==195)
            {
                img1.Visible = true;
                img2.Visible = false;
                this.panelmenu.Width = 37;
            }
            else
            {
                img1.Visible = false;
                img2.Visible = true;
                this.panelmenu.Width = 195;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panalform(new Home());
        }

        private void main_master_Load(object sender, EventArgs e)
        {
            panalform(new Home());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panalform(new Admin_master());
        }
    }
}
