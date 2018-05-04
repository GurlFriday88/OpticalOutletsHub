using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticalOutletsHub.Models
{
    public class Store
    {
        public int StoreID { get; set; }

        public string StoreName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int ZipCode { get; set; }

        public int PhoneNumber { get; set; }
    }
}
