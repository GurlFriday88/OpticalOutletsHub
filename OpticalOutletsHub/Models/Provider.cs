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

        public virtual string PhoneNumber { get; set; }

        public virtual string SubscriberNumber { get; set; }

        public virtual string BenefitRenewal { get; set; }

        public virtual string AuthNote { get; set; }

        public virtual int NumPagesToSave { get; set; }

        public string DescriptionPagesToSave { get; set; }

        public virtual string MiscNotes { get; set; }

        //One to many relationship between provider and BCBS prefixes because a provider can belong to many prefixes

        public IList<Patient> Patients { get; set; }

        public virtual IList<BcbsPrefix> BcbsPrefixes { get; set; }

    }
}
