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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.chart1.Series["SectionA"].Points.AddXY("Lkg",50);
            this.chart1.Series["SectionB"].Points.AddXY("Lkg", 40);
            this.chart1.Series["SectionC"].Points.AddXY("Lkg", 60);
            this.chart1.Series["SectionD"].Points.AddXY("Lkg", 60);
            this.chart1.Series["SectionE"].Points.AddXY("Lkg", 59);
            this.chart1.Series["SectionF"].Points.AddXY("Lkg", 48);

            this.chart1.Series["SectionA"].Points.AddXY("UKG", 50);
            this.chart1.Series["SectionB"].Points.AddXY("UKG", 40);
            this.chart1.Series["SectionC"].Points.AddXY("UKG", 60);
            this.chart1.Series["SectionD"].Points.AddXY("UKG", 60);
            this.chart1.Series["SectionE"].Points.AddXY("UKG", 59);
            this.chart1.Series["SectionF"].Points.AddXY("UKG", 48);

            this.chart1.Series["SectionA"].Points.AddXY("PKG", 50);
            this.chart1.Series["SectionB"].Points.AddXY("PKG", 40);
            this.chart1.Series["SectionC"].Points.AddXY("PKG", 60);
            this.chart1.Series["SectionD"].Points.AddXY("PKG", 60);
            this.chart1.Series["SectionE"].Points.AddXY("PKG", 59);
            this.chart1.Series["SectionF"].Points.AddXY("PKG", 48);

            this.chart1.Series["SectionA"].Points.AddXY("1 Std", 50);
            this.chart1.Series["SectionB"].Points.AddXY("1 Std", 40);
            this.chart1.Series["SectionC"].Points.AddXY("1 Std", 60);
            this.chart1.Series["SectionD"].Points.AddXY("1 Std", 60);
            this.chart1.Series["SectionE"].Points.AddXY("1 Std", 59);
            this.chart1.Series["SectionF"].Points.AddXY("1 Std", 48);

        }
    }
}
