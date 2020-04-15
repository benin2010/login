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
   
    public partial class add_leavetype : Form
    {
        data d = new data();
        public static int index = -1;
        public add_leavetype()
        {
            InitializeComponent();
        }

        private void add_leavetype_KeyDown(object sender, KeyEventArgs e)
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
            if (cmbay.Text == "" || txtdesig.Text == "" || txtltype.Text == ""  || txtndays.Text == "")
            {
                MessageBox.Show("Fill All Details");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(d.getconnection());
                con.Open();
                string s = "insert into add_leavetypeemployee (aca_year,desig,leave_type,n_days) values('" + cmbay.Text + "','" + txtdesig.Text + "','" + txtltype.Text + "','" + txtndays.Text + "')";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                cmbay.Focus();
            }
        }
        public void load()
        {
            MySqlConnection con = new MySqlConnection(d.getconnection());
            con.Open();
            string s = "select * from add_leavetypeemployee  ORDER BY id DESC";
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
            if (cmbay.Text == "" || txtdesig.Text == "" || txtltype.Text == "" || txtndays.Text == "")
            {
                MessageBox.Show("Please Fill All Data");
            }
            else if (index == -1)
            {
                MessageBox.Show("Please Select Update row");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(d.getconnection());
                con.Open();
                string s = "update add_leavetypeemployee set aca_year='" + cmbay.Text + "', desig='" + txtdesig.Text + "', leave_type='" + txtltype.Text + "', n_days='" + txtndays.Text + "' where id=" + index + "";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                load();
                clear();
                cmbay.Focus();
                index = -1;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Please Select Update row");
            }
            MySqlConnection con = new MySqlConnection(d.getconnection());
            con.Open();
            string s = "delete from add_leavetypeemployee where id=" + index + "";
            MySqlCommand cmd = new MySqlCommand(s, con);
            cmd.ExecuteNonQuery();
            con.Close();
            clear();
            load();
            cmbay.Focus();
            index = -1;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            clear();
            load();
            cmbay.Focus();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void clear()
        {
            cmbay.Text = "";
            txtdesig.Text = "";
            txtltype.Text = "";
            txtndays.Text = "";
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = e.RowIndex;
            DataGridViewRow selectrow = dataGridView1.Rows[id];
            index = Convert.ToInt32(selectrow.Cells[0].Value.ToString());
            cmbay.Text = selectrow.Cells[1].Value.ToString(); ;
            txtdesig.Text = selectrow.Cells[2].Value.ToString(); ;
            txtltype.Text = selectrow.Cells[3].Value.ToString(); ;
            txtndays.Text = selectrow.Cells[4].Value.ToString(); ;

        }

        private void add_leavetype_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
