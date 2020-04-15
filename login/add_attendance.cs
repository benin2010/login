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
    public partial class add_attendance : Form
    {
        public add_attendance()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void add_attendance_Load(object sender, EventArgs e)
        {
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.HeaderText = "Attance";
            comboBoxColumn.Width = 100;
            comboBoxColumn.Name = "comboBoxColumn";
            dgv1.Columns.Add(comboBoxColumn);
            foreach (DataGridViewRow row in dgv1.Rows)
            {
                //Reference the ComboBoxCell.
                DataGridViewComboBoxCell comboBoxCell = (row.Cells[2] as DataGridViewComboBoxCell);

                //Insert the Default Item to ComboBoxCell.
                comboBoxCell.Items.Add("Present");

                //Set the Default Value as the Selected Value.
                comboBoxCell.Value = "Present";
                comboBoxCell.Items.Add("Absent");

                //Set the Default Value as the Selected Value.
                //comboBoxCell.Value = "Absent";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_attendance_KeyDown(object sender, KeyEventArgs e)
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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
