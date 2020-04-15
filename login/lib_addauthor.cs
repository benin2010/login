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
    public partial class lib_addauthor : Form
    {
        data d = new data();
        public static int index = -1;
        public lib_addauthor()
        {
            InitializeComponent();
        }

        private void Add_author_KeyDown(object sender, KeyEventArgs e)
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
        public void load()
        {
            MySqlConnection con = new MySqlConnection(d.getconnection());
            //      con.Open();
            con.Open();
            string s = "select * from add_aut ORDER BY id DESC;";
            MySqlCommand cmd = new MySqlCommand(s, con);
            MySqlDataReader rs = cmd.ExecuteReader();
            dgv1.Rows.Clear();
            while (rs.Read())
            {
                dgv1.Rows.Add(rs[0], rs[1]);
            }
            rs.Close();
            con.Close();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txtaut.Text == "" )
            {
                MessageBox.Show("Fill All Details");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(d.getconnection());
                con.Open();
                string s = "insert into add_aut(au_na) values('" + txtaut.Text + "')";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                txtaut.Focus();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (txtaut.Text == "" )
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
                string s = "update add_aut set au_na='" + txtaut.Text + "' where id=" + index + "";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                txtaut.Focus();
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
                string s = "delete from add_aut where id=" + index + "";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                txtaut.Focus();
                index = -1;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            clear();
            load();
            txtaut.Focus();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void clear()
        {
            txtaut.Text = "";
            
        }
        private void dgv1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = e.RowIndex;
            DataGridViewRow selectrow = dgv1.Rows[id];
            index = Convert.ToInt32(selectrow.Cells[0].Value.ToString());
            txtaut.Text = selectrow.Cells[1].Value.ToString();
           
        }

        private void lib_addauthor_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
