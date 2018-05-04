using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticalOutletsHub.Models
{
    public class BcbsPrefix
    {
        public virtual int PrefixID { get; set; }

        public virtual int ProviderID { get; set; }

        public virtual string PrefixName { get; set; }

        public virtual Provider Provider { get; set; }
    }
}
