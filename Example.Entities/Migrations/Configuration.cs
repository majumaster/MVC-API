namespace Example.Entities.Migrations
{
    using Example.Entities.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Example.Entities.AddDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Example.Entities.AddDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            if (!context.Categories.Any())
            {
                var category = new Category()
                {
                    Name = "Motoryzacja"
                };
                context.Categories.Add(category);
                context.SaveChanges();

                if (!context.Products.Any())
                {
                    var product1 = new Product()
                    {
                        Name = "Samochod",
                        CategoryId = category.Id,
                        Price = 100
                    };
                    var product2 = new Product()
                    {
                        Name = "Bus",
                        CategoryId = category.Id,
                        Price = 50
                    };

                    context.Products.Add(product1);
                    context.Products.Add(product2);
                    context.SaveChanges();
                }

                
            }

        }
    }
}
