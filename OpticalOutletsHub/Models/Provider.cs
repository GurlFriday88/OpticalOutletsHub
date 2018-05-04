using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticalOutletsHub.Models
{
    public class Provider
    {
        public int ProviderID { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string SubscriberNumber { get; set; }

        public string BenefitRenewal { get; set; }

        public string AuthNote { get; set; }

        public IList<Patient> Eligibility { get; set; }

    }
}
