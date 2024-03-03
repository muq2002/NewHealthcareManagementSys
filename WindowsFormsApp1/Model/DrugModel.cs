using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareManagementSystem.Model
{
    class DrugModel
    {
        public int ID;
        public string DrugName;
        public int CostPrice;
        public int SellingPrice;
        public string TherapeuticAreas;
        public string Company;
        public string SpecificTreatment;
        public string ExpireDate;

        public DrugModel() { }

        public DrugModel(int ID, string DrugName, int CostPrice, int SellingPrice,
            string TherapeuticAreas, string Company, string SpecificTreatment, string ExpireDate)
        {
            this.ID = ID;
            this.DrugName = DrugName;
            this.CostPrice = CostPrice;
            this.SellingPrice = SellingPrice;
            this.TherapeuticAreas = TherapeuticAreas;
            this.Company = Company;
            this.SpecificTreatment = SpecificTreatment;
            this.ExpireDate = ExpireDate;

        }

    }
}
