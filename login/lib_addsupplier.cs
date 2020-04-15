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
    public partial class lib_addsupplier : Form
    {
        data d = new data();
        public static int index = -1;
        public lib_addsupplier()
        {
            InitializeComponent();
        }

        private void lib_addsupplier_Load(object sender, EventArgs e)
        {
            load();
        }

        private void lib_addsupplier_KeyDown(object sender, KeyEventArgs e)
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
            if (txtsupname.Text == "" || txtadd.Text == "" ||txtconum.Text == ""||txtemail.Text == ""||txtremark.Text == ""||cmbsuptype.Text=="")
            {
                MessageBox.Show("Fill All Details");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(d.getconnection());
                con.Open();
                string s = "insert into add_sup(s_name,s_type,s_add,s_con,s_email,s_re) values('" + txtsupname.Text + "','" + cmbsuptype.Text + "','" + txtadd.Text + "','" + txtconum.Text + "','" + txtemail.Text + "','" + txtremark.Text + "')";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                txtsupname.Focus();
            }
        }
        public void load()
        {
            MySqlConnection con = new MySqlConnection(d.getconnection());
            //      con.Open();
            con.Open();
            string s = "select * from add_sup ORDER BY id DESC;";
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
            if (txtsupname.Text == "" || txtadd.Text == "" || txtconum.Text == "" || txtemail.Text == "" || txtremark.Text == "" || cmbsuptype.Text == "")
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
                string s = "update add_sup set s_name='" + txtsupname.Text + "',s_type='" + cmbsuptype.Text + "',s_add='" + txtadd.Text + "',s_con='" + txtconum.Text + "',s_email='" + txtemail.Text + "',s_re='" + txtremark.Text + "' where id=" + index + "";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                txtsupname.Focus();
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
                string s = "delete from add_sup where id=" + index + "";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                txtsupname.Focus();
                index = -1;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            clear();
            load();
            txtsupname.Focus();
        }
        void clear()
        {
            txtsupname.Text = "";
            txtadd.Text = "";
          
            txtconum.Text = "";
            txtemail.Text = "";
            txtremark.Text = "";
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dgv1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = e.RowIndex;
            DataGridViewRow selectrow = dgv1.Rows[id];
            index = Convert.ToInt32(selectrow.Cells[0].Value.ToString());
            txtsupname.Text = selectrow.Cells[1].Value.ToString();
            cmbsuptype.Text = selectrow.Cells[2].Value.ToString();
            txtadd.Text = selectrow.Cells[3].Value.ToString();
           
            txtconum.Text = selectrow.Cells[4].Value.ToString();
            txtemail.Text = selectrow.Cells[5].Value.ToString();
            txtremark.Text = selectrow.Cells[6].Value.ToString();
        }
    }
}
