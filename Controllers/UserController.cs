using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace POC.User.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController()
        {
            
        }

        [HttpGet, Route("{id}")]
        public User Get(int id) 
        {
            List<User> retVal = new List<User>();
            retVal.Add(new User(1,"John", 23, "john.doe@google.com"));
            retVal.Add(new User(2,"James", 24, "james.harry@hogwarts.edu"));
            return retVal.FirstOrDefault(x => x.UserId == id);
        }
    }
}