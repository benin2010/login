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

namespace School_Management
{
    public partial class Approval_form : Form
    {
        data d = new data();
        public static int index = 0, a = 0;
        public Approval_form()
        {
            InitializeComponent();
        }

        private void Approval_form_Load(object sender, EventArgs e)
        {
            loaddt();
            loadaa();
        }
        public void loaddt()
        {
            txtan.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtan.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            getData(DataCollection);
            txtan.AutoCompleteCustomSource = DataCollection;
        }
        public void loadaa()
        {
            txtaan.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtaan.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            getData_aa(DataCollection);
            txtaan.AutoCompleteCustomSource = DataCollection;
        }
        private void getData_aa(AutoCompleteStringCollection dataCollection)
        {
            // string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();

            string sql = "SELECT DISTINCT txtaan FROM stu_master1 where RegNo='0'";
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
        private void getData(AutoCompleteStringCollection dataCollection)
        {
           // string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
           
            string sql = "SELECT DISTINCT txtan FROM stu_master1 where RegNo='0'";
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

        private void txtan_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(d.getconnection());
            con.Open();
            string s = "select * from stu_master1 where txtan like '"+txtan.Text+ "' and RegNo='0'";
            MySqlCommand cmd = new MySqlCommand(s, con);
            MySqlDataReader rs = cmd.ExecuteReader();
            // txtafc.Items.Clear();
            if (rs.Read())
            {
                txtafc.Text =rs.GetString(1);
                txtfn.Text = rs.GetString(2);
                txtmn.Text = rs.GetString(3);
                txtln.Text = rs.GetString(4);
              dtpdob.Text= rs.GetString(5);
                txtpob.Text = rs.GetString(6);
                cmbg.Text = rs.GetString(7);
                txtaan.Text = rs.GetString(8);
                cmbn.Text = rs.GetString(9);
            }

            rs.Close();
            s = "select * from stu_master2 where txtan like '" + txtan.Text + "' and RegNo='0'";
            cmd.CommandText = s;
           rs = cmd.ExecuteReader();
            // txtafc.Items.Clear();
            if (rs.Read())
            {


                txtr.Text = rs.GetString(0);
                txtct.Text = rs.GetString(1); 
                txtcg.Text = rs.GetString(2);
                txtmt.Text = rs.GetString(3);
                txtlk.Text = rs.GetString(4);
                txtbg.Text = rs.GetString(5);
                cmbsfr.Text = rs.GetString(6);
                rtxtim.Text = rs.GetString(7);
                rtxlss.Text = rs.GetString(8);
                txtlap.Text = rs.GetString(9);

            }
            rs.Close();
            s = "select * from stu_master3 where txtan like '" + txtan.Text + "' and RegNo='0'";
            cmd.CommandText = s;
            rs = cmd.ExecuteReader();
            // txtafc.Items.Clear();
            if (rs.Read())
            {


               
                txtfan.Text = rs.GetString(1);
                txtfaq.Text = rs.GetString(2);
                txtfo.Text = rs.GetString(3);
                txtfon.Text = rs.GetString(4);
                txtfmn.Text = rs.GetString(5);
                txtfei.Text = rs.GetString(6);
                txtmon.Text = rs.GetString(7);
                txtmaq.Text = rs.GetString(8);
                txtmo.Text = rs.GetString(9);
                txtmorn.Text = rs.GetString(10);
                txtmmn.Text = rs.GetString(11);
                txtmei.Text = rs.GetString(12);

            }
            rs.Close();
            s = "select * from stu_master3 where txtan like '" + txtan.Text + "' and RegNo='0'";
            cmd.CommandText = s;
            rs = cmd.ExecuteReader();
            // txtafc.Items.Clear();
            if (rs.Read())
            {



               
                rtxtpera.Text = rs.GetString(1);
                rtxtpa.Text = rs.GetString(2);
                try
                {
                    pbsp.Image = new Bitmap(@"img\" + rs.GetString(3));
                }
                catch(Exception ex)
                {
                    pbsp.Image= new Bitmap(@"img\images.png");
                }
            }
            
            rs.Close();
            con.Close();
        }

        private void txtaan_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(d.getconnection());
            con.Open();
            string s = "select * from stu_master1 where txtaan like '" + txtaan.Text + "' and RegNo='0'";
            MySqlCommand cmd = new MySqlCommand(s, con);
            MySqlDataReader rs = cmd.ExecuteReader();
            // txtafc.Items.Clear();
            if (rs.Read())
            {
                txtan.Text = rs.GetString(0);
                txtafc.Text = rs.GetString(1);
                txtfn.Text = rs.GetString(2);
                txtmn.Text = rs.GetString(3);
                txtln.Text = rs.GetString(4);
                dtpdob.Text = rs.GetString(5);
                txtpob.Text = rs.GetString(6);
                cmbg.Text = rs.GetString(7);
               // txtaan.Text = rs.GetString(8);
                cmbn.Text = rs.GetString(9);
            }

            rs.Close();
            s = "select * from stu_master2 where txtan like '" + txtan.Text + "' and RegNo='0'";
            cmd.CommandText = s;
            rs = cmd.ExecuteReader();
            // txtafc.Items.Clear();
            if (rs.Read())
            {


                txtr.Text = rs.GetString(0);
                txtct.Text = rs.GetString(1);
                txtcg.Text = rs.GetString(2);
                txtmt.Text = rs.GetString(3);
                txtlk.Text = rs.GetString(4);
                txtbg.Text = rs.GetString(5);
                cmbsfr.Text = rs.GetString(6);
                rtxtim.Text = rs.GetString(7);
                rtxlss.Text = rs.GetString(8);
                txtlap.Text = rs.GetString(9);

            }
            rs.Close();
            s = "select * from stu_master3 where txtan like '" + txtan.Text + "' and RegNo='0'";
            cmd.CommandText = s;
            rs = cmd.ExecuteReader();
            // txtafc.Items.Clear();
            if (rs.Read())
            {



                txtfan.Text = rs.GetString(1);
                txtfaq.Text = rs.GetString(2);
                txtfo.Text = rs.GetString(3);
                txtfon.Text = rs.GetString(4);
                txtfmn.Text = rs.GetString(5);
                txtfei.Text = rs.GetString(6);
                txtmon.Text = rs.GetString(7);
                txtmaq.Text = rs.GetString(8);
                txtmo.Text = rs.GetString(9);
                txtmorn.Text = rs.GetString(10);
                txtmmn.Text = rs.GetString(11);
                txtmei.Text = rs.GetString(12);

            }
            rs.Close();
            s = "select * from stu_master3 where txtan like '" + txtan.Text + "' and RegNo='0'";
            cmd.CommandText = s;
            rs = cmd.ExecuteReader();
            // txtafc.Items.Clear();
            if (rs.Read())
            {




                rtxtpera.Text = rs.GetString(1);
                rtxtpa.Text = rs.GetString(2);
                try
                {
                    pbsp.Image = new Bitmap(@"img\" + rs.GetString(3));
                }
                catch (Exception ex)
                {
                    pbsp.Image = new Bitmap(@"img\images.png");
                }
            }

            rs.Close();
            con.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(d.getconnection());
            con.Open();
            string s = "update stu_master1 set RegNo='"+txtrn.Text+ "',Devision='"+txts.Text+"' where txtan= '" + txtan.Text + "' and RegNo='0'";
            MySqlCommand cmd = new MySqlCommand(s, con);
            cmd.ExecuteNonQuery();
            update_slno();
            clear();
        }
        public string sl_no()
        {
            // int a = 0;
            string a1 = "", a2 = "";
            MySqlConnection con = new MySqlConnection(d.getconnection());
            con.Open();
            string s = "select * from sl_no_reg";
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
            a1 = "R" + a2 + "N" + slno(a.ToString());
            return a1;
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

        private void button1_Click(object sender, EventArgs e)
        {
        txtrn.Text=sl_no();
        }
        public void update_slno()
        {
            MySqlConnection con = new MySqlConnection(d.getconnection());
            con.Open();
            string s = "update sl_no_reg set slno='" + a.ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(s, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tlp3_Paint(object sender, PaintEventArgs e)
        {

        }

        public void clear()
        {
            txtan.Text = "";
            txtafc.Text = "";
            txtfn.Text = "";
            txtmn.Text = "";
            txtln.Text = "";
            txtpob.Text = "";
            cmbg.Text = "";
            txtaan.Text = "";
            cmbn.Text = "";
            txtr.Text = "";
            txtct.Text = "";
            txtcg.Text = "";
            txtmt.Text = "";
            txtlk.Text = "";
            txtbg.Text = "";
            cmbsfr.Text = "";
            rtxtim.Text = "";
            rtxlss.Text = "";
            txtlap.Text = "";
            txtfan.Text = ""; txtfaq.Text = ""; txtfo.Text = ""; txtfon.Text = ""; txtfmn.Text = "";
            txtfei.Text = ""; txtmon.Text = ""; txtmaq.Text = ""; txtmo.Text = ""; txtmorn.Text = "";
            txtmmn.Text = ""; txtmei.Text = "";
            rtxtpera.Text = ""; rtxtpa.Text = "";
            txtan.Text = "";
            txtrn.Text = "";
            txts.Text = "";
            dtpd.Text = "";
        }
    }
}
