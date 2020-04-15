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
    public partial class add_salarypercent : Form
    {
        data d = new data();
        public static int index = -1;
        public add_salarypercent()
        {
            InitializeComponent();
        }

        private void add_salarypercent_KeyDown(object sender, KeyEventArgs e)
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
            string s = "select * from add_salarypercent  ORDER BY id DESC";
            MySqlCommand cmd = new MySqlCommand(s, con);
            MySqlDataReader rs = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (rs.Read())
            {
                dataGridView1.Rows.Add(rs[0], rs[1], rs[2], rs[3], rs[4], rs[5], rs[6], rs[7], rs[8], rs[9], rs[10], rs[11], rs[12], rs[13]);
            }
            rs.Close();
            con.Close();
        }
        void clear()
        {
            cmbay.Text = "";
            txtdesig.Text = "";
            txtbs.Text = "";
            txthra.Text = "";
            txtda.Text = "";
            txtca.Text = "";
            txtma.Text = "";
            txtdina.Text = "";
            txtot.Text = "";
            txtpt.Text = "";
            txtpf.Text = "";
            txtesi.Text = "";
            txttds.Text = "";
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (cmbay.Text == "" || txtdesig.Text == "" || txthra.Text == "" || txtda.Text == "" || txtca.Text == "" || txtma.Text == "" || txtdina.Text == "" || txtot.Text == "" || txtpt.Text == "" || txtpf.Text == "" || txtesi.Text == "" || txttds.Text == "")
            {
                MessageBox.Show("Fill All Details");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(d.getconnection());
                con.Open();
                string s = "insert into add_salarypercent (aca_year,desig,basic_s,hra,da,ca,ma,dina,ot,pt,pf,esi,tds) values('" + cmbay.Text + "','" + txtdesig.Text + "','" + txtbs.Text + "','" + txthra.Text + "','" + txtda.Text + "','" + txtca.Text + "','" + txtma.Text + "','" + txtdina.Text + "','" + txtot.Text + "','" + txtpt.Text + "','" + txtpf.Text + "','" + txtesi.Text + "','" + txttds.Text + "')";
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
            if (cmbay.Text == "" || txtdesig.Text == "" || txthra.Text == "" || txtda.Text == "" || txtca.Text == "" || txtma.Text == "" || txtdina.Text == "" || txtot.Text == "" || txtpt.Text == "" || txtpf.Text == "" || txtesi.Text == "" || txttds.Text == "")
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
                string s = "update add_salarypercent set aca_year='" + cmbay.Text + "', desig='" + txtdesig.Text + "', basic_s='" + txtbs.Text + "', hra='" + txthra.Text + "', da='" + txtda.Text + "', ca='" + txtca.Text + "', ma='" + txtma.Text + "', dina='" + txtdina.Text + "', ot='" + txtot.Text + "', pt='" + txtpt.Text + "', pf='" + txtpf.Text + "', esi='" + txtesi.Text + "', tds='" + txttds.Text + "' where id=" + index + "";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                load();
                cmbay.Focus();
                clear();
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
                string s = "delete from add_salarypercent where id=" + index + "";
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
       
        
       

        private void dataGridView1_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = e.RowIndex;
            DataGridViewRow selectrow = dataGridView1.Rows[id];
            index = Convert.ToInt32(selectrow.Cells[0].Value.ToString());
            cmbay.Text = selectrow.Cells[1].Value.ToString(); ;
            txtdesig.Text = selectrow.Cells[2].Value.ToString(); ;
            txtbs.Text = selectrow.Cells[3].Value.ToString(); ;
            txthra.Text = selectrow.Cells[4].Value.ToString(); ;
            txtda.Text = selectrow.Cells[5].Value.ToString(); ;
            txtca.Text = selectrow.Cells[6].Value.ToString(); ;
            txtma.Text = selectrow.Cells[7].Value.ToString(); ;
            txtdina.Text = selectrow.Cells[8].Value.ToString(); ;
            txtot.Text = selectrow.Cells[9].Value.ToString(); ;
            txtpt.Text = selectrow.Cells[10].Value.ToString(); ;
            txtpf.Text = selectrow.Cells[11].Value.ToString(); ;
            txtesi.Text = selectrow.Cells[12].Value.ToString(); ;
            txttds.Text = selectrow.Cells[13].Value.ToString(); ;

        }

        private void add_salarypercent_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
