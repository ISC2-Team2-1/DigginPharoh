using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigginPharoh.Models
{
    public class BiologicalSamplesContext : DbContext
    {
        public BiologicalSamplesContext(DbContextOptions<BiologicalSamplesContext> options) : base(options)
        {

        }

        public DbSet<BiologicalSamples> BiologicalSamplesSet { get; set; }
    }
}
