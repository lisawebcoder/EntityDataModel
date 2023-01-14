using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Xml.Serialization; // XmlSerializer class; serialization/ deserialization
//using System.IO;
using FinalExam.Business;
//dec3rd2022--needed this when i added connection string
using ReviewForFinalExam;

namespace FinalExam.GUI
{
    public partial class FormCourseAssignment : Form
    {
        //dec3rd2022--1st add the db entity model conection strng
        //int id = 0;//use after maybe
        Teacher model = new Teacher();
        TeacherCours model2 = new TeacherCours();
        TeacherCourseDBEntities1 dbcontext = new TeacherCourseDBEntities1();

        List<CourseAssignment> listCourseAssigned = new List<CourseAssignment>();
        static string filePath = Environment.CurrentDirectory + @"\CoursesAssigned.Xml";
        public FormCourseAssignment()
        {
            InitializeComponent();
            //dec10th2022
            bindGridView();
            bindGridView2();
        }
        //dec10th2022--this is a default display to form bind?
        void bindGridView()
        {
            //guide code
            // dataGridView1.DataSource = db.students.ToList<student>();
            dataGridView1.DataSource = dbcontext.Teachers.ToList<Teacher>();
           // dataGridView1.DataSource = dbcontext.TeacherCourses.ToList<TeacherCours>();
                    
        }
        //2nd binding grid voew
        /**/
        void bindGridView2()
        {
            
            
            dataGridView2.DataSource = dbcontext.TeacherCourses.ToList<TeacherCours>();

        }
        

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.ShowDialog();
        }

        private void FormCourseAssignment_Load(object sender, EventArgs e)
        {
            
            List<Employee> listEmp = new List<Employee>();
            Employee emp = new Employee();
            listEmp = emp.GetListEmployee();
            
            foreach (var itemE in listEmp)
            {   
                if ((itemE.JobTitle.ToUpper() == "Teacher".ToUpper()))
                {
                    
                    comboBoxTeacher.Items.Add(itemE.EmployeeNumber + "," + itemE.FirstName + "," + itemE.LastName);

                }

            }

            List<Course> listCourse = new List<Course>();
            Course course = new Course();
            listCourse = course.GetAllCourses();
            foreach (var itemC in listCourse)
            {
                comboBoxCourse.Items.Add(itemC.CourseNumber + "," + itemC.CourseTitle + "," + itemC.TotalHour);
            }
        }

        private void buttonAssignCourse_Click(object sender, EventArgs e)
        {
            if (comboBoxTeacher.SelectedIndex==-1)
            {
                MessageBox.Show("Please select the teacher.","Teacher required");
                return;
            }

            if (comboBoxCourse.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the course.", "Course required");
                return;
            }

            CourseAssignment ca = new CourseAssignment();
            string[] teacherFields = (comboBoxTeacher.Text).Split(',');
            int teacherId = Convert.ToInt32(teacherFields[0]);
            string[] courseFields = (comboBoxCourse.Text).Split(',');
            string courseId = courseFields[0];

            //Check duplicate course assignments
            List<CourseAssignment> listCA = ca.GetAllCoursesAssigned();
            foreach (var itemCA in listCA)
            {
                if ((itemCA.CourseNumber == courseId) && (itemCA.EmployeeNumber==teacherId))
                {
                    MessageBox.Show("This course has been assigned to this teacher.",
                                     "Duplicate Course Assignment",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

            }

            //Check the number of courses assigned //cannot exceed 4 courses
            List<Course> listC = ca.GetCourseList(teacherId);
            if (listC.Count == 4)
            {
                MessageBox.Show("This teacher has been assigned the max of 4 courses", "Number of Courses");
                return;

            }
            ca.EmployeeNumber = teacherId;
            ca.CourseNumber = courseId;
            ca.AssignedDate = DateTime.Parse (maskedTextBoxAssignedDate.Text);
            listCourseAssigned.Add(ca);
            MessageBox.Show("The course has been added to the list","List of Courses");

        }

        private void buttonSaveToXML_Click(object sender, EventArgs e)
        {
            CourseAssignment ca = new CourseAssignment();
            ca.SaveCoursesAssigned(listCourseAssigned);

        }

        private void buttonListCourses_Click(object sender, EventArgs e)
        {
            if (comboBoxTeacher.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the teacher.", "Teacher required");
                return;
            }

            CourseAssignment ca = new CourseAssignment();
            string[] teacherFields = (comboBoxTeacher.Text).Split(',');
            int teacherId = Convert.ToInt32(teacherFields[0]);
            List<Course> listC = ca.GetCourseList(teacherId);
            listViewCourse.Items.Clear();
            foreach (var item in listC)
            {
                ListViewItem itemC = new ListViewItem(item.CourseNumber);
                itemC.SubItems.Add(item.CourseTitle);
                itemC.SubItems.Add(item.TotalHour.ToString());
                listViewCourse.Items.Add(itemC);

            }
        }
        //dec3rd2022 simple exit button
        private void btnAssignExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //dec3rd--this is try yo list teachers but not sure how
        private void buttonListTeacher_Click(object sender, EventArgs e)
        {
            if (comboBoxTeacher.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the teacher.", "Teacher required");
                return;
            }

            

            //dec3rd2022--trying to get employee data            
            Employee emp = new Employee();
            string[] teacherFields = (comboBoxTeacher.Text).Split(',');
            int teacherId = Convert.ToInt32(teacherFields[0]);
            List<Employee> listE = emp.GetListEmployee();
            listViewTeacher.Items.Clear();
            




            foreach (var item in listE)
            {
                ListViewItem itemE = new ListViewItem(item.JobTitle);
                itemE.SubItems.Add(item.FirstName);
                itemE.SubItems.Add(item.LastName);
                //itemE.SubItems.Add(item.TotalHour.ToString());
                listViewTeacher.Items.Add(itemE);

            }


        }

        //dec10th2022
        void ResetControls()
        {
            /*
            NametextBox.Clear();
            GendercomboBox.SelectedItem = null;
            AgetextBox.Clear();
            ClasstextBox.Clear();
            */


            //not sure i will use this--i added new comboBoxes
            comboBoxGridTeacher.SelectedItem = null;
            comboBoxGridCourse.SelectedItem = null;
        }




        //dec10th2022--take code from teacher exam demo
        private void btnInsert_Click(object sender, EventArgs e)
        {
            /*
            model.name = NametextBox.Text.Trim();
            model.gender = GendercomboBox.SelectedItem.ToString();
            model.age = Convert.ToInt32(AgetextBox.Text.Trim());
            model.standard = Convert.ToInt32(ClasstextBox.Text.Trim());
            db.students.Add(model);
            int a = db.SaveChanges();
            */

            model.FirstName = comboBoxGridTeacher.SelectedItem.ToString();
            model.LastName = comboBoxGridCourse.SelectedItem.ToString();
            //model2.CourseNumber = comboBoxGridTeacher.SelectedItem.ToString();
            //model2.CourseNumber = comboBoxGridCourse.SelectedItem.ToString();
            dbcontext.Teachers.Add(model);
            //dbcontext.TeacherCourses.Add(model2);
            int a = dbcontext.SaveChanges();

            if (a > 0)
            {
                MessageBox.Show("Data Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bindGridView();
                ResetControls();
            }
            else
            {
                MessageBox.Show("Data Inserted Failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        
    }
}
