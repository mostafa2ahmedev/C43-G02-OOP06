using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public required string Role { get; set; }
        public bool AuthenticateUser(string userName, string password)
        {
            if (userName == this.UserName && password==this.Password) {
                return true;
           }
            return false;
           
        }

        public bool AuthorizeUser(string role)
        {
            if (role == this.Role) { 
            return true ;
            }
            return false ;
        }
    }
}
