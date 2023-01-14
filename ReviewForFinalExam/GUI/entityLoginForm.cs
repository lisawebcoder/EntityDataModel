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
using FinalExam.GUI;

namespace ReviewForFinalExam.GUI
{
    public partial class entityLoginForm : Form
    {
        public entityLoginForm()
        {
            InitializeComponent();
        }
        TeacherCourseDBEntities1 dbcontext = new TeacherCourseDBEntities1();
        private void btnLogin_Click(object sender, EventArgs e)

        {


            
            
              if(dbcontext.Users.Where(r=>r.JobTitle==txtBoxUserName.Text && r.Password == txtBoxPassword.Text && r.JobTitle == "Program Coordinator").Count() > 0)
            {           


                MessageBox.Show("valid PC user");
                this.Hide();
                FormCourseAssignment frmCoursesAssignment = new FormCourseAssignment();
                frmCoursesAssignment.ShowDialog();
            }


            if (dbcontext.Users.Where(r => r.JobTitle == txtBoxUserName.Text && r.Password == txtBoxPassword.Text && r.JobTitle == "Teacher").Count() > 0)
            {


                MessageBox.Show("valid Teacher user");
                this.Hide();
                //FormCoursesAssigned frmCoursesAssigned = new FormCoursesAssigned();
                //frmCoursesAssigned.ShowDialog();
                FormLogIn formLogIn = new FormLogIn();
                formLogIn.ShowDialog();
            }




            else
            {
                MessageBox.Show("not valid");
            }

        







            /*
            User user = new User();
            user.Userid = Convert.ToInt32(txtBoxUserName.Text);
            user.Password = txtBoxPassword.Text;
            if (!(user.IsValidLogin(user)))
            {
                MessageBox.Show("Invalid username or password", "Invalid User");
                return;
            }
            //check JobTitle
            Employee emp = new Employee();
            emp = emp.SearchEmployee(user.Userid);

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
            */

        }
        //simple exit button function--dec3rd2022--
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
