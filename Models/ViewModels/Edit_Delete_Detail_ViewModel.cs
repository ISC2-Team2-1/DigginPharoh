using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigginPharoh.Models.ViewModels
{
    public class Edit_Delete_Detail_ViewModel
    {
        public IQueryable<Burial> BurialList { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public Burial burialToEdit { get; internal set; }
    }
}
