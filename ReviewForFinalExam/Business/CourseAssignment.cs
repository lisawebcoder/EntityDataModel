using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalExam.DataAccess;

namespace FinalExam.Business
{
   public class CourseAssignment
    {
        public int EmployeeNumber { get; set; }
        public string CourseNumber { get; set; }
        public DateTime AssignedDate { get; set; }

        public void SaveCoursesAssigned (List<CourseAssignment> ca)
        {
            CourseAssignmentDA.SaveRecords(ca);

        }

        public List<Course> GetCourseList(int teacherId)
        {
           return CourseAssignmentDA.GetCoursesAssigned(teacherId);
        }

        public List<CourseAssignment> GetAllCoursesAssigned()
        {
            return CourseAssignmentDA.GetAllCoursesAssigned();
        }
    }
}
