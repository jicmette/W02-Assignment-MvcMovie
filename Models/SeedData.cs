using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "The Lord of the Rings: The Fellowship of the Ring",
                    ReleaseDate = DateTime.Parse("2001-12-19"),
                    Genre = "Fantasy",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "The Lord of the Rings: The Two Towers",
                    ReleaseDate = DateTime.Parse("2002-12-18"),
                    Genre = "Fantasy",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "The Lord of the Rings: The Return of the King",
                    ReleaseDate = DateTime.Parse("2003-12-17"),
                    Genre = "Fantasy",
                    Price = 9.99M
                },

                // Add The Hobbit trilogy
                new Movie
                {
                    Title = "The Hobbit: An Unexpected Journey",
                    ReleaseDate = DateTime.Parse("2012-12-14"),
                    Genre = "Fantasy",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "The Hobbit: The Desolation of Smaug",
                    ReleaseDate = DateTime.Parse("2013-12-13"),
                    Genre = "Fantasy",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "The Hobbit: The Battle of the Five Armies",
                    ReleaseDate = DateTime.Parse("2014-12-17"),
                    Genre = "Fantasy",
                    Price = 8.99M
                }
            );

            context.SaveChanges();
        }
    }
}