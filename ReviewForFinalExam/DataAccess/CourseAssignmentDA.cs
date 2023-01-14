using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization; // XmlSerializer class; serialization/ deserialization
using System.IO;
using FinalExam.Business;
using System.Windows.Forms;


namespace FinalExam.DataAccess
{    
    public static class CourseAssignmentDA
    {
        
        static string filePath = Environment.CurrentDirectory + @"\CoursesAssigned.Xml";

        public static void SaveRecords (List<CourseAssignment> listCourseAssigned)
        {
            FileStream fs = File.Create(filePath);
            XmlSerializer formatter = new XmlSerializer(listCourseAssigned.GetType());
            formatter.Serialize(fs, listCourseAssigned);
            fs.Close();
            MessageBox.Show("The list of courses assigned has been saved successfully", "Courses saved");
        }

        public static List<Course> GetCoursesAssigned (int tId)
        {
            List<CourseAssignment> listCA = new List<CourseAssignment>();
            List<Course> listCourseAssigned = new List<Course>();
            XmlSerializer formatter = new XmlSerializer(typeof(List<CourseAssignment>));
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, (int)fs.Length);
            MemoryStream stream = new MemoryStream(buffer);
            listCA = (List<CourseAssignment>)formatter.Deserialize(stream);
            fs.Close();
          
            foreach (var item in listCA)
            {
                if (item.EmployeeNumber == tId)
                {
                    Course aCourse = new Course();
                    aCourse = CourseDA.SearchRecord(item.CourseNumber);
                    listCourseAssigned.Add(aCourse);

                }

            }
           
           return listCourseAssigned;
        }

        public static List<CourseAssignment> GetAllCoursesAssigned()
        {
            List<CourseAssignment> listCA = new List<CourseAssignment>();
            XmlSerializer formatter = new XmlSerializer(typeof(List<CourseAssignment>));
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, (int)fs.Length);
            MemoryStream stream = new MemoryStream(buffer);
            listCA = (List<CourseAssignment>)formatter.Deserialize(stream);
            fs.Close();
            return listCA;
        }

    }
}
