using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticalOutletsHub.Models
{
    public class Memo
    {
        public virtual int MemoID { get; set; }

        public virtual List<MemoCategories> MemoItems { get; set; }

    }
}
