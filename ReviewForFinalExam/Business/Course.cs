using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalExam.DataAccess;
//CourseNumber
//CourseTitle
//TotalHour
namespace FinalExam.Business
{
    public class Course
    {
        public string  CourseNumber { get; set; }
        public string  CourseTitle { get; set; }
        public int TotalHour { get; set; }

        public List<Course> GetAllCourses()
        {
            return CourseDA.GetAllRecords();
        }

        

    }
}
