using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalExam.Business;
//dec3rd2022--needed this when i added connection string
using ReviewForFinalExam;

namespace FinalExam.GUI
{
    public partial class FormCoursesAssigned : Form
    {
        public FormCoursesAssigned()
        {
            InitializeComponent();
        }
        //dec3rd2022--1st add the db entity model conection strng
        TeacherCourseDBEntities1 dbcontext = new TeacherCourseDBEntities1();

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.ShowDialog();
        }

        private void FormCoursesAssigned_Load(object sender, EventArgs e)
        {

            int teacherId = FormLogIn.userId; // get from FormLogIn
            Employee emp = new Employee();
                emp=emp.SearchEmployee(teacherId);            
            labelTeacher.Text = "Teacher : " + emp.FirstName + "," + emp.LastName + "(" + emp.EmployeeNumber + ")";
            CourseAssignment ca = new CourseAssignment();
            List<Course> listC = ca.GetCourseList(teacherId);
            listViewCoursesAssigned.Items.Clear();
            foreach (var item in listC)
            {
                ListViewItem itemC = new ListViewItem(item.CourseNumber);
                itemC.SubItems.Add(item.CourseTitle);
                itemC.SubItems.Add(item.TotalHour.ToString());
                listViewCoursesAssigned.Items.Add(itemC);

            }


        }
    }
}
