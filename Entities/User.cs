using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github_user_activity.Entities {
    internal class User {
        public string Username { get; set; }
        public string Token { get; set; }

        public User(string username, string token) {
            Username = username;
            Token = token;
        }
    }
}
