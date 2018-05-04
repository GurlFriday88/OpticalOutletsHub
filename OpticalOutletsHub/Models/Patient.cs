using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticalOutletsHub.Models
{
    public class Patient
    {
        public int PatientID { get; set; }

        public string PatientType { get; set; }

        public string Exam { get; set; }

        public string Frame { get; set; }

        public string Lens { get; set; }
    }
}
