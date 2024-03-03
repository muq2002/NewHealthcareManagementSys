using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareManagement.Model
{
    class TestsBankModel
    {
        public int ID;
        public string TestName;
        public string GroupRelated;

        public TestsBankModel() { }

        public TestsBankModel(int ID, string TestName, string GroupRelated)
        {
            this.ID = ID;
            this.TestName = TestName;
            this.GroupRelated = GroupRelated;
        }
    }
}
