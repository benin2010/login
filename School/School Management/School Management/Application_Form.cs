using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management
{
    public partial class Application_Form : Form
    {
        data d = new data();
        public static int index = 0,a = 0;
        public static string path = "none", ext="",doc1 = "none", doc2 = "none",doc3 = "none", doc4 = "none", ext1 = "", ext2 = "", ext3 = "", ext4 = "";
        public Application_Form()
        {
            InitializeComponent();
        }

        private void Application_Form_Load(object sender, EventArgs e)
        {
            load();
            txtan.Text = sl_no();
        }
        public void load()
        {
            MySqlConnection con = new MySqlConnection(d.getconnection());
            con.Open();
            string s = "select DISTINCT c_name from class_master";
            MySqlCommand cmd = new MySqlCommand(s, con);
            MySqlDataReader rs = cmd.ExecuteReader();
            txtafc.Items.Clear();
            while (rs.Read())
            {
                txtafc.Items.Add(rs.GetValue(0).ToString());
            }
            rs.Close();
            con.Close();
        }
        public string sl_no()
        {
           // int a = 0;
            string a1 = "",a2="";
            MySqlConnection con = new MySqlConnection(d.getconnection());
            con.Open();
            string s = "select * from sl_no";
            MySqlCommand cmd = new MySqlCommand(s, con);
            MySqlDataReader rs = cmd.ExecuteReader();
           // txtafc.Items.Clear();
            if (rs.Read())
            {
                a2 = rs.GetValue(0).ToString();
                a =Convert.ToInt32( rs.GetValue(1).ToString());
            }
            
            rs.Close();
            con.Close();
            a = a + 1;
            a1 = "A" + a2 +"N"+ slno(a.ToString());
            return a1;
        }

        private void btnbc_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pbsp.Image = new Bitmap(open.FileName);
                // image file path  
                doc2 = open.FileName;
                ext2 = Path.GetExtension(open.FileName);

            }
        }

        private void btntc_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pbsp.Image = new Bitmap(open.FileName);
                // image file path  
                doc3 = open.FileName;
                ext3 = Path.GetExtension(open.FileName);

            }
        }

        private void btnms_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pbsp.Image = new Bitmap(open.FileName);
                // image file path  
                doc4 = open.FileName;
                ext4 = Path.GetExtension(open.FileName);

            }
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(path.Equals("none"))
            {
                MessageBox.Show("Please Select Your photo(Right On Top)");
            }
            if (doc1.Equals("none")|| doc2.Equals("none")|| doc3.Equals("none")|| doc4.Equals("none"))
            {
                MessageBox.Show("Please Select Document(Right On Bottom)");
            }
            else if (txtfn.Text == ""||txtmn.Text=="")
            {
                MessageBox.Show("Fill ALL Details");
            }
            else
            {
                
                    MySqlConnection con = new MySqlConnection(d.getconnection());
                con.Open();
                DateTime iDate;
                iDate = dtpdob.Value;
                string s = "insert into stu_master1 values('" + txtan.Text + "','" + txtafc.Text + "','" + txtfn.Text + "','" + txtmn.Text + "','" + txtln.Text + "','" + iDate.ToString() + "','" + txtpob.Text + "','" + cmbg.Text + "','" + txtaan.Text + "','" + cmbn.Text + "','0','0')";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                s = "insert into stu_master2 values('" + txtr.Text + "','" + txtct.Text + "','" + txtcg.Text + "','" + txtmt.Text + "','" + txtlk.Text + "','" + txtbg.Text + "','" + cmbsfr.Text + "','" + rtxtim.Text + "','" + rtxlss.Text + "','" + txtlap.Text + "','" + txtan.Text + "','0')";
                cmd.CommandText = s;
                cmd.ExecuteNonQuery();
                s = "insert into stu_master3 values('" + txtan.Text + "','" + txtfan.Text + "','" + txtfaq.Text + "','" + txtfo.Text + "','" + txtfon.Text + "','" + txtfmn.Text + "','" + txtfei.Text + "','" + txtmon.Text + "','" + txtmaq.Text + "','" + txtmo.Text + "','" + txtmorn.Text + "','" + txtmmn.Text + "','" + txtmei.Text + "','0')";
                cmd.CommandText = s;
                cmd.ExecuteNonQuery();
                s = "insert into stu_master4 values('" + txtan.Text + "','" + rtxtpera.Text + "','" + rtxtpa.Text + "','" + txtan.Text + ext + "','" + txtan.Text+"f_p" + ext1 + "','" + txtan.Text + "b_c" + ext2 + "','" + txtan.Text + "i_p" + ext3 + "','" + txtan.Text + "a_p" + ext4 + "','0')";
                cmd.CommandText = s;
                cmd.ExecuteNonQuery();
                con.Close();
                update_slno();
                File.Copy(@path, @"img\" + txtan.Text + ext);
                File.Copy(@doc1, @"img\" + txtan.Text+"f_b" + ext1);
                File.Copy(@doc2, @"img\" + txtan.Text +"b_c" + ext2);
                File.Copy(@doc3, @"img\" + txtan.Text + "i_p" + ext3);
                File.Copy(@doc4, @"img\" + txtan.Text + "a_p" + ext4);
                doc1 = "none"; doc2 = "none"; doc3 = "none"; doc4 = "none";
                MessageBox.Show("Add Sucessfully");
                path = "none";
                clear();
                txtan.Text = sl_no();
            }
           
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
            txtan.Text = sl_no();
        }

        private void btnp_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pbsp.Image = new Bitmap(open.FileName);
                // image file path  
                doc1 = open.FileName;
                ext1 = Path.GetExtension(open.FileName);

            }
        }

        private void txtmn_Validating(object sender, CancelEventArgs e)
        {
            TextBox cb = (TextBox)sender;
            if (string.IsNullOrEmpty(cb.Text.Trim()))
            {

                errorProvider1.SetError(cb, "Required Field.");
            }
            else
            {
                errorProvider1.SetError(cb, string.Empty);
            }
        }

        private void rtxtim_Validating(object sender, CancelEventArgs e)
        {
            RichTextBox cb = (RichTextBox)sender;
            if (string.IsNullOrEmpty(cb.Text.Trim()))
            {

                errorProvider1.SetError(cb, "Required Field.");
            }
            else
            {
                errorProvider1.SetError(cb, string.Empty);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            clear();
        }

        public string slno(string sl)
        {
            string a1 = "";
            int a = sl.Length;
            if(a==1)
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
                a1 =  sl;
            }
            return a1;
        }
        private void pbsp_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pbsp.Image = new Bitmap(open.FileName);
                // image file path  
                path = open.FileName;
                ext = Path.GetExtension(open.FileName);
               
            }
        }
    }
}
