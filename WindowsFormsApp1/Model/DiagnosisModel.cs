using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareManagement.Model
{
    class DiagnosisModel
    {
        public int ID;
        public int PatientID;
        public int SessionID;
        public string Comments;
        public string AutoDiagnosis;

        public DiagnosisModel() { }

        public DiagnosisModel(int ID, int PatientID, int SessionID, string Comments,
            string AutoDiagnosis)
        {
            this.ID = ID;
            this.PatientID = PatientID;
            this.SessionID = SessionID;
            this.Comments = Comments;
            this.AutoDiagnosis = AutoDiagnosis;

        }
    }
}
