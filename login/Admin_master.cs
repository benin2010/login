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
    public partial class Admin_master : Form
    {
        public Admin_master()
        {
            InitializeComponent();
            privilage();
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panalform(new lib_addbook());
        }
        private void panalform(object form)
        {
            if (this.panalCont.Controls.Count > 0)
                this.panalCont.Controls.RemoveAt(0);
            Form fm = form as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.panalCont.Controls.Add(fm);
            this.panalCont.Tag = fm;
            fm.Show();
        }
        private void EditToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            panalform(new report_card());
        }

        private void performanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panalform(new report_workedu());
            
        }

        private void addToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            panalform(new report_lifeskill());

        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panalform(new report_artedu());

        }

        private void healthPhysicalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panalform(new report_healeva());

        }

        private void addToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            panalform(new report_mathseva());

        }

       
        private void addToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            panalform(new report_card());

        }

        private void addToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            panalform(new report_langeva());

        }

        private void aDDToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            panalform(new student_master());

        }

        private void aDDToolStripMenuItem18_Click(object sender, EventArgs e)
        {
            panalform(new enq_form());

        }

        private void aDDToolStripMenuItem19_Click(object sender, EventArgs e)
        {
            panalform(new lib_returnbook());

        }

        private void aDDISSUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panalform(new lib_issuebook());

        }

        private void addToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            panalform(new publisher());

        }

        private void addClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void addSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
             
        }

        private void addSyllabusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void addPptsVideosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void addNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void addToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            panalform(new lib_addauthor());

        }

        private void addToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            panalform(new txtano());

        }

        private void addToolStripMenuItem14_Click(object sender, EventArgs e)
        {
            

        }

        private void addToolStripMenuItem15_Click(object sender, EventArgs e)
        {
            

        }

        private void addToolStripMenuItem16_Click(object sender, EventArgs e)
        {
           

        }

        private void panalCont_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addToolStripMenuItem23_Click(object sender, EventArgs e)
        {
            panalform(new add_syllabus());
        }

        private void addToolStripMenuItem24_Click(object sender, EventArgs e)
        {
            panalform(new add_subject());
        }

        private void addToolStripMenuItem22_Click(object sender, EventArgs e)
        {
            panalform(new add_notes());
        }

        private void addToolStripMenuItem21_Click(object sender, EventArgs e)
        {
            panalform(new add_ppt());
        }

        private void addToolStripMenuItem25_Click(object sender, EventArgs e)
        {
            panalform(new add_class());
        }

        private void admissionFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void enquiryform_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem20_Click(object sender, EventArgs e)
        {
            panalform (new teachers_details());

        }

        private void assignClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void assigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void attanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        public void privilage()
        {
            persion p = new persion();
            string type = p.dept1;
            if(type.Equals("Admin"))
            {
                stu_mast.Visible = true;
                tea_mas.Visible = true;
                adm_mas.Visible = true;
                act.Visible = false;
                lib_mas.Visible = false;
                tea.Visible = false;
                //teacherreporrt.Visible = true;
                //accountsreport.Visible = true;
                //assetsreport.Visible = true;
                //feereports.Visible = true;
            }
            else if (type.Equals("Teacher"))
            {
                stu_mast.Visible = false;
                tea_mas.Visible = false;
                adm_mas.Visible = false;
                act.Visible = false;
                lib_mas.Visible = false;
                tea.Visible = true;
                //teacherreporrt.Visible = true;
                //accountsreport.Visible = false;
                //assetsreport.Visible = false;
                //feereports.Visible = false;
            }
            else if (type.Equals("Library"))
            {
                stu_mast.Visible = false;
                tea_mas.Visible = false;
                adm_mas.Visible = false;
                act.Visible = false;
                lib_mas.Visible = true;
                tea.Visible = false;
                //teacherreporrt.Visible = false;
                //accountsreport.Visible = false;
                //assetsreport.Visible = false;
                //feereports.Visible = false;
            }
            else if (type.Equals("Account"))
            {
                stu_mast.Visible = false;
                tea_mas.Visible = false;
                adm_mas.Visible = false;
                act.Visible = true;
                lib_mas.Visible = false;
                tea.Visible = false;
                //teacherreporrt.Visible = false;
                //accountsreport.Visible = true;
                //assetsreport.Visible = false;
                //feereports.Visible = true;
            }

        }

        private void adminMaster_Click(object sender, EventArgs e)
        {

        }

        private void Admin_master_Load(object sender, EventArgs e)
        {
            privilage();
        }

        private void editToolStripMenuItem19_Click(object sender, EventArgs e)
        {
            panalform (new enq_form());
        }

        private void viewToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            panalform(new enq_form());
        }

        private void editToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            panalform(new student_master());
        }

        private void viewToolStripMenuItem20_Click(object sender, EventArgs e)
        {
            panalform(new student_master());
        }

        private void editToolStripMenuItem24_Click(object sender, EventArgs e)
        {
            panalform(new add_class());
        }

        private void viewToolStripMenuItem25_Click(object sender, EventArgs e)
        {
            panalform(new add_class());
        }

        private void editToolStripMenuItem23_Click(object sender, EventArgs e)
        {
            panalform(new add_subject());
        }

        private void viewToolStripMenuItem24_Click(object sender, EventArgs e)
        {
            panalform(new add_subject());
        }

        private void teachersDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem18_Click(object sender, EventArgs e)
        {
            panalform(new teachers_details());
        }

        private void viewToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            panalform(new teachers_details());
        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eDITToolStripMenuItem27_Click(object sender, EventArgs e)
        {
            panalform(new teachers_details());
        }

        private void viewToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            panalform(new publisher());
        }

        private void editToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            panalform(new publisher());
        }

        private void editToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            panalform(new lib_addauthor());
        }

        private void viewToolStripMenuItem14_Click(object sender, EventArgs e)
        {
            panalform(new lib_addauthor());
        }

        private void editToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            panalform(new txtano());
        }

        private void viewToolStripMenuItem15_Click(object sender, EventArgs e)
        {
            panalform(new txtano());
        }

        private void editToolStripMenuItem14_Click(object sender, EventArgs e)
        {
            
        }

        private void viewToolStripMenuItem16_Click(object sender, EventArgs e)
        {
            
        }

        private void editToolStripMenuItem15_Click(object sender, EventArgs e)
        {
            
        }

        private void viewToolStripMenuItem17_Click(object sender, EventArgs e)
        {
            
        }

        private void editToolStripMenuItem16_Click(object sender, EventArgs e)
        {
            
        }

        private void viewToolStripMenuItem18_Click(object sender, EventArgs e)
        {
            
        }

        private void editBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panalform(new lib_addbook());
        }

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panalform(new lib_addbook());        }

        private void editReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panalform(new lib_returnbook());
        }

        private void viewReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panalform(new lib_returnbook());
        }

        private void editIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panalform(new lib_issuebook());
        }

        private void viewIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panalform(new lib_issuebook());
        }

        private void eDITToolStripMenuItem29_Click(object sender, EventArgs e)
        {
            panalform(new add_attendance());
        }

        private void eDITToolStripMenuItem28_Click(object sender, EventArgs e)
        {
            panalform(new teachers_details());
        }

        private void eDITToolStripMenuItem25_Click(object sender, EventArgs e)
        {
            panalform(new assign_sub());
        }

        private void eDITToolStripMenuItem26_Click(object sender, EventArgs e)
        {
            panalform(new assign_class());
        }

        private void aDDToolStripMenuItem26_Click(object sender, EventArgs e)
        {
            panalform(new assign_sub());
        }

        private void vIEWToolStripMenuItem26_Click(object sender, EventArgs e)
        {
            panalform(new assign_sub());
        }

        private void aDDToolStripMenuItem27_Click(object sender, EventArgs e)
        {
            panalform(new assign_class());
        }

        private void vIEWToolStripMenuItem27_Click(object sender, EventArgs e)
        {
            panalform(new assign_class());
        }

        private void aDDToolStripMenuItem28_Click(object sender, EventArgs e)
        {
            panalform(new add_attendance());
        }

        private void vIEWToolStripMenuItem29_Click(object sender, EventArgs e)
        {
            panalform(new add_attendance());
        }

        private void teacherMaster_Click(object sender, EventArgs e)
        {

        }

        private void vIEWToolStripMenuItem28_Click(object sender, EventArgs e)
        {
            panalform(new teachers_details());
        }

        private void editToolStripMenuItem21_Click(object sender, EventArgs e)
        {
            panalform(new add_notes());
        }

        private void viewToolStripMenuItem22_Click(object sender, EventArgs e)
        {
            panalform(new add_notes());
        }

        private void editToolStripMenuItem22_Click(object sender, EventArgs e)
        {
            panalform(new add_syllabus());
        }

        private void viewToolStripMenuItem23_Click(object sender, EventArgs e)
        {
            panalform(new add_syllabus());
        }

        private void editToolStripMenuItem20_Click(object sender, EventArgs e)
        {
            panalform(new add_ppt());
        }

        private void viewToolStripMenuItem21_Click(object sender, EventArgs e)
        {
            panalform(new add_ppt());
        }

        private void viewToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            panalform(new report_card());
        }

        private void editToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            panalform(new report_langeva());
        }

        private void viewToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            panalform(new report_langeva());
        }

        private void editToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            panalform(new report_lifeskill());
        }

        private void viewToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            panalform(new report_lifeskill());
        }

        private void editToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            panalform(new report_mathseva());
        }

        private void viewToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            panalform(new report_mathseva());
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panalform(new report_workedu());
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panalform(new report_workedu());
        }

        private void viewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panalform(new report_artedu());
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panalform(new report_artedu());
        }

        private void viewToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            panalform(new report_healeva());
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panalform(new report_healeva());
        }

        private void addToolStripMenuItem10_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem20_Click_1(object sender, EventArgs e)
        {
            panalform(new add_staffattendance());
        }

        private void editToolStripMenuItem18_Click_1(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem29_Click(object sender, EventArgs e)
        {
            

        }

        private void editToolStripMenuItem30_Click(object sender, EventArgs e)
        {
            
        }

        private void viewToolStripMenuItem9_Click_1(object sender, EventArgs e)
        {
            
        }

        private void addToolStripMenuItem30_Click(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem9_Click_2(object sender, EventArgs e)
        {
            panalform(new add_staffattendance());
        }

        private void workEducationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem9_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem8_Click_1(object sender, EventArgs e)
        {
            panalform(new add_lang());

        }

        private void editToolStripMenuItem8_Click_1(object sender, EventArgs e)
        {
            panalform(new add_lang());
        }

        private void viewToolStripMenuItem9_Click_3(object sender, EventArgs e)
        {
            panalform(new add_lang());
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tERMFEEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem11_Click_1(object sender, EventArgs e)
        {
            panalform(new Fee_receipt());

        }

        private void editToolStripMenuItem11_Click_1(object sender, EventArgs e)
        {
            panalform(new Fee_receipt());
        }

        private void viewToolStripMenuItem11_Click_1(object sender, EventArgs e)
        {
            panalform(new Fee_receipt());
        }

        private void addToolStripMenuItem12_Click_1(object sender, EventArgs e)
        {
            panalform(new fee_stationary());

        }

        private void editToolStripMenuItem12_Click_1(object sender, EventArgs e)
        {
            panalform(new fee_stationary());
        }

        private void viewToolStripMenuItem13_Click_1(object sender, EventArgs e)
        {
            panalform(new fee_stationary());
        }

        private void addToolStripMenuItem13_Click_1(object sender, EventArgs e)
        {
            panalform(new add_scholastic());

        }

        private void editToolStripMenuItem13_Click_1(object sender, EventArgs e)
        {
            panalform(new add_scholastic());
        }

        private void viewToolStripMenuItem14_Click_1(object sender, EventArgs e)
        {
            panalform(new add_scholastic());
        }

        private void addToolStripMenuItem14_Click_1(object sender, EventArgs e)
        {
            panalform(new grade_nonscho());

        }

        private void editToolStripMenuItem14_Click_1(object sender, EventArgs e)
        {
            panalform(new grade_nonscho());
        }

        private void viewToolStripMenuItem15_Click_1(object sender, EventArgs e)
        {
            panalform(new grade_nonscho());
        }

        private void addToolStripMenuItem15_Click_1(object sender, EventArgs e)
        {
            panalform(new add_skillevaluation());
        }

        private void editToolStripMenuItem15_Click_1(object sender, EventArgs e)
        {
            panalform(new add_skillevaluation());
        }

        private void viewToolStripMenuItem16_Click_1(object sender, EventArgs e)
        {
            panalform(new add_skillevaluation());
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void issueBookRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void issueBookReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panalform(new dtpf());
        }

        private void returnBookReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panalform(new lib_reportreturn());
        }

        private void sEARCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void journalMagazineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void booksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panalform(new lib_searchbook());
        }

        private void jounalsAndMagazineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panalform(new lib_searchjournal());
        }

        private void addToolStripMenuItem16_Click_1(object sender, EventArgs e)
        {
            panalform(new lib_addjournal());
        }

        private void entryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panalform(new lib_addnews());
        }

        private void editToolStripMenuItem18_Click_2(object sender, EventArgs e)
        {
            panalform(new lib_addnews());
        }

        private void viewToolStripMenuItem19_Click(object sender, EventArgs e)
        {
            panalform(new lib_addnews());
        }

        private void entryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panalform(new lib_addjournal());
        }

        private void editToolStripMenuItem16_Click_1(object sender, EventArgs e)
        {
            panalform(new lib_addjournal());
        }

        private void viewToolStripMenuItem17_Click_1(object sender, EventArgs e)
        {
            panalform(new lib_addjournal());
        }

        private void addToolStripMenuItem17_Click(object sender, EventArgs e)
        {
            panalform(new lib_addsupplier());
        }

        private void editToolStripMenuItem17_Click(object sender, EventArgs e)
        {
            panalform(new lib_addsupplier());
        }

        private void viewToolStripMenuItem18_Click_1(object sender, EventArgs e)
        {
            panalform(new lib_addsupplier());
        }

        private void newspaperToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panalform(new lib_searchnews());
        }

        private void supplierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panalform(new lib_searchsupplier());
        }

        private void supplierToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panalform(new lib_reportsupplier());
        }

        private void typeToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

          
        }

        private void addToolStripMenuItem16_Click_2(object sender, EventArgs e)
        {
            panalform(new lib_adddepartment());



        }

        private void editToolStripMenuItem19_Click_1(object sender, EventArgs e)
        {
            panalform(new lib_adddepartment());
        }

        private void viewToolStripMenuItem20_Click_1(object sender, EventArgs e)
        {
            panalform(new lib_adddepartment());
        }

        private void addToolStripMenuItem18_Click_1(object sender, EventArgs e)
        {
            panalform(new lib_addstaff());
        }

        private void staffNameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem21_Click_1(object sender, EventArgs e)
        {
            panalform(new lib_addstaff());
        }

        private void viewToolStripMenuItem22_Click_1(object sender, EventArgs e)
        {
            panalform(new lib_addstaff());
        }

        private void loaction__Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem19_Click_1(object sender, EventArgs e)
        {
            panalform(new lib_nodue());

        }

        private void viewToolStripMenuItem23_Click_1(object sender, EventArgs e)
        {
            panalform(new lib_nodue());
        }

        private void editToolStripMenuItem22_Click_1(object sender, EventArgs e)
        {
            panalform(new lib_nodue());
        }

        private void addToolStripMenuItem20_Click_2(object sender, EventArgs e)
        {
            panalform(new lib_booktypeadd());

        }

        private void editToolStripMenuItem23_Click_1(object sender, EventArgs e)
        {
            panalform(new lib_booktypeadd());
        }

        private void viewToolStripMenuItem24_Click_1(object sender, EventArgs e)
        {
            panalform(new lib_booktypeadd());
        }

        private void addToolStripMenuItem22_Click_1(object sender, EventArgs e)
        {
            
        }

        private void editToolStripMenuItem24_Click_1(object sender, EventArgs e)
        {
            
        }

        private void viewToolStripMenuItem25_Click_1(object sender, EventArgs e)
        {
           
        }

        private void addToolStripMenuItem22_Click_2(object sender, EventArgs e)
        {
            panalform(new add_staffcategory());
        }

        private void editToolStripMenuItem24_Click_2(object sender, EventArgs e)
        {
            panalform(new add_staffcategory());
        }

        private void viewToolStripMenuItem25_Click_2(object sender, EventArgs e)
        {
            panalform(new add_staffcategory());
        }

        private void addToolStripMenuItem23_Click_1(object sender, EventArgs e)
        {
            panalform(new add_staffdesig());
        }

        private void editToolStripMenuItem25_Click_1(object sender, EventArgs e)
        {
            panalform(new add_staffdesig());
        }

        private void viewToolStripMenuItem26_Click_1(object sender, EventArgs e)
        {
            panalform(new add_staffdesig());
        }

        private void designationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panalform(new staff_searchemployee());
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panalform(new stu_search());
        }

        private void addToolStripMenuItem26_Click_1(object sender, EventArgs e)
        {
            panalform(new add_holiday());
        }

        private void addToolStripMenuItem28_Click_1(object sender, EventArgs e)
        {
            panalform(new add_staffcategory());
        }

        private void editToolStripMenuItem30_Click_1(object sender, EventArgs e)
        {
            panalform(new add_staffcategory());
        }

        private void viewToolStripMenuItem31_Click(object sender, EventArgs e)
        {
            panalform(new add_staffcategory());
        }

        private void addToolStripMenuItem29_Click_1(object sender, EventArgs e)
        {
            panalform(new add_leavetype());
        }

        private void editToolStripMenuItem31_Click(object sender, EventArgs e)
        {
            panalform(new add_leavetype());
        }

        private void viewToolStripMenuItem32_Click(object sender, EventArgs e)
        {
            panalform(new add_leavetype());
        }

        private void schlolasticAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void user_add_Click(object sender, EventArgs e)
        {

        }

        private void teachingStaff_sal_Click(object sender, EventArgs e)
        {
            panalform(new staff_salary());
        }

        private void salaryPercentageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem24_Click_1(object sender, EventArgs e)
        {
            panalform(new add_salarypercent());
        }

        private void editToolStripMenuItem26_Click_1(object sender, EventArgs e)
        {
            panalform(new add_salarypercent());
        }

        private void viewToolStripMenuItem27_Click_1(object sender, EventArgs e)
        {
            panalform(new add_salarypercent());
        }

        private void addToolStripMenuItem25_Click_1(object sender, EventArgs e)
        {
            panalform(new add_accountsalary());
        }

        private void viewToolStripMenuItem28_Click_1(object sender, EventArgs e)
        {
            panalform(new add_accountsalary());
        }

        private void editToolStripMenuItem27_Click_1(object sender, EventArgs e)
        {
            panalform(new add_accountsalary());
        }

        private void viewToolStripMenuItem29_Click_1(object sender, EventArgs e)
        {
            panalform(new staff_salary());
        }

        private void editToolStripMenuItem28_Click_1(object sender, EventArgs e)
        {
            panalform(new staff_salary());
        }

        private void addToolStripMenuItem30_Click_1(object sender, EventArgs e)
        {
            panalform(new stu_nodue());
        }

        private void viewToolStripMenuItem33_Click(object sender, EventArgs e)
        {
            panalform(new stu_nodue());
        }

        private void editToolStripMenuItem32_Click(object sender, EventArgs e)
        {
            panalform(new stu_nodue());
        }

        private void addToolStripMenuItem32_Click(object sender, EventArgs e)
        {
            panalform(new staff_reqleave());
        }

        private void viewToolStripMenuItem35_Click(object sender, EventArgs e)
        {
            panalform(new staff_reqleave());
        }

        private void addToolStripMenuItem31_Click(object sender, EventArgs e)
        {

        }

        private void languageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem37_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem34_Click(object sender, EventArgs e)
        {
            panalform(new add_salarypercent());
        }

        private void editToolStripMenuItem35_Click(object sender, EventArgs e)
        {
            panalform(new add_salarypercent());
        }

        private void viewToolStripMenuItem38_Click(object sender, EventArgs e)
        {
            panalform(new add_salarypercent());
        }

        private void addToolStripMenuItem24_Click_2(object sender, EventArgs e)
        {
            panalform(new Driver_details());
        }

        private void editToolStripMenuItem26_Click_2(object sender, EventArgs e)
        {
            panalform(new Driver_details());
        }

        private void viewToolStripMenuItem27_Click_2(object sender, EventArgs e)
        {
            panalform(new Driver_details());
        }
    }
}
