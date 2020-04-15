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
    public partial class enq_form : Form
    {
        data d = new data();
        public static string index ="0" ;
        public static string expect = "0";
        public static int a = 0;
        public enq_form()
        {
            InitializeComponent();
            load_class();
        }

        private void enq_form_KeyDown(object sender, KeyEventArgs e)
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
        public void load_class()
        {
            MySqlConnection con = new MySqlConnection(d.getconnection());
            con.Open();
            string s = "select DISTINCT class_name from class_tb";
            MySqlCommand cmd = new MySqlCommand(s, con);
            MySqlDataReader rs = cmd.ExecuteReader();
            cmbclass.Items.Clear();
            while (rs.Read())
            {
                cmbclass.Items.Add(rs.GetValue(0).ToString());
            }
            rs.Close();
            con.Close();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txtsn.Text == ""|| cmbclass.Text==""|| cmbay.Text==""|| nudage.Value==0|| cmbgen.Text==""|| cmbsch.Text==""|| txtlast.Text==""|| cmbboard.Text==""|| nudper.Value==0|| txtfn.Text==""||txtfp.Text==""||txtmn.Text==""||txtmp.Text==""||txtcn1.Text==""||txtcn2.Text==""||rtxtpadd.Text==""||rtxtperadd.Text==""||txtcoun.Text==""||rtxtcounre.Text=="")
            {
                MessageBox.Show("Fill All Details");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(d.getconnection());
                con.Open();
                string s = "insert into enq_form values('" + nudenqno.Text+ "','" + txtsn.Text + "','" + cmbclass.Text + "','" + dtpe.Text + "','" + cmbay.Text + "','" + dtpdob.Text + "','" + nudage.Value.ToString() + "','" + cmbgen.Text + "','" + cmbsch.Text + "','" + txtlast.Text + "','" + cmbboard.Text + "','" + nudper.Value.ToString() + "','" + txtfn.Text + "','" + txtfp.Text + "','" + txtmn.Text + "','" + txtmp.Text + "','" + txtcn1.Text + "','" + txtcn2.Text + "','" + rtxtpadd.Text + "','" + rtxtperadd.Text + "','" + expect + "','" + txtcoun.Text + "','" + rtxtcounre.Text + "','0')";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                txtsn.Focus();
                update_slno();
                nudenqno.Text = sl_no();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (txtsn.Text == "" || cmbclass.Text == "" || cmbay.Text == "" || nudage.Value == 0 || cmbgen.Text == "" || cmbsch.Text == "" || txtlast.Text == "" || cmbboard.Text == "" || nudper.Value == 0 || txtfn.Text == "" || txtfp.Text == "" || txtmn.Text == "" || txtmp.Text == "" || txtcn1.Text == "" || txtcn2.Text == "" || rtxtpadd.Text == "" || rtxtperadd.Text == "" || txtcoun.Text == "" || rtxtcounre.Text == "")
            {
                MessageBox.Show("Fill All Details");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(d.getconnection());
                con.Open();
                string s = "update enq_form set stu_name='" + txtsn.Text + "',enq_cls='" + cmbclass.Text + "',date_enq='" + dtpe.Text + "',aca_year='" + cmbay.Text + "',dob='" + dtpdob.Text + "',age='" + nudage.Value.ToString() + "',gender='" + cmbgen.Text + "',our_sch='" + cmbsch.Text + "',lss='" + txtlast.Text + "',la_edu='" + cmbboard.Text + "',la_per='" + nudper.Value.ToString() + "',f_name='" + txtfn.Text + "',f_profession='" + txtfn.Text + "', m_name='" + txtmn.Text + "',m_profession='" + txtmp.Text + "',c_number1='" + txtcn1.Text + "',c_number2='" + txtcn2.Text + "',p_add='" + rtxtpadd.Text + "',per_add='" + rtxtperadd.Text + "',expect='" + expect + "',cou_by='" + txtcoun.Text + "',cou_remark='" + rtxtcounre.Text + "' where enq_id='" + index + "'";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                txtsn.Focus();
               
                nudenqno.Text = sl_no();
            }
        }
        public string sl_no()
        {
            // int a = 0;
            string a1 = "", a2 = "";
            MySqlConnection con = new MySqlConnection(d.getconnection());
            con.Open();
            string s = "select * from sl_no";
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
            a1 = "E" + a2 + "N" + slno(a.ToString());
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
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(d.getconnection());
            con.Open();
            string s = "delete from enq_form where enq_id='" + index + "'";
            MySqlCommand cmd = new MySqlCommand(s, con);
            cmd.ExecuteNonQuery();
            con.Close();
            clear();
            load();
            txtsn.Focus();
            nudenqno.Text = sl_no();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            clear();
            load();
            txtsn.Focus();
            nudenqno.Text = sl_no();
        }
        public void load()
        {
            MySqlConnection con = new MySqlConnection(d.getconnection());
            //      con.Open();
            con.Open();
            string s = "select * from enq_form ORDER BY enq_id DESC;";
            MySqlCommand cmd = new MySqlCommand(s, con);
            MySqlDataReader rs = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (rs.Read())
            {
                dataGridView1.Rows.Add(rs[0], rs[1], rs[2], rs[3], rs[4], rs[5], rs[6], rs[7], rs[8], rs[9], rs[10],rs[11], rs[12], rs[13], rs[14], rs[15], rs[16], rs[17], rs[18], rs[19], rs[20], rs[21], rs[22]);
            }
            rs.Close();
            con.Close();
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        void clear()
        {
            txtsn.Text = "";
            cmbclass.Text = "";
            cmbay.Text = "";
            nudage.Value = 0;
            cmbgen.Text = "";
            cmbsch.Text = "";
            txtlast.Text = "";
            cmbboard.Text = "";
            nudper.Value = 0;
            txtfn.Text = "";
            txtfp.Text = "";
            txtmn.Text = "";
            txtmp.Text = "";
            txtcn1.Text = "";
            txtcn2.Text = "";
            rtxtpadd.Text = "";
            rtxtperadd.Text = "";
            txtcoun.Text = "";
            rtxtcounre.Text = "";
        }

        private void enq_form_Load(object sender, EventArgs e)
        {
            nudenqno.Text = sl_no();
            load();
        }

        private void cbg_CheckedChanged(object sender, EventArgs e)
        {
            if(cbg.Checked==true)
            {
                expect = cbg.Text;
            }
        }

        private void cbbt_CheckedChanged(object sender, EventArgs e)
        {
            if (cbbt.Checked == true)
            {
                expect = cbbt.Text;
            }
        }

        private void cblst_CheckedChanged(object sender, EventArgs e)
        {
            if (cblst.Checked == true)
            {
                expect = cblst.Text;
            }
        }

        private void cbec_CheckedChanged(object sender, EventArgs e)
        {
            if (cbec.Checked == true)
            {
                expect = cbec.Text;
            }
        }

        private void cbs_CheckedChanged(object sender, EventArgs e)
        {
            if (cbs.Checked == true)
            {
                expect = cbs.Text;
            }
        }

        private void cbo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbo.Checked == true)
            {
                expect = cbo.Text;
            }
        }

        private void cmbclass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = e.RowIndex;
            DataGridViewRow selectrow = dataGridView1.Rows[id];
            index = selectrow.Cells[0].Value.ToString();
            nudenqno.Text = selectrow.Cells[0].Value.ToString();
            txtsn.Text = selectrow.Cells[1].Value.ToString();
            cmbclass.Text = selectrow.Cells[2].Value.ToString();

            dtpe.Value = Convert.ToDateTime(selectrow.Cells[3].Value.ToString());
            cmbay.Text = selectrow.Cells[4].Value.ToString();
            dtpdob.Value = Convert.ToDateTime(selectrow.Cells[5].Value.ToString());
            nudage.Value = Convert.ToInt32(selectrow.Cells[6].Value.ToString());
            cmbgen.Text = selectrow.Cells[7].Value.ToString();
            cmbsch.Text = selectrow.Cells[8].Value.ToString();
            txtlast.Text = selectrow.Cells[9].Value.ToString();
            cmbboard.Text = selectrow.Cells[10].Value.ToString();
            nudper.Value = Convert.ToInt32(selectrow.Cells[11].Value.ToString());
            txtfn.Text = selectrow.Cells[12].Value.ToString();
            txtfp.Text = selectrow.Cells[13].Value.ToString();
            txtmn.Text = selectrow.Cells[14].Value.ToString();
            txtmp.Text = selectrow.Cells[15].Value.ToString();
            txtcn1.Text = selectrow.Cells[16].Value.ToString();
            txtcn2.Text = selectrow.Cells[17].Value.ToString();
            rtxtpadd.Text = selectrow.Cells[18].Value.ToString();
            rtxtperadd.Text = selectrow.Cells[19].Value.ToString();
            expect = selectrow.Cells[20].Value.ToString();
            txto.Text = expect;
            txtcoun.Text = selectrow.Cells[21].Value.ToString();
            rtxtcounre.Text = selectrow.Cells[22].Value.ToString();
        }
    }
}
