﻿using MySql.Data.MySqlClient;
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
    public partial class Driver_details : Form
    {
        data d = new data();
        public static int index = -1;
        public Driver_details()
        {
            InitializeComponent();
        }

        private void Driver_details_KeyDown(object sender, KeyEventArgs e)
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
            if (cmbay.Text == "" || txteid.Text == "" || txtdes.Text == "" || txtdn.Text == "" || txtlic.Text == "" || txtexp.Text == "" || dtphc.Text == "" || dtpr.Text == "")
            {
                MessageBox.Show("Fill All Details");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(d.getconnection());
                con.Open();
                string s = "insert into driver_deatils (aca_yr,emp_id,desig,dri_name,lic_num,exp,check_up,renewal,rem) values('" + cmbay.Text + "','" + txteid.Text + "','" + txtdes.Text + "','" + txtdn.Text + "','" + txtlic.Text + "','" + txtexp.Text +"','" + dtphc.Text + "','" + dtpr.Text + "','" + rtxtr.Text + "')";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                cmbay.Focus();
            }
        }
        public void load()
        {
            MySqlConnection con = new MySqlConnection(d.getconnection());
            //      con.Open();
            con.Open();
            string s = "select * from driver_deatils ORDER BY id DESC;";
            MySqlCommand cmd = new MySqlCommand(s, con);
            MySqlDataReader rs = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (rs.Read())
            {
                dataGridView1.Rows.Add(rs[0], rs[1], rs[2], rs[3], rs[4], rs[5], rs[6], rs[7], rs[8], rs[9]);
            }
            rs.Close();
            con.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (cmbay.Text == "" || txteid.Text == "" || txtdes.Text == "" || txtdn.Text == "" || txtlic.Text == "" || txtexp.Text == "" || dtphc.Text == "" || dtpr.Text == "")
            {
                MessageBox.Show("Fill All Details");
            }
            else if (index == -1)
            {
                MessageBox.Show("Please Select Update row");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(d.getconnection());
                con.Open();
                string s = "update driver_deatils set aca_yr='" + cmbay.Text + "', emp_id='" + txteid.Text + "', desig='" + txtdes.Text + "', dri_name='" + txtdn.Text + "', lic_num='" + txtlic.Text + "' , exp = '" + txtexp.Text + "', check_up = '" + dtphc.Text + "', renewal = '" + dtpr.Text + "', rem = '" + rtxtr.Text + "' where id=" + index + "";
                MySqlCommand cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                load();
                cmbay.Focus();
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
                    string s = "delete from driver_deatils where id=" + index + "";
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
        void clear()
        {
            cmbay.Text = "";
            txteid.Text = "";
            txtdes.Text = "";
            txtdn.Text = "";
            txtlic.Text = "";
            txtexp.Text = "";
            dtphc.Text = "";
            dtpr.Text = "";
            rtxtr.Text = "";
                           
       }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = e.RowIndex;
            DataGridViewRow selectrow = dataGridView1.Rows[id];
            index = Convert.ToInt32(selectrow.Cells[0].Value.ToString());
            cmbay.Text = selectrow.Cells[1].Value.ToString();
            txteid.Text = selectrow.Cells[2].Value.ToString();
            txtdes.Text = selectrow.Cells[3].Value.ToString();
            txtdn.Text = selectrow.Cells[4].Value.ToString();
            txtlic.Text = selectrow.Cells[5].Value.ToString();
            txtexp.Text = selectrow.Cells[6].Value.ToString();
           dtphc.Text = selectrow.Cells[7].Value.ToString();
            dtpr.Text = selectrow.Cells[8].Value.ToString();
           rtxtr.Text = selectrow.Cells[9].Value.ToString();
           
        }
    }
}
