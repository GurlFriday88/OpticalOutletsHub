using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticalOutletsHub.Models
{
    public class MemoCategories
    {
        public virtual int MemoCategoryID { get; set; }

        //Look back over one to many relationships to figure out which classes get what properties before building ef

        public virtual int MemoID { get; set; }

        public virtual string MemoName { get; set; }

        public virtual string Description { get; set; }
    }
}
