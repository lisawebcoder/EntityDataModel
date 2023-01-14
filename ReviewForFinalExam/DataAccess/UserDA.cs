using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FinalExam.Business;

namespace FinalExam.DataAccess
{
    public static class UserDA
    {
        static string filePath = Environment.CurrentDirectory + @"\Users.dat";
        public static bool VerifyLogin (User aUser)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line = reader.ReadLine();
                while (line !=null)
                {
                    string[] fields = line.Split(',');
                    if ((aUser.UserId == Convert.ToInt32(fields[0])) && (aUser.Password == fields[1]))
                    {
                        return true;
                    }
                    line = reader.ReadLine();
                }

            }

            return false;
        }

    }
}
