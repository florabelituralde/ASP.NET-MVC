using Microsoft.EntityFrameworkCore;
using DemoDatabase.Models;

namespace DemoDatabase.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movies> Movies { get; set; }
    }
}
