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
    public partial class lib_addbook : Form
    {
        data d = new data();
        public static string index = "0";
        public static string expect = "0";
        public static int a = 0;
        public lib_addbook()
        {
            InitializeComponent();
        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void lib_addbook_KeyDown(object sender, KeyEventArgs e)
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
            if (txtacno.Text == "" || txtbtitle.Text == "" || txtauthor.Text == "" || txtdep.Text == "" || txtisbn.Text == "" || txtedit.Text  == "" || txtpub.Text == "" || txtpuby.Text == "" || txtbtype.Text == "" || cmbcd.Text == "" || txtnoofbook.Text == "" || txtsupname.Text == "" || dtpbdate.Text == "" || txtbar.Text == "" || txtano.Text == "" || txtaposition.Text == "" || txtlib.Text == "")
            {
                MessageBox.Show("Fill All Details");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(d.getconnection());
                con.Open();
                string s = "insert into lib_adbook values('" + txtacno.Text + "','" + txtbtitle.Text + "','" + txtauthor.Text + "','" + txtjauthor.Text + "','" + txtdep.Text + "','" + txtisbn.Text + "','" + txtedit.Text + "','" + txtpub.Text + "','" + txtpuby.Text + "','" + txtvolu.Text + "','" + txtbtype.Text + "','" + cmbcd.Text + "','" + txtnoofbook.Text + "','" + txtsupname.Text + "','" + dtpbdate.Text + "','" + txtpric.Text + "','" + txtbar.Text + "','" + txtrem.Text + "','" + txtano.Text + "','" + txtaposition.Text + "','" + txtlib.Text + "')";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
               clear();
               load();
                update_slno();
                txtacno.Text = sl_no();
               txtbtitle.Focus();
                
                
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (txtacno.Text == "" || txtbtitle.Text == "" || txtauthor.Text == "" || txtdep.Text == "" || txtisbn.Text == "" || txtedit.Text == "" || txtpub.Text == "" || txtpuby.Text == "" || txtbtype.Text == "" || cmbcd.Text == "" || txtnoofbook.Text == "" || txtsupname.Text == "" || dtpbdate.Text == "" || txtbar.Text == "" || txtano.Text == "" || txtaposition.Text == "" || txtlib.Text == "")
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
                string s = "update lib_adbook set b_title='" + txtbtitle.Text + "',author='" + txtauthor.Text + "',j_author='" + txtjauthor.Text + "',depart='" + txtdep.Text + "',isbn='" + txtisbn.Text + "',edi='" + txtedit.Text + "',pub='" + txtpub.Text + "',pub_year='" + txtpuby.Text + "',volume='" + txtvolu.Text + "', book_type='" + txtbtype.Text + "',cd_avail='" + cmbcd.Text + "',n_book='" + txtnoofbook.Text + "',sup_name='" + txtsupname.Text + "',bill_date='" + dtpbdate.Text + "',price='" + txtpric.Text + "',bar='" + txtbar.Text + "',rem='" + txtrem.Text + "',almira_no='" + txtano.Text + "', almira_position='" + txtaposition.Text + "', u_lib ='" + txtlib.Text + "' where access_no='" + index + "'";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                txtbtitle.Focus();
                txtacno.Text = sl_no();
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
                string s = "delete from lib_adbook where access_no='" + index + "'";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                txtbtitle.Focus();
                txtacno.Text = sl_no();
                index = "0";
            }
            
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            {
                clear();
                load();
                txtbtitle.Focus();
               
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtacno_TextChanged(object sender, EventArgs e)
        {

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
            a1 = "L" + "B" + slno(a.ToString());
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
            string s = "select * from lib_adbook ORDER BY access_no DESC;";
            MySqlCommand cmd = new MySqlCommand(s, con);
            MySqlDataReader rs = cmd.ExecuteReader();
            dgv1.Rows.Clear();
            while (rs.Read())
            {
                dgv1.Rows.Add(rs[0], rs[1], rs[2], rs[3], rs[4], rs[5], rs[6], rs[7], rs[8], rs[9], rs[10], rs[11], rs[12], rs[13], rs[14], rs[15], rs[16], rs[17], rs[18], rs[19], rs[20]);
            }
            rs.Close();
            con.Close();
        }

        private void lib_addbook_Load(object sender, EventArgs e)
        {
            loaddt();
            txtacno.Text = sl_no();
            load();
        }
        public void loaddt()
        {
            txtauthor.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtauthor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            getData(DataCollection, "add_aut", "au_na");
            txtauthor.AutoCompleteCustomSource = DataCollection;

            txtjauthor.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtjauthor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection1 = new AutoCompleteStringCollection();
            getData(DataCollection1, "add_aut", "au_na");
            txtjauthor.AutoCompleteCustomSource = DataCollection1;

            txtdep.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtdep.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection2 = new AutoCompleteStringCollection();
            getData(DataCollection2, "add_ldept","dept");
            txtdep.AutoCompleteCustomSource = DataCollection2;

            txtpub.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtpub.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection3 = new AutoCompleteStringCollection();
            getData(DataCollection3, "add_pub","pub_name");
            txtpub.AutoCompleteCustomSource = DataCollection3;

            txtpuby.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtpuby.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection4 = new AutoCompleteStringCollection();
            getData(DataCollection4, "add_pub", "y_pub");
            txtpuby.AutoCompleteCustomSource = DataCollection4;

            txtbtype.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtbtype.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection5 = new AutoCompleteStringCollection();
            getData(DataCollection5, "add_btype", "type");
            txtbtype.AutoCompleteCustomSource = DataCollection5;

            txtsupname.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtsupname.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection6 = new AutoCompleteStringCollection();
            getData(DataCollection6, "add_sup", "s_name");
            txtsupname.AutoCompleteCustomSource = DataCollection6;

            txtano.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtano.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection7 = new AutoCompleteStringCollection();
            getData(DataCollection7, "add_loc", "al_no");
            txtano.AutoCompleteCustomSource = DataCollection7;

            txtaposition.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtaposition.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection8 = new AutoCompleteStringCollection();
            getData(DataCollection8, "add_loc", "al_po");
            txtaposition.AutoCompleteCustomSource = DataCollection8;

            txtlib.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtlib.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection9 = new AutoCompleteStringCollection();
            getData(DataCollection9, "add_lstaff", "staff");
            txtlib.AutoCompleteCustomSource = DataCollection9;
        }
      
       

        private void getData(AutoCompleteStringCollection dataCollection,string tble,string fild)
        {
            // string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();

            string sql = "SELECT DISTINCT "+fild+" FROM "+tble;
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
            txtacno.Text = "";
            txtbtitle.Text = "";
            txtauthor.Text = "";
            txtjauthor.Text = "";
            txtdep.Text = "";
            txtisbn.Text = "";
            txtedit.Text = "";
            txtpub.Text = "";
            txtpuby.Text = "";
            txtvolu.Text = "";
            txtbtype.Text = "";
            cmbcd.Text = "";
            txtnoofbook.Text = "";
            txtsupname.Text = "";
            dtpbdate.Text = "";
            txtpric.Text = "";
            txtbar.Text = "";
            txtrem.Text = "";
            txtano.Text = "";
            txtaposition.Text = "";
            txtlib.Text = "";
            
        }

        private void dgv1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = e.RowIndex;
            DataGridViewRow selectrow = dgv1.Rows[id];
            index = selectrow.Cells[0].Value.ToString();
            txtacno.Text = selectrow.Cells[0].Value.ToString();
            txtbtitle.Text = selectrow.Cells[1].Value.ToString();
            txtauthor.Text = selectrow.Cells[2].Value.ToString();
            txtjauthor.Text = selectrow.Cells[3].Value.ToString();
            txtdep.Text = selectrow.Cells[4].Value.ToString();
            txtisbn.Text = selectrow.Cells[5].Value.ToString();
            txtedit.Text = selectrow.Cells[6].Value.ToString();
            txtpub.Text = selectrow.Cells[7].Value.ToString();
            txtpuby.Text = selectrow.Cells[8].Value.ToString();
            txtvolu.Text = selectrow.Cells[9].Value.ToString();
            txtbtype.Text = selectrow.Cells[10].Value.ToString();
            cmbcd.Text = selectrow.Cells[11].Value.ToString();
            txtnoofbook.Text = selectrow.Cells[12].Value.ToString();
            txtsupname.Text = selectrow.Cells[13].Value.ToString();
            dtpbdate.Value = Convert.ToDateTime(selectrow.Cells[14].Value.ToString());
            txtpric.Text = selectrow.Cells[15].Value.ToString();
            txtbar.Text = selectrow.Cells[16].Value.ToString();
            txtrem.Text = selectrow.Cells[17].Value.ToString();
            txtano.Text = selectrow.Cells[18].Value.ToString();
            txtaposition.Text = selectrow.Cells[19].Value.ToString();
            txtlib.Text = selectrow.Cells[20].Value.ToString();
            }
    }
}
