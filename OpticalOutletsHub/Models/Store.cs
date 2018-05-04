using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticalOutletsHub.Models
{
    public class Store
    {
        public virtual int StoreID { get; set; }

        public virtual string StoreName { get; set; }

        public virtual string Address { get; set; }

        public virtual string City { get; set; }

        public virtual string State { get; set; }

        public virtual int ZipCode { get; set; }

        public virtual int PhoneNumber { get; set; }
    }
}
