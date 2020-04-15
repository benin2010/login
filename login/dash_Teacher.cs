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
    public partial class dash_Teacher : Form
    {
        public dash_Teacher()
        {
            InitializeComponent();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Teacher__Load(object sender, EventArgs e)
        {
            loadAttendance();
            loadSubject();
        }
       private void loadAttendance()
        {
            chart1.Titles.Add("Attendance");
            chart1.Series["Attendance"].IsValueShownAsLabel = true;
            chart1.Series["Attendance"].Points.AddXY("Present", "80");
            chart1.Series["Attendance"].Points.AddXY("Absent", "20");
        }

        private void loadSubject()
        {
            chart2.Titles.Add("Subject(Pass%)");
            chart2.Series["Subject"].IsValueShownAsLabel = true;
            chart2.Series["Subject"].Points.AddXY("Class1", "80");
            chart2.Series["Subject"].Points.AddXY("Class2", "83");
            chart2.Series["Subject"].Points.AddXY("Class3", "88");
            chart2.Series["Subject"].Points.AddXY("Class4", "90");
        }
    }
}
