using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticalOutletsHub.Models
{
    public class ProviderNote
    {
        public int ProviderNoteID { get; set; }

        public int NoteID { get; set; }

        public int ProviderID { get; set; }

        public int PrefixID { get; set; }
    }
}
