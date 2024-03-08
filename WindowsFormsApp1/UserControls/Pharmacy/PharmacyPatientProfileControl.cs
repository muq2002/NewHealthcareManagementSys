using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthcareManagement.UserControls.Pharmacy
{
    public partial class PharmacyPatientProfileControl : UserControl
    {
        public int patientId { get; set; }
        public PharmacyPatientProfileControl()
        {
            InitializeComponent();
        }
    }
}
