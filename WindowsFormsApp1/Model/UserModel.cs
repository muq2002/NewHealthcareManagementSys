using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareManagement.Model
{
    class UserModel
    {
        public int ID;
        public string Username;
        public string Password;
        public string Permission;

        UserModel(int id, string username, string password, string permission)
        {
            this.ID = id;
            this.Username = username;
            this.Password = password;
            this.Permission = permission;
        }
        UserModel(string username, string password, string permission)
        {
            this.Username = username;
            this.Password = password;
            this.Permission = permission;
        }
    }
}
