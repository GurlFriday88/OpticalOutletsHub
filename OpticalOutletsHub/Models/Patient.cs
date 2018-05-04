using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticalOutletsHub.Models
{
    public class Patient
    {
        public virtual int PatientID { get; set; }

        public virtual int ProviderID { get; set; }

        public virtual string PatientType { get; set; }

        public virtual string Exam { get; set; }

        public virtual string Frame { get; set; }

        public virtual string Lens { get; set; }
    }
}
