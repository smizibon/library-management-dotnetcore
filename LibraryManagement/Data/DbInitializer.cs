using LibraryManagement.Data.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Data
{

    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<LibraryDBContext>();


                // Add Customers
                var murad = new Customer { Name = "Murad ChowDhury" };

                var oishi = new Customer { Name = "Oishi Mahmud" };

                var tanvir = new Customer { Name = "Tanvir Ahmed" };

                context.Customers.Add(murad);
                context.Customers.Add(oishi);
                context.Customers.Add(tanvir);

                // Add Author
                var authorFaysal = new Author
                {
                    Name = "Faysal Ahmed",
                    Books = new List<Book>()
                {
                    new Book { Title = "The Millionaire Fastlane" },
                    new Book { Title = "Unscripted" }
                }
                };

                var authorSUnnat = new Author
                {
                    Name = "SUnnat",
                    Books = new List<Book>()
                {
                    new Book { Title = "The 10X Rule"},
                    new Book { Title = "If You're Not First, You're Last"},
                    new Book { Title = "Sell To Survive"}
                }
                };

                context.Authors.Add(authorFaysal);
                context.Authors.Add(authorSUnnat);

                context.SaveChanges();
            }
        }
    }
}

