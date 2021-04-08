using DigginPharoh.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigginPharoh.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            ApplicationDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<ApplicationDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        ISBN = "978-0451419439",
                        Title = "Les Miserables",
                        AuthorFName = "Victor",
                        AuthorLName = "Hugo",
                        Publisher = "Signet",
                        Classification = "Non-Fiction",
                        Category = "Classic",
                        Price = 9.95F,
                        PageNum = 1488
                    },
                    new Book
                    {
                        ISBN = "978-0743270755",
                        Title = "Team of Rivals",
                        AuthorFName = "Doris",
                        AuthorLName = "Goodwin",
                        Publisher = "Simon & Schuster",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58F,
                        PageNum = 944

                    },
                    new Book
                    {
                        ISBN = "978-0553384611",
                        Title = "The Snowball",
                        AuthorFName = "Alice",
                        AuthorLName = "Schroeder",
                        Publisher = "Bantam",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54F,
                        PageNum = 832
                    },
                    new Book
                    {
                        ISBN = "978-0812981254",
                        Title = "American Ulysses",
                        AuthorFName = "Ronald",
                        AuthorLName = "White",
                        Publisher = "Random House",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61F,
                        PageNum = 864
                    },
                    new Book
                    {
                        ISBN = "978-0812974492",
                        Title = "Unbroken",
                        AuthorFName = "Laura",
                        AuthorLName = "Hillenbrand",
                        Publisher = "Random House",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33F,
                        PageNum = 528
                    },
                    new Book
                    {
                        ISBN = "978-0804171281",
                        Title = "The Great Train Robbery",
                        AuthorFName = "Micheal",
                        AuthorLName = "Crichton",
                        Publisher = "Vintage",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95F,
                        PageNum = 288
                    },
                    new Book
                    {
                        ISBN = "978-1455586691",
                        Title = "Deep Work",
                        AuthorFName = "Cal",
                        AuthorLName = "Newport",
                        Publisher = "Grand Central Publishing",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99F,
                        PageNum = 304
                    },
                    new Book
                    {
                        ISBN = "978-1455523023",
                        Title = "It's Your Ship",
                        AuthorFName = "Michael",
                        AuthorLName = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 29.66F,
                        PageNum = 240
                    },
                    new Book
                    {
                        ISBN = "978-1591847984 ",
                        Title = "The Virgin Way",
                        AuthorFName = "Richard",
                        AuthorLName = "Branson",
                        Publisher = "Portfolio",
                        Classification = "Non-Fiction",
                        Category = "Buisness",
                        Price = 29.16F,
                        PageNum = 400
                    },
                    new Book
                    {
                        ISBN = "978-0553393613",
                        Title = "Sycamore Row",
                        AuthorFName = "Josh",
                        AuthorLName = "Grisham",
                        Publisher = "Bantam",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 15.03F,
                        PageNum = 642
                    },
                    new Book
                    {
                        ISBN = "978-0465062881",
                        Title = "Endurance",
                        AuthorFName = "Alfred",
                        AuthorLName = "Lansing",
                        Publisher = "Basic Books",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 14.97F,
                        PageNum = 357
                    },
                    new Book
                    {
                        ISBN = "978-0553393613",
                        Title = "Misbehaving",
                        AuthorFName = "Richard",
                        AuthorLName = "Thaler",
                        Publisher = "W.W. Norton & Company",
                        Classification = "Non-Fiction",
                        Category = "Economic History",
                        Price = 14.47F,
                        PageNum = 432
                    },
                    new Book
                    {
                        ISBN = "978-0553393613",
                        Title = "Ready Player One",
                        AuthorFName = "Ernest",
                        AuthorLName = "Cline",
                        Publisher = "Ballentine Books",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 12.78F,
                        PageNum = 384
                    }


                );

                context.SaveChanges();

            }
        }
    }
}

