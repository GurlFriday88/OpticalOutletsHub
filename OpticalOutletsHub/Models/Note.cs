using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticalOutletsHub.Models
{
    public class Note
    {

        public virtual int NoteID { get; set; }

        public virtual int ProviderID { get; set; }


        public virtual string SavedPage { get; set; }


        public virtual string MiscNotes { get; set; }


    }
}
