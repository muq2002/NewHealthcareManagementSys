using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareManagement.Model
{
    class SessionModel
    {
        public int ID;
        public int PatientID;
        public string SessionName;


        public SessionModel() { }

        public SessionModel(int PatientID, string SessionName)
        {
            this.PatientID = PatientID;
            this.SessionName = SessionName;
        }
        public SessionModel(int ID, int PatientID, string SessionName)
        {
            this.ID = ID;
            this.PatientID = PatientID;
            this.SessionName = SessionName;
        }
    }
}
