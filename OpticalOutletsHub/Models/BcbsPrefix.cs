using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticalOutletsHub.Models
{
    public class BcbsPrefix
    {
        public int ID { get; set; }

        
        public string Prefix { get; set; }

        //foreign key linking a provider to a prefix

        public int ProviderID { get; set; }

        public Provider Provider { get; set; }
    }
}
