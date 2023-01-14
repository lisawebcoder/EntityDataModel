using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalExam.DataAccess;

//UserId
//Password
namespace FinalExam.Business
{
   public  class User
    {
        public int UserId { get; set; }
        public string Password { get; set; }

        public bool IsValidLogin(User user)
        {
            return UserDA.VerifyLogin(user);
        }

    }
}
