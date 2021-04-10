using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigginPharoh.Models.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Burial> BurialList { get; set; }
        public IEnumerable<BurialIDInfo> BurialIDInfoList { get; set; }
        public IEnumerable<BiologicalSamples> BiologicalSampleList { get; set; }
        public IEnumerable<Carbon_Dating> Carbon_DatingList { get; set; }
        public IEnumerable<Cranial> CranialList { get; set; }
        public IEnumerable<Note> NoteList { get; set; }
        public PagingInfo PagingInfo { get; set; }

        public bool HasHead;



    }

}
