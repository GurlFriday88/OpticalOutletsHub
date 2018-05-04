using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticalOutletsHub.Models
{
    public class MemoCategories
    {
        public int MemoCategoryID { get; set; }

        //Look back over one to many relationships to figure out which classes get what properties before building ef

        public int MemoID { get; set; }

        public string MemoName { get; set; }

        public string Description { get; set; }
    }
}
