using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareManagement.Model
{
    class UserModel
    {
        public string Username;
        public string Password;
        public string Permission;

        UserModel(string username, string password, string permission)
        {
            this.Username = username;
            this.Password = password;
            this.Permission = permission;
        }
    }
}
