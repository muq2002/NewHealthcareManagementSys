using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareManagement.Model
{
    class TestGroupModel
    {

        public int ID;
        public string GroupName;

        public TestGroupModel() { }

        public TestGroupModel(int ID, string GroupName)
        {
            this.ID = ID;
            this.GroupName = GroupName;
        }
    }
}
