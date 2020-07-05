using Calendar.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CalendarContext(
                serviceProvider.GetRequiredService<DbContextOptions<CalendarContext>>()))
            {
                // Look for any tasks
                if (context.Task.Any())
                {
                    return;  // DB already has been seeded
                }

                context.Task.AddRange(
                    new Models.Task
                    {
                        Name = "First Task",
                        Priority = 1,
                        ScheduledDate = DateTime.Now,
                        Notes = "First Notes"
                    },

                    new Models.Task
                    {
                        Name = "Second Task",
                        Priority = 1,
                        ScheduledDate = DateTime.Now,
                        Notes = "Second Notes"
                    },

                    new Models.Task
                    {
                        Name = "Third Task",
                        Priority = 1,
                        ScheduledDate = DateTime.Now,
                        Notes = "Third Notes"
                    },

                    new Models.Task
                    {
                        Name = "Fourth Task",
                        Priority = 1,
                        ScheduledDate = DateTime.Now,
                        Notes = "Fourth Notes"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
