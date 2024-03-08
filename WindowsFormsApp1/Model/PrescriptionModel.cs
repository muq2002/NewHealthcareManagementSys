using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareManagement.Model
{
    class PrescriptionModel
    {
        public int ID;
        public int PatientID;
        public int SessionID;
        public int DrugID;
        public string Instruction;

        public PrescriptionModel() { }

        public PrescriptionModel(int ID, int PatientID, int SessionID, int DrugID,
            string Instruction)
        {
            this.ID = ID;
            this.PatientID = PatientID;
            this.SessionID = SessionID;
            this.DrugID = DrugID;
            this.Instruction = Instruction;

        }
    }
}
