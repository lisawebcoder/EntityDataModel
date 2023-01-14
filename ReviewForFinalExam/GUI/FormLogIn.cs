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
    public partial class FormLogIn : Form
    {
        public static int userId;
        public FormLogIn()
        {
            InitializeComponent();
        }
        //dec3rd2022--1st add the db entity model conection strng
        TeacherCourseDBEntities1 dbcontext = new TeacherCourseDBEntities1();

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //dec3rd2022--this needed a parent call--
            Business.User user = new Business.User();
            user.UserId = Convert.ToInt32(textBoxUserName.Text);
            user.Password = textBoxPassword.Text;
            if (!(user.IsValidLogin(user)))
            {
                MessageBox.Show("Invalid username or password","Invalid User");
                return;
            }
            //check JobTitle
            Employee emp = new Employee();
            emp = emp.SearchEmployee(user.UserId);

            if (emp.JobTitle == "Teacher")
            {
                userId = user.UserId; // store userId in the static variable
                this.Hide();
                FormCoursesAssigned frmCoursesAssigned = new FormCoursesAssigned();
                frmCoursesAssigned.ShowDialog();
            }

            if (emp.JobTitle == "Program Coordinator")
            {
                userId = user.UserId; // store userId in the static variable
                this.Hide();
                FormCourseAssignment frmCoursesAssignment = new FormCourseAssignment();
                frmCoursesAssignment.ShowDialog();
            }

        }
        
    }
}
