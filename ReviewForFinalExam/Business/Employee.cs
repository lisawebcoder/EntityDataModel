using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalExam.DataAccess;

//EmployeeNumber
//FirstName
//LastName
//HomePhone
//Email
//JobTitle
namespace FinalExam.Business
{
   public class Employee
    {
        public int EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  HomePhone { get; set; }
        public string Email { get; set; }
        public string  JobTitle { get; set; }

        public List<Employee> GetListEmployee()
        {
            return EmployeeDA.GetAllRecords();
        }

        public Employee SearchEmployee(int empId)
        {
            return EmployeeDA.SearchRecord(empId);
        }

    }
}
