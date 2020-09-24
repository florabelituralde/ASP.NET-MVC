using Microsoft.EntityFrameworkCore;
using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Data
{
    public class MovieAppContext
    {
        public MovieAppContext(DbContextOptions<MovieAppContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
