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
    public partial class txtano : Form
    {
        data d = new data();
        public static int index = -1;
        public txtano()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_location_KeyDown(object sender, KeyEventArgs e)
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
            if (txtalmirano.Text == "" || txtaposition.Text == "")
            {
                MessageBox.Show("Fill All Details");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(d.getconnection());
                con.Open();
                string s = "insert into add_loc(al_no,al_po) values('" + txtalmirano.Text + "','" + txtaposition.Text + "')";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                txtalmirano.Focus();
            }
        }
        public void load()
        {
            MySqlConnection con = new MySqlConnection(d.getconnection());
            //      con.Open();
            con.Open();
            string s = "select * from add_loc ORDER BY id DESC;";
            MySqlCommand cmd = new MySqlCommand(s, con);
            MySqlDataReader rs = cmd.ExecuteReader();
            dgv1.Rows.Clear();
            while (rs.Read())
            {
                dgv1.Rows.Add(rs[0], rs[1], rs[2]);
            }
            rs.Close();
            con.Close();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (txtalmirano.Text == "" || txtaposition.Text == "")
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
                string s = "update add_loc set al_no='" + txtalmirano.Text + "',al_po='" + txtaposition.Text + "' where id=" + index + "";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                txtalmirano.Focus();
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
                string s = "delete from add_loc where id=" + index + "";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                txtalmirano.Focus();
                index = -1;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            clear();
            load();
            txtalmirano.Focus();
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
        void clear()
        {
            txtalmirano.Text = "";
            txtaposition.Text = "";
        }

        private void dgv1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = e.RowIndex;
            DataGridViewRow selectrow = dgv1.Rows[id];
            index = Convert.ToInt32(selectrow.Cells[0].Value.ToString());
            txtalmirano.Text = selectrow.Cells[1].Value.ToString();
            txtaposition.Text = selectrow.Cells[2].Value.ToString();
        }

        private void txtano_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
