using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticalOutletsHub.Models
{
    public class Note
    {

        public int NoteID { get; set; }


        public string SavedPages { get; set; }

        public IList<Provider> Location { get; set; }

        public string MiscNotes { get; set; }

        public IList<Patient> Eligibility { get; set; }
    }
}
