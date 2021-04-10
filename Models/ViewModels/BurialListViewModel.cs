using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigginPharoh.Models.ViewModels
{
    public class BurialListViewModel
    {
            public IEnumerable<Burial> Burials { get; set; }
            public PagingInfo PagingInfo { get; set; }
    }
}
