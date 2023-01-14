using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalExam.Business;
using System.IO;

namespace FinalExam.DataAccess
{
    public static class CourseDA
    {
        static string dir = @"";
        static string filePath = dir + "Courses.dat";

        public static List<Course> GetAllRecords()
        {
            List<Course> listC = new List<Course>();
            using (StreamReader sReader = new StreamReader(filePath))
            {
                string line = sReader.ReadLine();
                Course course;
                while (line != null)
                {
                    course = new Course();
                    string[] fields = line.Split(',');
                    course.CourseNumber = fields[0];
                    course.CourseTitle = fields[1];
                    course.TotalHour = Convert.ToInt32(fields[2]);
                    listC.Add(course);
                    line = sReader.ReadLine();

                }

            }

            return listC;
        }

        public static Course SearchRecord(string cNum)
        {
            List<Course> listC = GetAllRecords();
            Course course = new Course();
            foreach (var item in listC)
            {
                if (item.CourseNumber == cNum)
                {
                    course.CourseNumber = item.CourseNumber;
                    course.CourseTitle = item.CourseTitle;
                    course.TotalHour = item.TotalHour;
                    break;
                }
            }

            return course;
        }

    }
}
