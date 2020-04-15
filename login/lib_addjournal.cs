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
    public partial class lib_addjournal : Form
    {
        data d = new data();
        public static string index = "0";
        public static string expect = "0";
        public static int a = 0;
        public lib_addjournal()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }

        private void lib_addjournal_KeyDown(object sender, KeyEventArgs e)
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
            if (txtjnno.Text == "" || txttitle.Text == "" || txtvolume.Text == "" || txtdepart.Text == "" || txtsubno.Text == "" || dtpsubdate.Text == "" || dtpfdate.Text == "" || dtptdate.Text == "" || txtbar.Text == "" || txtsupname.Text == "" || txtlib.Text == "")
            {
                MessageBox.Show("Fill All Details");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(d.getconnection());
                con.Open();
                string s = "insert into lib_adjournal values('" + txtjnno.Text + "','" + txttitle.Text + "','" + txtvolume.Text + "','" + txtdepart.Text + "','" + txtsubno.Text + "','" + dtpsubdate.Text + "','" + dtpfdate.Text + "','" + dtptdate.Text + "','" + txtrem.Text + "','" + txtbar.Text + "','" + txtsupname.Text + "','" + txtbillno.Text + "','" + dtpbilldate.Text + "','" + txtamount.Text + "','" + txtlib.Text + "')";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                update_slno();
                txtjnno.Text = sl_no();
                txttitle.Focus();
              
               
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (txtjnno.Text == "" || txttitle.Text == "" || txtvolume.Text == "" || txtdepart.Text == "" || txtsubno.Text == "" || dtpsubdate.Text == "" || dtpfdate.Text == "" || dtptdate.Text == "" || txtbar.Text == "" || txtsupname.Text == "" || txtlib.Text == "")
            {
                MessageBox.Show("Fill All Details");
            }
            else if (index.Equals("0"))
            {
                MessageBox.Show("Please Select Update row");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(d.getconnection());
                con.Open();
                string s = "update lib_adjournal set title='" + txttitle.Text + "',volu='" + txtvolume.Text + "',depart='" + txtdepart.Text + "',sub_no='" + txtsubno.Text + "',sub_date='" + dtpsubdate.Text + "',sub_from='" + dtpfdate.Text + "',sub_to='" + dtptdate.Text + "',rema='" + txtlib.Text + "',barcode='" + txtbar.Text + "',sup_name='" + txtsupname.Text + "',bill_no='" + txtbillno.Text + "',bill_date='" + dtpbilldate.Text + "', price='" + txtamount.Text + "',lib_name='" + txtlib.Text + "' where journal_no='" + index + "'";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                txttitle.Focus();
                txtjnno.Text = sl_no();
                index = "0";

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (index.Equals("0"))
            {
                MessageBox.Show("Please Select Delete row");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(d.getconnection());
                con.Open();
                string s = "delete from lib_adjournal where journal_no='" + index + "'";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                txttitle.Focus();
                txtjnno.Text = sl_no();
                index = "0";
            }

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            clear();
            load();
            txttitle.Focus();
            txtjnno.Text = sl_no();
            index = "0";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           // this.Close();

        }
        public string sl_no()
        {
            // int a = 0;
            string a1 = "", a2 = "";
            MySqlConnection con = new MySqlConnection(d.getconnection());
            con.Open();
            string s = "select * from book_sl";
            MySqlCommand cmd = new MySqlCommand(s, con);
            MySqlDataReader rs = cmd.ExecuteReader();
            // txtafc.Items.Clear();
            if (rs.Read())
            {
                a2 = rs.GetValue(0).ToString();
                a = Convert.ToInt32(rs.GetValue(1).ToString());
            }

            rs.Close();
            con.Close();
            a = a + 1;
            a1 = "J" + "N" + slno(a.ToString());
            return a1;
        }
        public void update_slno()
        {
            MySqlConnection con = new MySqlConnection(d.getconnection());
            con.Open();
            string s = "update book_sl set slno='" + a.ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(s, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public string slno(string sl)
        {
            string a1 = "";
            int a = sl.Length;
            if (a == 1)
            {
                a1 = "000" + sl;
            }
            else if (a == 2)
            {
                a1 = "00" + sl;
            }
            else if (a == 3)
            {
                a1 = "0" + sl;
            }
            else if (a == 4)
            {
                a1 = sl;
            }
            return a1;
        }
        public void load()
        {
            MySqlConnection con = new MySqlConnection(d.getconnection());
            //      con.Open();
            con.Open();
            string s = "select * from lib_adjournal ORDER BY journal_no DESC;";
            MySqlCommand cmd = new MySqlCommand(s, con);
            MySqlDataReader rs = cmd.ExecuteReader();
            dgv1.Rows.Clear();
            while (rs.Read())
            {
                dgv1.Rows.Add(rs[0], rs[1], rs[2], rs[3], rs[4], rs[5], rs[6], rs[7], rs[8], rs[9], rs[10], rs[11], rs[12], rs[13], rs[14]);
            }
            rs.Close();
            con.Close();
        }

        private void lib_addbook_Load(object sender, EventArgs e)
        {
          
            txtjnno.Text = sl_no();
            load();
        }
       


        private void getData(AutoCompleteStringCollection dataCollection, string tble, string fild)
        {
            // string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();

            string sql = "SELECT DISTINCT " + fild + " FROM " + tble;
            connection = new MySqlConnection(d.getconnection());
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dataCollection.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
        void clear()
        {
            txtjnno.Text = "";
            txttitle.Text = "";
            txtvolume.Text = "";
            txtdepart.Text = "";
            txtsubno.Text = "";
            dtpsubdate.Text = "";
            dtpfdate.Text = "";
            dtptdate.Text = "";
            txtrem.Text = "";
            txtbar.Text = "";
            txtsupname.Text = "";
            txtbillno.Text = "";
            dtpbilldate.Text = "";
            txtamount.Text = "";
            txtlib.Text = "";
           
        }

        private void dgv1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = e.RowIndex;
            DataGridViewRow selectrow = dgv1.Rows[id];
            index = selectrow.Cells[0].Value.ToString();
            txtjnno.Text = selectrow.Cells[0].Value.ToString();
            txttitle.Text = selectrow.Cells[1].Value.ToString();
            txtvolume.Text = selectrow.Cells[2].Value.ToString();
            txtdepart.Text = selectrow.Cells[3].Value.ToString();
            txtsubno.Text = selectrow.Cells[4].Value.ToString();
            dtpsubdate.Value = Convert.ToDateTime(selectrow.Cells[5].Value.ToString());
            dtpfdate.Value = Convert.ToDateTime(selectrow.Cells[6].Value.ToString());
            dtptdate.Value = Convert.ToDateTime(selectrow.Cells[7].Value.ToString());
            txtrem.Text = selectrow.Cells[8].Value.ToString();
            txtbar.Text = selectrow.Cells[9].Value.ToString();
            txtsupname.Text = selectrow.Cells[10].Value.ToString();
            txtbillno.Text = selectrow.Cells[11].Value.ToString();
            dtpbilldate.Value = Convert.ToDateTime(selectrow.Cells[12].Value.ToString());
            txtamount.Text = selectrow.Cells[13].Value.ToString();
            txtlib.Text = selectrow.Cells[14].Value.ToString();
        }

        private void lib_addjournal_Load(object sender, EventArgs e)
        {
            
            txtjnno.Text = sl_no();
            load();
        }

        private void dgv1_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = e.RowIndex;
            DataGridViewRow selectrow = dgv1.Rows[id];
            index = selectrow.Cells[0].Value.ToString();
            txtjnno.Text = selectrow.Cells[0].Value.ToString();
            txttitle.Text = selectrow.Cells[1].Value.ToString();
            txtvolume.Text = selectrow.Cells[2].Value.ToString();
            txtdepart.Text = selectrow.Cells[3].Value.ToString();
            txtsubno.Text = selectrow.Cells[4].Value.ToString();
            dtpsubdate.Value = Convert.ToDateTime(selectrow.Cells[5].Value.ToString());
            dtpfdate.Value = Convert.ToDateTime(selectrow.Cells[6].Value.ToString());
            dtptdate.Value = Convert.ToDateTime(selectrow.Cells[7].Value.ToString());
            txtrem.Text = selectrow.Cells[8].Value.ToString();
            txtbar.Text = selectrow.Cells[9].Value.ToString();
            txtsupname.Text = selectrow.Cells[10].Value.ToString();
            txtbillno.Text = selectrow.Cells[11].Value.ToString();
            dtpbilldate.Value = Convert.ToDateTime(selectrow.Cells[12].Value.ToString());
            txtamount.Text = selectrow.Cells[13].Value.ToString();
            txtlib.Text = selectrow.Cells[14].Value.ToString();
        }
    }
}
