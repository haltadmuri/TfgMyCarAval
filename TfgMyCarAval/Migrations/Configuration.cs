using TfgMyCarAval.Models;
namespace TfgMyCarAval.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    internal sealed class Configuration : DbMigrationsConfiguration<TfgMyCarAval.Models.ProductContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TfgMyCarAval.Models.ProductContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.




            try
            {
                context.Products.AddOrUpdate(
                p => p.ProductName,
                new Product { ProductName = "Localizacion", Description = "ASFASFA" },
                new Product { ProductName = "Llamadas", Description = "213132SAD" },
                new Product { ProductName = "Mobil", Description = "SDASD" }
                );

                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
    }
}
