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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void assigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assign_Subject f = new Assign_Subject();
            f.MdiParent = this;
            f.Show();
        }

        private void adminMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salaryAddToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control cntrl in this.Controls)
            {
                if (cntrl is MdiClient)
                {
                    cntrl.BackColor = Color.SkyBlue;
                }
            }
        }

        private void dailyExpenceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportByStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void performenceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addClassToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Add_class f = new Add_class();
            f.MdiParent = this;
            f.Show();
        }

        private void admissionFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application_Form f = new Application_Form();
            f.MdiParent = this;
            f.Show();
        }

        private void admissionApprovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Approval_form f = new Approval_form();
            f.MdiParent = this;
            f.Show();
        }

        private void addSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Subject f = new Add_Subject();
            f.MdiParent = this;
            f.Show();
        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teacher f = new Teacher();
            f.MdiParent = this;
            f.Show();
        }

        private void assignClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assign_class f = new Assign_class();
            f.MdiParent = this;
            f.Show();
        }

        private void addToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            subject_eve f = new subject_eve();
            f.MdiParent = this;
            f.Show();
        }

        private void editToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            subject_eve f = new subject_eve();
            f.MdiParent = this;
            f.Show();
        }

        private void viewToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            subject_eve f = new subject_eve();
            f.MdiParent = this;
            f.Show();
        }

        private void addToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            language_eva f = new language_eva();
            f.MdiParent = this;
            f.Show();
        }

        private void editToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            language_eva f = new language_eva();
            f.MdiParent = this;
            f.Show();
        }

        private void viewToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            language_eva f = new language_eva();
            f.MdiParent = this;
            f.Show();
        }

        private void addToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            science_eva f = new science_eva();
            f.MdiParent = this;
            f.Show();
        }

        private void editToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            science_eva f = new science_eva();
            f.MdiParent = this;
            f.Show();
        }

        private void viewToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            science_eva f = new science_eva();
            f.MdiParent = this;
            f.Show();
        }

        private void addToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            maths_eval f = new maths_eval();
            f.MdiParent = this;
            f.Show();

        }

        private void editToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            maths_eval f = new maths_eval();
            f.MdiParent = this;
            f.Show();
        }

        private void viewToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            maths_eval f = new maths_eval();
            f.MdiParent = this;
            f.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Per_eve f = new Per_eve();
            f.MdiParent = this;
            f.Show();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Per_eve f = new Per_eve();
            f.MdiParent = this;
            f.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Per_eve f = new Per_eve();
            f.MdiParent = this;
            f.Show();
        }

        private void artEducationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Art_Eve f = new Art_Eve();
            f.MdiParent = this;
            f.Show();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            hel_eve f = new hel_eve();
            f.MdiParent = this;
            f.Show();
        }

        private void viewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Art_Eve f = new Art_Eve();
            f.MdiParent = this;
            f.Show();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Art_Eve f = new Art_Eve();
            f.MdiParent = this;
            f.Show();
        }

        private void viewToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            hel_eve f = new hel_eve();
            f.MdiParent = this;
            f.Show();
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            hel_eve f = new hel_eve();
            f.MdiParent = this;
            f.Show();
        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Stu_attance f = new School_Management.Stu_attance();
            f.MdiParent = this;
            f.Show();
        }

        private void viewToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Stu_attance f = new School_Management.Stu_attance();
            f.MdiParent = this;
            f.Show();
        }

        private void editToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Stu_attance f = new School_Management.Stu_attance();
            f.MdiParent = this;
            f.Show();
        }

        private void overallToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Stu_attance f = new School_Management.Stu_attance();
            f.MdiParent = this;
            f.Show();
        }

        private void attanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staff_att f = new School_Management.staff_att();
            f.MdiParent = this;
            f.Show();
        }

        private void addFeeTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fee_type f = new fee_type();
            f.MdiParent = this;
            f.Show();
        }

        private void addFeeAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fee_amount f = new School_Management.Fee_amount();
            f.MdiParent = this;
            f.Show();
        }

        private void addNonTechStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Nonstaff f = new School_Management.Add_Nonstaff();
            f.MdiParent = this;
            f.Show();
        }

        private void libraryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void publisherToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void addToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Add_publisher f = new Add_publisher();
            f.MdiParent = this;
            f.Show();
        }

        private void viewToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            Add_publisher f = new Add_publisher();
            f.MdiParent = this;
            f.Show();
        }

        private void editToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Add_publisher f = new Add_publisher();
            f.MdiParent = this;
            f.Show();
        }

        private void addToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Author f = new Author();
            f.MdiParent = this;
            f.Show();
        }

        private void editToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Author f = new Author();
            f.MdiParent = this;
            f.Show();
        }

        private void viewToolStripMenuItem14_Click(object sender, EventArgs e)
        {
            Author f = new Author();
            f.MdiParent = this;
            f.Show();
        }

        private void addToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            Add_Loc f = new Add_Loc();
            f.MdiParent = this;
            f.Show();
        }

        private void editToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            Add_Loc f = new Add_Loc();
            f.MdiParent = this;
            f.Show();
        }

        private void viewToolStripMenuItem15_Click(object sender, EventArgs e)
        {
            Add_Loc f = new Add_Loc();
            f.MdiParent = this;
            f.Show();
        }

        private void addToolStripMenuItem14_Click(object sender, EventArgs e)
        {
            Booktype f = new Booktype();
            f.MdiParent = this;
            f.Show();
        }

        private void editToolStripMenuItem14_Click(object sender, EventArgs e)
        {
            Booktype f = new Booktype();
            f.MdiParent = this;
            f.Show();
        }

        private void viewToolStripMenuItem16_Click(object sender, EventArgs e)
        {
            Booktype f = new Booktype();
            f.MdiParent = this;
            f.Show();
        }

        private void addToolStripMenuItem15_Click(object sender, EventArgs e)
        {
            Add_Fine_stf f = new Add_Fine_stf();
            f.MdiParent = this;
            f.Show();
        }

        private void editToolStripMenuItem15_Click(object sender, EventArgs e)
        {
            Add_Fine_stf f = new Add_Fine_stf();
            f.MdiParent = this;
            f.Show();
        }

        private void viewToolStripMenuItem17_Click(object sender, EventArgs e)
        {
            Add_Fine_stf f = new Add_Fine_stf();
            f.MdiParent = this;
            f.Show();
        }

        private void teacherToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem16_Click(object sender, EventArgs e)
        {
            Add_fine_stu f = new School_Management.Add_fine_stu();
            f.MdiParent = this;
            f.Show();
        }

        private void editToolStripMenuItem16_Click(object sender, EventArgs e)
        {
            Add_fine_stu f = new School_Management.Add_fine_stu();
            f.MdiParent = this;
            f.Show();
        }

        private void viewToolStripMenuItem18_Click(object sender, EventArgs e)
        {
            Add_fine_stu f = new School_Management.Add_fine_stu();
            f.MdiParent = this;
            f.Show();
        }

        private void loactionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_book f = new Add_book();
            f.MdiParent = this;
            f.Show();
        }

        private void editBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_book f = new Add_book();
            f.MdiParent = this;
            f.Show();
        }

        private void issuseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Issue_Book f = new Issue_Book();
            f.MdiParent = this;
            f.Show();
        }

        private void reportToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return_Book f = new Return_Book();
            f.MdiParent = this;
            f.Show(); 
        }

        private void ptop_Paint(object sender, PaintEventArgs e)
        {


        }
    }
}
