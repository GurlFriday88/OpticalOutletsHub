using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticalOutletsHub.Models
{
    public class Memo
    {
        public int MemoID { get; set; }

        public IList<MemoCategories> MemoItems { get; set; }

    }
}
