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
    public partial class lib_addnews : Form
    {
        data d = new data();
        public static int index = -1;
        public static string expect = "0";
        public static int a = 0;
        public lib_addnews()
        {
            InitializeComponent();
        }

        private void lib_addnews_KeyDown(object sender, KeyEventArgs e)
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
            if (txtpapname.Text == "" || dtpdate.Text == "" || cmbstatus.Text == "")
            {
                MessageBox.Show("Fill All Details");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(d.getconnection());
                con.Open();
                string s = "insert into lib_adnews(pap_name,date,status,rem) values('" + txtpapname.Text + "','" + dtpdate.Text + "','" + cmbstatus.Text + "','" + txtremarks.Text + "')";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
               
            }
                
            }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (txtpapname.Text == "" || dtpdate.Text == "" || cmbstatus.Text == "")
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
                string s = "update lib_adnews set pap_name='" + txtpapname.Text + "',date='" + dtpdate.Text + "',status='" + cmbstatus.Text + "',rem='" + txtremarks.Text + "' where id=" + index + "";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                index = -1;


            }
            }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (index.Equals("0"))
            {
                MessageBox.Show("Please Select Delete row");
            }
            else if (index == -1)
            {
                MessageBox.Show("Please Select Delete row");
            }

            else
            {
                MySqlConnection con = new MySqlConnection(d.getconnection());
                con.Open();
                string s = "delete from lib_adnews where id=" + index + "";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                index =-1;
            }

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            clear();
            load();
           
           
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lib_addnews_Load(object sender, EventArgs e)
        {
          
            load();
        }
        public void load()
        {
            MySqlConnection con = new MySqlConnection(d.getconnection());
            //      con.Open();
            con.Open();
            string s = "select * from lib_adnews ORDER BY id DESC;";
            MySqlCommand cmd = new MySqlCommand(s, con);
            MySqlDataReader rs = cmd.ExecuteReader();
            dgv1.Rows.Clear();
            while (rs.Read())
            {
                dgv1.Rows.Add(rs[4],rs[0], rs[1], rs[2], rs[3]);
            }
            rs.Close();
            con.Close();
        }
        void clear()
        {
            txtpapname.Text = "";
            dtpdate.Text = "";
            cmbstatus.Text = "";
            txtremarks.Text = "";
           
        }

        private void dgv1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = e.RowIndex;
            DataGridViewRow selectrow = dgv1.Rows[id];
            index = Convert.ToInt32( selectrow.Cells[0].Value.ToString());
            txtpapname.Text = selectrow.Cells[1].Value.ToString();
            dtpdate.Value = Convert.ToDateTime(selectrow.Cells[2].Value.ToString());
            cmbstatus.Text = selectrow.Cells[3].Value.ToString();
            txtremarks.Text = selectrow.Cells[4].Value.ToString();
          
        }
    }
}
