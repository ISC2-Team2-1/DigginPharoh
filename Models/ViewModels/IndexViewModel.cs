using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigginPharoh.Models.ViewModels
{
    public class IndexViewModel
    {
        public List<Burial> BurialList { get; set; }
        public List<BurialIDInfo> BurialIDInfoList { get; set; }
        public List<BiologicalSamples> BiologicalSampleList { get; set; }
        public List<Carbon_Dating> Carbon_DatingList { get; set; }
        public List<Cranial> CranialList { get; set; }
        public List<Note> NoteList { get; set; }
    }
}
