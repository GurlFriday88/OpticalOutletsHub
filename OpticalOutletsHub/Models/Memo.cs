using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticalOutletsHub.Models
{
    public class Memo
    {
        public virtual int MemoID { get; set; }

        //A category can belong to several memos but there can only be one of each category to a memo at a time so there is a one to many relationship between the two 

        public int MemoCategoryID { get; set; }

        public virtual List<MemoCategories> MemoChoices { get; set; }

       


    }
}
