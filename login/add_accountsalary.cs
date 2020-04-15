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
    public partial class add_accountsalary : Form
    {
        data d = new data();
        public static int index = -1;
        public add_accountsalary()
        {
            InitializeComponent();
        }

        private void add_accountsalary_KeyDown(object sender, KeyEventArgs e)
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
            con.Open();
            string s = "select * from add_accountsalary  ORDER BY id DESC";
            MySqlCommand cmd = new MySqlCommand(s, con);
            MySqlDataReader rs = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (rs.Read())
            {
                dataGridView1.Rows.Add(rs[0], rs[1], rs[2], rs[3], rs[4], rs[5], rs[6], rs[7]);
            }
            rs.Close();
            con.Close();
        }
        void clear()
        {
            cmbay.Text = "";
            txteid.Text = "";
            txtn.Text = "";
            txtsacno.Text = "";
            txtbn.Text = "";
            txtifsc.Text = "";
            txtbb.Text = "";
           
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (cmbay.Text == "" || txteid.Text == "" || txtsacno.Text == "" || txtbn.Text == "" || txtifsc.Text == "" || txtbb.Text == "")
            {
                MessageBox.Show("Fill All Details");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(d.getconnection());
                con.Open();
                string s = "insert into add_accountsalary (aca_year,emp_id,emp_n,sal_acno,bank_name,ifsc,bank_branch) values('" + cmbay.Text + "','" + txteid.Text + "', '" + txtn.Text + "','" + txtsacno.Text + "','" + txtbn.Text + "','" + txtifsc.Text + "','" + txtbb.Text + "')";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                cmbay.Focus();
            }
        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (cmbay.Text == "" || txteid.Text == "" || txtsacno.Text == "" || txtbn.Text == "" || txtifsc.Text == "" || txtbb.Text == "")
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
                string s = "update add_accountsalary set aca_year='" + cmbay.Text + "', emp_id='" + txteid.Text + "', emp_n='" + txtn.Text + "', sal_acno='" + txtsacno.Text + "', bank_name='" + txtbn.Text + "', ifsc='" + txtifsc.Text + "', bank_branch='" + txtbb.Text + "' where id=" + index + "";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                load();
                cmbay.Focus();
                index = -1;
                clear();
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
                string s = "delete from add_accountsalary where id=" + index + "";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                cmbay.Focus();
                index = -1;
            }
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
      
       
        private void add_accountsalary_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = e.RowIndex;
            DataGridViewRow selectrow = dataGridView1.Rows[id];
            index = Convert.ToInt32(selectrow.Cells[0].Value.ToString());
            cmbay.Text = selectrow.Cells[1].Value.ToString(); ;
            txteid.Text = selectrow.Cells[2].Value.ToString(); ;
            txtn.Text = selectrow.Cells[3].Value.ToString(); ;
            txtsacno.Text = selectrow.Cells[4].Value.ToString(); ;
            txtbn.Text = selectrow.Cells[5].Value.ToString(); ;
            txtifsc.Text = selectrow.Cells[6].Value.ToString(); ;
            txtbb.Text = selectrow.Cells[7].Value.ToString(); ;
        }
    }
}
