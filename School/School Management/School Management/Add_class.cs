using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace School_Management
{
    public partial class Add_class : Form
    {
        data d = new data();
        public static int index = 0;
        public Add_class()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(d.getconnection());
            con.Open();
            string s = "insert into class_master (c_name,no_stu,t_stu) values('"+c_name.Text+"','"+no_stu.Value.ToString()+ "','" + t_stu.Value.ToString() + "')";
            MySqlCommand cmd = new MySqlCommand(s, con);
            cmd.ExecuteNonQuery();
            con.Close();
            c_name.Text = "";
            no_stu.Value = 0;
            t_stu.Value = 0;
            load();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            c_name.Text = "";
            no_stu.Value = 0;
            t_stu.Value = 0;
            load();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id= e.RowIndex;
            DataGridViewRow selectrow = dataGridView1.Rows[id];
            index= Convert.ToInt32(selectrow.Cells[0].Value.ToString());
            c_name.Text = selectrow.Cells[1].Value.ToString(); ;
            no_stu.Value = Convert.ToInt32(selectrow.Cells[2].Value.ToString());
            t_stu.Value = Convert.ToInt32(selectrow.Cells[3].Value.ToString());

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(d.getconnection());
            con.Open();
            string s = "update class_master set c_name='" + c_name.Text + "',no_stu='" + no_stu.Value.ToString() + "',t_stu='" + t_stu.Value.ToString() + "' where id="+index+"";
            MySqlCommand cmd = new MySqlCommand(s, con);
            cmd.ExecuteNonQuery();
            con.Close();
            c_name.Text = "";
            no_stu.Value = 0;
            t_stu.Value = 0;
            load();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(d.getconnection());
            con.Open();
            string s = "delete from class_master where id=" + index + "";
            MySqlCommand cmd = new MySqlCommand(s, con);
            cmd.ExecuteNonQuery();
            con.Close();
            c_name.Text = "";
            no_stu.Value = 0;
            t_stu.Value = 0;
            load();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void load()
        {
            MySqlConnection con = new MySqlConnection(d.getconnection());
      //      con.Open();
            con.Open();
            string s = "select * from class_master";
            MySqlCommand cmd = new MySqlCommand(s, con);
            MySqlDataReader rs = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (rs.Read())
            {
                dataGridView1.Rows.Add(rs[0], rs[1], rs[2], rs[3]);
            }
            rs.Close();
            con.Close();
        }

        private void Add_class_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
