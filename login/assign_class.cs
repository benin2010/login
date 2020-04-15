using MySql.Data.MySqlClient;
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
    public partial class assign_class : Form
    {
        data d = new data();
        public static int index = -1;
        public assign_class()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void assign_class_KeyDown(object sender, KeyEventArgs e)
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
            if (txteid.Text == "" || txten.Text == "" || cmbacay.Text == "" || txtcls.Text == "" || txtsec.Text == "" || cmbtype.Text == "")
            {
                MessageBox.Show("Fill All Details");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(d.getconnection());
                con.Open();
                string s = "insert into assign_class (staff_id,staff_name,aca_yr,class,sec,type) values('" + txteid.Text + "','" + txten.Text + "','" + cmbacay.Text + "','" + txtcls.Text + "','" + txtsec.Text + "','" + cmbtype.Text + "')";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                txteid.Focus();
            }
        }
        public void load()
        {
            MySqlConnection con = new MySqlConnection(d.getconnection());
            //      con.Open();
            con.Open();
            string s = "select * from assign_class ORDER BY id DESC;";
            MySqlCommand cmd = new MySqlCommand(s, con);
            MySqlDataReader rs = cmd.ExecuteReader();
            dgv1.Rows.Clear();
            while (rs.Read())
            {
                dgv1.Rows.Add(rs[0], rs[1], rs[2], rs[3], rs[4], rs[5], rs[6]);
            }
            rs.Close();
            con.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (txteid.Text == "" || txten.Text == "" || cmbacay.Text == "" || txtcls.Text == "" || txtsec.Text == "" || cmbtype.Text == "")
            {
                MessageBox.Show("Fill All Details");
            }
            else if (index == -1)
            {
                MessageBox.Show("Please Select Update row");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(d.getconnection());
                con.Open();
                string s = "update assign_class set staff_id='" + txteid.Text + "', staff_name='" + txten.Text + "', aca_yr='" + cmbacay.Text + "', class='" + txtcls.Text + "', sec='" + txtsec.Text + "' , type = '" + cmbtype.Text + "' where id=" + index + "";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                txteid.Focus();
                index = -1;

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Please Select Update row");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(d.getconnection());
                con.Open();
                string s = "delete from assign_class where id=" + index + "";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                txteid.Focus();
                index = -1;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            clear();
            load();
            txtcls.Focus();
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
        void clear()
        {
            txteid.Text = "";
            txten.Text = "";
            cmbacay.Text = "";
            txtcls.Text = "";
            txtsec.Text = "";
            cmbtype.Text = "";

        }

        private void dgv1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = e.RowIndex;
            DataGridViewRow selectrow = dgv1.Rows[id];
            index = Convert.ToInt32(selectrow.Cells[0].Value.ToString());
            txteid.Text = selectrow.Cells[1].Value.ToString();
            txten.Text = selectrow.Cells[2].Value.ToString();
            cmbacay.Text = selectrow.Cells[3].Value.ToString();
            txtcls.Text = selectrow.Cells[4].Value.ToString();
            txtsec.Text = selectrow.Cells[5].Value.ToString();
            cmbtype.Text = selectrow.Cells[5].Value.ToString();
        }
    
    private void add_ppt_Load(object sender, EventArgs e)
    {
        load();
    }
}
}
