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
    public partial class Add_Subject : Form
    {
        data d = new data();
        public static int index = 0;
        public Add_Subject()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(d.getconnection());
            con.Open();
            string s = "insert into subject_master (sub_name,type) values('" + c_name.Text + "','" + comboBox1.Text + "')";
            MySqlCommand cmd = new MySqlCommand(s, con);
            cmd.ExecuteNonQuery();
            con.Close();
            c_name.Text = "";
          
            load();
        }
        public void load()
        {
            MySqlConnection con = new MySqlConnection(d.getconnection());
            con.Open();
            string s = "select * from subject_master";
            MySqlCommand cmd = new MySqlCommand(s, con);
            MySqlDataReader rs = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (rs.Read())
            {
                dataGridView1.Rows.Add(rs[0], rs[1], rs[2]);
            }
            rs.Close();
            con.Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            c_name.Text = "";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(d.getconnection());
            con.Open();
            string s = "update subject_master set sub_name='" + c_name.Text + "', type='"+comboBox1.Text+"' where id=" + index + "";
            MySqlCommand cmd = new MySqlCommand(s, con);
            cmd.ExecuteNonQuery();
            con.Close();
            c_name.Text = "";
         
            load();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(d.getconnection());
            con.Open();
            string s = "delete from subject_master where id=" + index + "";
            MySqlCommand cmd = new MySqlCommand(s, con);
            cmd.ExecuteNonQuery();
            con.Close();
            c_name.Text = "";
          
            load();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex;
            DataGridViewRow selectrow = dataGridView1.Rows[id];
            index = Convert.ToInt32(selectrow.Cells[0].Value.ToString());
            c_name.Text = selectrow.Cells[1].Value.ToString(); ;
            comboBox1.Text = selectrow.Cells[2].Value.ToString();
        }

        private void Add_Subject_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
