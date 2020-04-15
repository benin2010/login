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
    public partial class staff_att : Form
    {
        public staff_att()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void staff_att_Load(object sender, EventArgs e)
        {
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.HeaderText = "Attance";
            comboBoxColumn.Width = 100;
            comboBoxColumn.Name = "comboBoxColumn";
            dataGridView1.Columns.Add(comboBoxColumn);
            foreach (DataGridViewRow row in dataGridView1.Rows)
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
    }
}
