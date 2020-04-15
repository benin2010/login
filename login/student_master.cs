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
    public partial class student_master : Form
    {
        data d = new data();
        public static int index = 0;
        public static int a = 0;
        List<TableLayoutPanel> listpanal = new List<TableLayoutPanel>();
        public student_master()
        {
            InitializeComponent();
        }
        private void getData(AutoCompleteStringCollection dataCollection)
        {
            // string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();

            string sql = "SELECT DISTINCT c_number1 FROM enq_form where flg='0'";
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
        public void loadaa()
        {
            txtmobnum.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtmobnum.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            getData(DataCollection);
            txtmobnum.AutoCompleteCustomSource = DataCollection;
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblmorn_Click(object sender, EventArgs e)
        {

        }

        private void txtfaq_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {




        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip4_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void student_master_KeyDown(object sender, KeyEventArgs e)
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

        }

        private void toolStripButton19_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton20_Click(object sender, EventArgs e)
        {

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton32_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton28_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton29_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton30_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void admissionform_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click_2(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtaa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmobnum_TextChanged(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection(d.getconnection());
            con.Open();
            string s = "select stu_name,enq_cls,dob,age,gender,f_name,f_profession,m_name,m_profession,c_number1,c_number2,p_add,per_add from enq_form where c_number1 like '" + txtmobnum.Text + "' and flg='0'";
            MySqlCommand cmd = new MySqlCommand(s, con);
            MySqlDataReader rs = cmd.ExecuteReader();
            // txtafc.Items.Clear();
            if (rs.Read())
            {
               txtfn.Text = rs.GetString(0);
                txtcls.Text = rs.GetString(1);

                dtpdob.Value = Convert.ToDateTime(rs.GetString(2));
                nudage.Value = Convert.ToInt32(rs.GetString(3));
                cmbgen.Text = rs.GetString(4);
                txtfname.Text = rs.GetString(5);
                txtfdesg.Text = rs.GetString(6);
                txtmname.Text = rs.GetString(7);
                txtmdesg.Text = rs.GetString(8);
                txtsms.Text = rs.GetString(9);
                txtnum.Text = rs.GetString(10);
                rtxtpadd.Text = rs.GetString(11);
                rtxtperadd.Text = rs.GetString(12);
            }

            rs.Close();
           
            con.Close();
        }

        private void student_master_Load(object sender, EventArgs e)
        {
            listpanal.Add(tableLayoutPanel1);
            listpanal.Add(tableLayoutPanel2);
            listpanal.Add(tableLayoutPanel3);
            listpanal.Add(tableLayoutPanel4);
            listpanal.Add(tableLayoutPanel6);
            loadaa();
            txtadnum.Text = sl_no();
        }
        public string sl_no()
        {
            // int a = 0;
            string a1 = "", a2 = "";
            MySqlConnection con = new MySqlConnection(d.getconnection());
            con.Open();
            string s = "select * from reg_slno";
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
        public void update_slno()
        {
            MySqlConnection con = new MySqlConnection(d.getconnection());
            con.Open();
            string s = "update sl_no set slno='" + a.ToString() + "'";
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
        public bool checkempty_txt()
        {
            bool x = false;
            foreach (Control c in this.tableLayoutPanel2.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        x = true;
                        break;
                    }
                    else
                    {
                        x = false;
                    }
                }
            }
            if(x)
            {

            }
            else
            {
                foreach (Control c in this.tableLayoutPanel3.Controls)
                {
                    if (c is TextBox)
                    {
                        TextBox textBox = c as TextBox;
                        if (textBox.Text == string.Empty)
                        {
                            x = true;
                            break;
                        }
                        else
                        {
                            x = false;
                        }
                    }
                }
                
            }
            if (x)
            {

            }
            else
            {
                foreach (Control c in this.tableLayoutPanel4.Controls)
                {
                    if (c is TextBox)
                    {
                        TextBox textBox = c as TextBox;
                        if (textBox.Text == string.Empty)
                        {
                            x = true;
                            break;
                        }
                        else
                        {
                            x = false;
                        }
                    }
                }

            }
            if (x)
            {

            }
            else
            {
                foreach (Control c in this.tableLayoutPanel1.Controls)
                {
                    if (c is TextBox)
                    {
                        TextBox textBox = c as TextBox;
                        if (textBox.Text == string.Empty)
                        {
                            x = true;
                            break;
                        }
                        else
                        {
                            x = false;
                        }
                    }
                }

            }
            if (x)
            {

            }
            else
            {
                foreach (Control c in this.tableLayoutPanel6.Controls)
                {
                    if (c is TextBox)
                    {
                        TextBox textBox = c as TextBox;
                        if (textBox.Text == string.Empty)
                        {
                            x = true;
                            break;
                        }
                        else
                        {
                            x = false;
                        }
                    }
                }

            }
            return x;
        }
        public bool checkempty_num()
        {
            bool x = false;
            foreach (Control c in this.tableLayoutPanel2.Controls)
            {
                if (c is NumericUpDown)
                {
                    NumericUpDown textBox = c as NumericUpDown;
                    if (textBox.Text == string.Empty)
                    {
                        x = true;
                        break;
                    }
                    else
                    {
                        x = false;
                    }
                }
            }
            if (x)
            {

            }
            else
            {
                foreach (Control c in this.tableLayoutPanel3.Controls)
                {
                    if (c is NumericUpDown)
                    {
                        NumericUpDown textBox = c as NumericUpDown;
                        if (textBox.Text == string.Empty)
                        {
                            x = true;
                            break;
                        }
                        else
                        {
                            x = false;
                        }
                    }
                }

            }
            if (x)
            {

            }
            else
            {
                foreach (Control c in this.tableLayoutPanel4.Controls)
                {
                    if (c is NumericUpDown)
                    {
                        NumericUpDown textBox = c as NumericUpDown;
                        if (textBox.Text == string.Empty)
                        {
                            x = true;
                            break;
                        }
                        else
                        {
                            x = false;
                        }
                    }
                }

            }
            if (x)
            {

            }
            else
            {
                foreach (Control c in this.tableLayoutPanel1.Controls)
                {
                    if (c is NumericUpDown)
                    {
                        NumericUpDown textBox = c as NumericUpDown;
                        if (textBox.Text == string.Empty)
                        {
                            x = true;
                            break;
                        }
                        else
                        {
                            x = false;
                        }
                    }
                }

            }
            if (x)
            {

            }
            else
            {
                foreach (Control c in this.tableLayoutPanel6.Controls)
                {
                    if (c is NumericUpDown)
                    {
                        NumericUpDown textBox = c as NumericUpDown;
                        if (textBox.Text == string.Empty)
                        {
                            x = true;
                            break;
                        }
                        else
                        {
                            x = false;
                        }
                    }
                }

            }
            return x;
        }
        public bool checkempty_rtxt()
        {
            bool x = false;
            foreach (Control c in this.tableLayoutPanel2.Controls)
            {

                if (c is RichTextBox)
                {
                    RichTextBox textBox = c as RichTextBox;
                    if (textBox.Text == string.Empty)
                    {
                        x = true;
                        break;
                    }
                    else
                    {
                        x = false;
                    }
                }
            }
            if (x)
            {

            }
            else
            {
                foreach (Control c in this.tableLayoutPanel3.Controls)
                {
                    if (c is RichTextBox)
                    {
                        RichTextBox textBox = c as RichTextBox;
                        if (textBox.Text == string.Empty)
                        {
                            x = true;
                            break;
                        }
                        else
                        {
                            x = false;
                        }
                    }
                }

            }
            if (x)
            {

            }
            else
            {
                foreach (Control c in this.tableLayoutPanel4.Controls)
                {
                    if (c is RichTextBox)
                    {
                        RichTextBox textBox = c as RichTextBox;
                        if (textBox.Text == string.Empty)
                        {
                            x = true;
                            break;
                        }
                        else
                        {
                            x = false;
                        }
                    }
                }

            }
            if (x)
            {

            }
            else
            {
                foreach (Control c in this.tableLayoutPanel1.Controls)
                {
                    if (c is RichTextBox)
                    {
                        RichTextBox textBox = c as RichTextBox;
                        if (textBox.Text == string.Empty)
                        {
                            x = true;
                            break;
                        }
                        else
                        {
                            x = false;
                        }
                    }
                }

            }
            if (x)
            {

            }
            else
            {
                foreach (Control c in this.tableLayoutPanel6.Controls)
                {
                    if (c is RichTextBox)
                    {
                        RichTextBox textBox = c as RichTextBox;
                        if (textBox.Text == string.Empty)
                        {
                            x = true;
                            break;
                        }
                        else
                        {
                            x = false;
                        }
                    }
                }

            }
            return x;
        }

        private void btn_Add_Click_1(object sender, EventArgs e)
        {
            if(checkempty_txt()||checkempty_num()||checkempty_rtxt())
            {
                MessageBox.Show("Fill All Details");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(d.getconnection());
                con.Open();
                DateTime iDate;
                iDate = dtpdob.Value;
                string s = "insert into stu_gendetails values('" + txtmobnum.Text + "','" + txtcls.Text + "','" + dtpdate.Text + "','" + txtfn.Text + "','" + txtmn.Text + "','" + txtln.Text + "','" + dtpdob.Text + "','" + txtpob.Text + "','" + nudage.Value.ToString() + "','" + cmbgen.Text + "','" + cmbnat.Text + "','" + cmbrel.Text + "','" + txtcast.Text + "','" + cmbcom.Text + "','" + cmbmt.Text + "','" + txtbg.Text + "','" + txtaa.Text + "','" + rtxtidm1.Text + "','" + rtxtidm3.Text + "','" + rtxtidm3.Text + "','" + txtadnum.Text + "','0')";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                s = "insert into stu_famdetails values('" + txtfname.Text + "','" + txtfaca.Text + "','" + txtfoccup.Text + "','" + txtfdesg.Text + "','" + txtfcomp.Text + "','" + cmbtype.Text + "','" + nudfexp.Value.ToString() + "','" + txtfmob.Text + "','" + txtfemail.Text + "','" + txtmname.Text + "','" + txtmaca.Text + "','" + txtmoccup.Text + "','" + txtmdesg.Text + "','" + txtmcomp.Text + "','" + cmbmtype.Text + "','" + nudmexp.Value.ToString() + "','" + txtmmob.Text + "','" + txtmemail.Text + "','" + txtfi.Text + "','" + nudsib.Text + "','" + cmbsibsch.Text + "','" + txtsname1.Text + "','" + cmbsclass1.Text + "','" + txtsreg1.Text + "','" + txtsname2.Text + "','" + cmbsclass2.Text + "','" + txtsreg2.Text + "','" + txtbg.Text + "','" + txtadnum.Text + "','0')";
                cmd.CommandText = s;
                cmd.ExecuteNonQuery();
                s = "insert into stu_condetails values('" + rtxtpadd.Text + "','" + rtxtperadd.Text + "','" + txtdist.Text + "','" + txtnum.Text  +"','" + txtsms.Text + "','" + cmbtran.Text + "','" + txtadnum.Text + "','0')";
                cmd.CommandText = s;
                cmd.ExecuteNonQuery();
                s = "insert into stu_healdetails values('" + txtbmi.Text + "','" + cmbspecs.Text + "','" + cmbhear.Text + "','" + cmbmotor.Text + "','" + rtxtallerg.Text + "','" + txtadnum.Text + "','0')";
                cmd.CommandText = s;
                cmd.ExecuteNonQuery();
                s = "insert into stu_otherdetails values('" + rtxtlsch.Text + "','" + rtxtlschadd.Text + "','" + cmbboard.Text + "','" + txtper.Text + "','" + txttcno.Text + "','" + txtcourse.Text + "','" + rtxttalent.Text + "','" + rtxthob.Text + "','" + rtxtsports.Text + "','" + txtadnum.Text + "','0')";
                cmd.CommandText = s;
                
                con.Close();
                update_slno();
              
                MessageBox.Show("Add Sucessfully");
               
                clear();
                txtadnum.Text = sl_no();
            }
        }
        void clear()
        {
            for (int i = 0; i < listpanal.Count; i++)
            {
                
                foreach (Control c in this.listpanal[i].Controls)
                {
               
                        
                            if (c is TextBox)
                            {
                                TextBox textBox = c as TextBox;
                                textBox.Text = "";

                            }
                       

                   
                }
            }
            for (int i = 0; i < listpanal.Count; i++)
            {

                foreach (Control c in this.listpanal[i].Controls)
                {


                    if (c is NumericUpDown)
                    {
                        NumericUpDown textBox = c as NumericUpDown;
                        textBox.Text = "";

                    }



                }
            }
            for (int i = 0; i < listpanal.Count; i++)
            {

                foreach (Control c in this.listpanal[i].Controls)
                {


                    if (c is RichTextBox)
                    {
                        RichTextBox textBox = c as RichTextBox;
                        textBox.Text = "";

                    }



                }
            }
        }

        private void btn_Refresh_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
