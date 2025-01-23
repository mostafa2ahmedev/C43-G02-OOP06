using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal interface IAuthenticationService
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        bool AuthenticateUser(string userName,string password);
        bool AuthorizeUser(string role);
    }
}
