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
    public partial class add_syllabus : Form
    {
        data d = new data();
        public static int index = -1;
        public add_syllabus()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void syllabus_KeyDown(object sender, KeyEventArgs e)
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
            if (txtcls.Text == "" || txtsn.Text == "" || cmbacay.Text == "" || txtupby.Text == "")
            {
                MessageBox.Show("Fill All Details");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(d.getconnection());
                con.Open();
                string s = "insert into add_syllabus (cls,sub_name,aca_yr,up_by,up_file) values('" + txtcls.Text + "','" + txtsn.Text + "','" + cmbacay.Text + "','" + txtupby.Text + "','" + btnupfile.Text + "')";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                txtcls.Focus();
            }

        }
        public void load()
        {
            MySqlConnection con = new MySqlConnection(d.getconnection());
            //      con.Open();
            con.Open();
            string s = "select * from add_syllabus ORDER BY id DESC;";
            MySqlCommand cmd = new MySqlCommand(s, con);
            MySqlDataReader rs = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (rs.Read())
            {
                dataGridView1.Rows.Add(rs[0], rs[1], rs[2], rs[3], rs[4], rs[5]);
            }
            rs.Close();
            con.Close();
        }



        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (txtcls.Text == "" || txtsn.Text == "" || cmbacay.Text == "" || txtupby.Text == "")
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
                string s = "update add_syllabus set cls='" + txtcls.Text + "', sub_name='" + txtsn.Text + "', aca_yr='" + cmbacay.Text + "', up_by='" + txtupby.Text + "', up_file='" + btnupfile.Text + "' where id=" + index + "";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                txtcls.Focus();
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
                string s = "delete from add_syllabus where id=" + index + "";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                txtcls.Focus();
                index = -1;
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = e.RowIndex;
            DataGridViewRow selectrow = dataGridView1.Rows[id];
            index = Convert.ToInt32(selectrow.Cells[0].Value.ToString());
            txtcls.Text = selectrow.Cells[1].Value.ToString();
            txtsn.Text = selectrow.Cells[2].Value.ToString();
            cmbacay.Text = selectrow.Cells[3].Value.ToString();
            txtupby.Text = selectrow.Cells[4].Value.ToString();
            btnupfile.Text = selectrow.Cells[5].Value.ToString();
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
        txtcls.Text = "";
        txtsn.Text = "";
        cmbacay.Text = "";
        txtupby.Text = "";
        btnupfile.Text = "";

    }

        private void add_syllabus_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
