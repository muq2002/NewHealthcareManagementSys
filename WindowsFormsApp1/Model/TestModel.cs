using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareManagementSystem.Model
{
    class TestModel
    {
        public int ID;
        public int PatientID;
        public int SessionID;
        public int TestID;

        public string TestValue;
        public string Comment;
        public string RegisterDate;

        public TestModel() { }
        public TestModel(int ID, int PatientID, int SessionID, int TestID,
            string TestValue, string Comment, string RegisterDate)
        {
            this.ID = ID;
            this.PatientID = PatientID;
            this.SessionID = SessionID;
            this.TestID = TestID;
            this.TestValue = TestValue;
            this.Comment = Comment;
            this.RegisterDate = RegisterDate;

        }

        public TestModel(int PatientID, int TestID,
            string TestValue, string Comment, string RegisterDate)
        {

            this.PatientID = PatientID;
            this.TestID = TestID;
            this.TestValue = TestValue;
            this.Comment = Comment;
            this.RegisterDate = RegisterDate;

        }
    }
}
