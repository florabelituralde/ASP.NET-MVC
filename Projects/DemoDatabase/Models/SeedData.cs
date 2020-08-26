using DemoDatabase.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;


namespace DemoDatabase.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DemoDatabaseContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DemoDatabaseContext>>()))
            {
                // Look for any movies.
                if (context.Movies.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movies.AddRange(
                    new Movies
                    {
                        Title = "When Harry Met Sally",
                        Release = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Rating = "R",
                        Price = 7.99M
                    },

                    new Movies
                    {
                        Title = "Ghost busters ",
                        Release = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Rating = "R",
                        Price = 8.99M
                    },

                    new Movies
                    {
                        Title = "Ghost busters 2",
                        Release = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Rating = "R",
                        Price = 9.99M
                    },

                    new Movies
                    {
                        Title = "Rio Bravo",
                        Release = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Rating = "R",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
