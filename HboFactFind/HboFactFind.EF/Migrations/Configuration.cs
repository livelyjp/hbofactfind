using System;
using System.Data.Entity.Migrations;
using HboFactFind.Domain;

namespace HboFactFind.EF.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<HboDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(HboDbContext context)
        {
            //  This method will be called after migrating to the latest version.



            //context.Users.AddOrUpdate(new User()
            //{
            //    Id = 1,
            //    EmailAddress = "info@jonnypillar.co.uk",
            //    FirstName = "Jonny",
            //    SecondName = "Pillar",
            //    IsAdmin = true,

            //    LastLoggedIn = DateTime.UtcNow,
            //    CreatedDateTime = DateTime.UtcNow
            //});

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}