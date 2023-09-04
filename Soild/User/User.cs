using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soild.User
{
    public class User
    {
        public int  Id { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public User(int id, string firstName, string lastName, string mobile, string userName, string passWord)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Mobile = mobile;
            UserName = userName;
            PassWord = passWord;
        }
    }
}
