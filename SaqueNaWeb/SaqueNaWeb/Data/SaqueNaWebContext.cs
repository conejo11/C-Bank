using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SaqueNaWeb.Models
{
    public class SaqueNaWebContext : DbContext
    {
        public SaqueNaWebContext (DbContextOptions<SaqueNaWebContext> options)
            : base(options)
        {
        }

        public DbSet<SaqueNaWeb.Models.Log> Log { get; set; }
    }
}
