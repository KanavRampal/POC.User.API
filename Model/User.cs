using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC.User.API
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public User(int id,string name, int age, string email)
        {
            this.UserId = id;
            this.Age = age;
            this.Name = name;
            this.Email = email;
        }
    }
}
