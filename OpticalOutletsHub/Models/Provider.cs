using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticalOutletsHub.Models
{
    public class Provider
    {
        public virtual int ProviderID { get; set; }

        public virtual string Name { get; set; }

        public virtual int PhoneNumber { get; set; }

        public virtual string SubscriberNumber { get; set; }

        public virtual string BenefitRenewal { get; set; }

        public virtual string AuthNote { get; set; }

        public virtual List<Patient> Patients { get; set; }

        public virtual List<BcbsPrefix> BcbsPrefixes { get; set; }

    }
}
