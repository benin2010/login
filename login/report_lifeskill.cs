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
    public partial class report_lifeskill : Form
    {
        public report_lifeskill()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.Close();
        }

        private void Life_skills_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                btn_Add_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.U)
            {
                toolStripButton2_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.D)
            {
                toolStripButton1_Click(sender, e);
            }
            else if (e.Alt && e.KeyCode == Keys.C)
            {
                btn_Refresh_Click(sender, e);
            }
            else if (e.Alt && e.KeyCode == Keys.X)
            {
                this.Close();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtnm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
