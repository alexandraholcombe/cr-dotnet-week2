using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SonOfCod.Models
{
    public static class DbContextExtensions
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var context = app.ApplicationServices.GetRequiredService<SOCContext>())
            {
                // perform database delete
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                // Perform seed operations
                AddContent(context);

                // Save changes and release resources
                context.SaveChanges();
                context.Dispose();
            }

        }

        private static void AddContent(SOCContext context)
        {
            context.AddRange(
                new Content
                {
                    Title = "World's Best Seafood",
                    Type = "funblurb",
                    Text = "We expect ourselves to do business right, to lead by example and to help out when we are needed. It is our company philosophy that guides our everyday decisions. It is good to be responsible, not just because it is the right thing to do, but because it also sets the bar for our company’s commitment to ensure that the communities in which we work and live will continue to prosper.",
                    ClickText = "Learn more",
                    ClickView = "Index",
                    ClickController = "Home"
                }
            );
        }
    }
}
