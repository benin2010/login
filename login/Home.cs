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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
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

        private void button5_Click(object sender, EventArgs e)
        {
            panalform(new Dashboard());
        }

        private void Home_Load(object sender, EventArgs e)
        {
            panalform(new Dashboard());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panalform(new dash_Teacher());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panalform(new dash_student());
        }
    }
}
