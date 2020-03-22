using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerSorcerer.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            // Running the migrate command to make sure the database and table exists 
            context.Database.Migrate();

            // Seed data from this file only when there's no Club in the Database already
            if (!context.Clubs.Any())
            {
                // Preparing data to seed into the database
                context.Clubs.AddRange(
                    new Club
                    {
                        Name = "Juventus",
                        Manager = "Michael Someone",
                        Stadium = "ABC Stadium",
                        Owner = "Michael Something",
                        Website = "www.example.com",
                        Location = "Ontario",
                        Description = "World class players. A football club can't get any better."
                    },
                    new Club
                    {
                        Name = "Soccer Sorcerer",
                        Manager = "Shail Napster",
                        Stadium = "Best Stadium",
                        Owner = "Shail Napster",
                        Website = "www.shailendrashukla.com",
                        Location = "Yukon",
                        Description = "We don't play sport, we breathe sport. A few more lines of club description."
                    }
                );

                // Saving all the Clubs added to the context to the database
                context.SaveChanges();
            }
        }
    }
}

