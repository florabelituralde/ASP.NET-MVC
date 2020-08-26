using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoDatabase.Models;

namespace DemoDatabase.Data
{
    public class DemoDatabaseContext : DbContext
    {
        public DemoDatabaseContext (DbContextOptions<DemoDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<DemoDatabase.Models.Movies> Movies { get; set; }
    }
}
