using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigginPharoh.Models
{
    public class CranialContext : DbContext
    {
        public CranialContext(DbContextOptions<CranialContext> options) : base(options)
        {

        }

        public DbSet<Cranial> CranialSet { get; set; }
    }
}
