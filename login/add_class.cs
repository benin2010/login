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
    public partial class add_class : Form
    {
        data d = new data();
        public static int index = -1;
        public add_class()
        {
            InitializeComponent();
        }

        private void add_class_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txtclass.Text == "" || txtsec.Text == "" || txttot.Text == "" || cmbaca.Text == "")
            {
                MessageBox.Show("Fill All Details");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(d.getconnection());
                con.Open();
                string s = "insert into class_tb (class_name,sec_count,total_sec,a_year) values('" + txtclass.Text + "','" + txtsec.Text + "','" + txttot.Text + "','" + cmbaca.Text + "')";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                txtclass.Focus();
            }
        }
        void clear()
        {
            txtclass.Text = "";
            txtsec.Text = "";
            txttot.Text = "";
            cmbaca.Text = "";
        }
        public void load()
        {
            MySqlConnection con = new MySqlConnection(d.getconnection());
            //      con.Open();
            con.Open();
            string s = "select * from class_tb ORDER BY id DESC;";
            MySqlCommand cmd = new MySqlCommand(s, con);
            MySqlDataReader rs = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (rs.Read())
            {
                dataGridView1.Rows.Add(rs[0], rs[1], rs[2], rs[3], rs[4]);
            }
            rs.Close();
            con.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (txtclass.Text == "" || txtsec.Text == "" || txttot.Text == "" || cmbaca.Text == "")
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
                string s = "update class_tb set class_name='" + txtclass.Text + "',sec_count='" + txtsec.Text + "',total_sec='" + txttot.Text + "',a_year='" + cmbaca.Text + "' where id=" + index + "";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                txtclass.Focus();
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
                string s = "delete from class_tb where id=" + index + "";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                txtclass.Focus();
                index = -1;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            clear();
            load();
            txtclass.Focus();
        }

        private void add_class_KeyDown(object sender, KeyEventArgs e)
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

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex;
            DataGridViewRow selectrow = dataGridView1.Rows[id];
            index = Convert.ToInt32(selectrow.Cells[0].Value.ToString());
            txtclass.Text = selectrow.Cells[1].Value.ToString(); ;
            txtsec.Text= selectrow.Cells[2].Value.ToString();
            txttot.Text = selectrow.Cells[3].Value.ToString();
            cmbaca.Text= selectrow.Cells[4].Value.ToString();
        }
    }
}
