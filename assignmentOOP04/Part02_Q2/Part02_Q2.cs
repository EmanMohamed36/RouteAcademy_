using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part02_Q2
{
        public interface IAuthenticationService
        {
            bool AuthenticateUser(string username, string password);
            bool AuthorizeUser(string username, string role);
        }

        public class BasicAuthenticationService : IAuthenticationService
        {
            private readonly Dictionary<string, string> _users = new Dictionary<string, string>
            {
                { "Eman", "12345" },
                { "Mohamed", "6789" }
            };

            private readonly Dictionary<string, List<string>> _userRoles = new Dictionary<string, List<string>>
            {
                { "Eman", new List<string> { "admin", "user" } },
                { "Mohamed", new List<string> { "user" } }
            };

            public bool AuthenticateUser(string username, string password)
            {
                return _users.ContainsKey(username) && _users[username] == password;
            }

            public bool AuthorizeUser(string username, string role)
            {
                return _userRoles.ContainsKey(username) && _userRoles[username].Contains(role);
            }
        }

    
}
