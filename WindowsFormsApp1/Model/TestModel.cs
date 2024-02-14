using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class TestModel
    {
        public int ID;
        public int PatientID;
        public int TestID;
        public string TestValue;
        public string Comment;
        public string RegisterDate;

        public TestModel() { }
        public TestModel(int PatientID, int TestID,
            string TestValue, string Comment, string RegisterDate)
        {

            this.PatientID = PatientID;
            this.TestID = TestID;
            this.TestValue = TestValue;
            this.Comment = Comment;
            this.RegisterDate = RegisterDate;

        }

        //public TestModel(int PatientID, string PatientName, int PatientAge,
        //    int PatientGender, string ImagePath, string RegisterDate)
        //{
        //    this.PatientID = PatientID;
        //    this.PatientName = PatientName;
        //    this.PatientAge = PatientAge;
        //    this.PatientGender = PatientGender;
        //    this.ImagePath = ImagePath;
        //    this.RegisterDate = RegisterDate;

        //}
    }
}
