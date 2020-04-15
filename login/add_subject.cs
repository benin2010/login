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
    public partial class add_subject : Form
    {
        data d = new data();
        public static int index = -1;
        public add_subject()
        {
            InitializeComponent();
        }

        private void subject_add_KeyDown(object sender, KeyEventArgs e)
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
            if (txtsub.Text == "" || cmbsubtype.Text == "")
            {
                MessageBox.Show("Please Fill All Data");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(d.getconnection());
                con.Open();
                string s = "insert into subject_master (sub_name,type) values('" + txtsub.Text + "','" + cmbsubtype.Text + "')";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                txtsub.Text = "";

                load();
                txtsub.Focus();
            }
        }
        public void load()
        {
            MySqlConnection con = new MySqlConnection(d.getconnection());
            con.Open();
            string s = "select * from subject_master  ORDER BY id DESC";
            MySqlCommand cmd = new MySqlCommand(s, con);
            MySqlDataReader rs = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (rs.Read())
            {
                dataGridView1.Rows.Add(rs[0], rs[1], rs[2]);
            }
            rs.Close();
            con.Close();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (txtsub.Text == "" || cmbsubtype.Text == "")
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
                string s = "update subject_master set sub_name='" + txtsub.Text + "', type='" + cmbsubtype.Text + "' where id=" + index + "";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                txtsub.Text = "";
                index = -1;
                load();
                txtsub.Focus();
                clear();
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
            string s = "delete from subject_master where id=" + index + "";
            MySqlCommand cmd = new MySqlCommand(s, con);
            cmd.ExecuteNonQuery();
            con.Close();
            txtsub.Text = "";
            clear();
            load();
            txtsub.Focus();
            index = -1;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            clear();

            load();
            txtsub.Focus();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex;
            DataGridViewRow selectrow = dataGridView1.Rows[id];
            index = Convert.ToInt32(selectrow.Cells[0].Value.ToString());
            txtsub.Text = selectrow.Cells[1].Value.ToString(); ;
            cmbsubtype.Text = selectrow.Cells[2].Value.ToString();
        }

        private void subject_add_Load(object sender, EventArgs e)
        {
            load();
        }

        private void c_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator8_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator3_Click(object sender, EventArgs e)
        {

        }
        void clear()
        {
            txtsub.Text = "";
            cmbsubtype.Text = "";

        }
    }
}
