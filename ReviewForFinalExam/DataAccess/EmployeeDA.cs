using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FinalExam.Business;

namespace FinalExam.DataAccess
{
   public static  class EmployeeDA
    {
        static string dir = @"";
        static string filePath = dir + "Employees.dat";
        public static List<Employee> GetAllRecords()
        {
            List<Employee> listE = new List<Employee>();
            using (StreamReader sReader = new StreamReader(filePath))
            {
                string line = sReader.ReadLine();
                Employee emp;
                while (line !=null)
                {
                    emp = new Employee();
                    string[] fields = line.Split(',');
                    emp.EmployeeNumber = Convert.ToInt32(fields[0]);
                    emp.FirstName = fields[1];
                    emp.LastName = fields[2];
                    emp.HomePhone = fields[3];
                    emp.Email = fields[4];
                    emp.JobTitle = fields[5];
                    listE.Add(emp);
                    line = sReader.ReadLine();

                }

            }

            return listE;
        }


        public static Employee SearchRecord(int eId)
        {
            Employee emp = new Employee();
            List<Employee> listE = GetAllRecords();
            foreach (var itemE in listE)
            {
                if (itemE.EmployeeNumber == eId)
                {
                    emp.EmployeeNumber = itemE.EmployeeNumber;
                    emp.FirstName = itemE.FirstName;
                    emp.LastName = itemE.LastName;
                    emp.JobTitle = itemE.JobTitle;
                    return emp;
                }
            }

            return null;

        }


    }
}
