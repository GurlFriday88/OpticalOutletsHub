using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticalOutletsHub.Models
{
    public class MemoCategories
    {
        //Memobuilder options 
        public  int ID { get; set; }

        public virtual string CategoryName { get; set; }

        public virtual string Description { get; set; }



    }
}
