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
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(HboDbContext context)
        {
            context.Users.AddOrUpdate(new User
            {
                Id = 1,
                EmailAddress = "info@jonnypillar.co.uk",
                FirstName = "Jonny",
                SecondName = "Pillar",
                IsAdmin = true,
                PasswordHash = "BBEAC5BC79205B399DCE4D822A15CF35CDE10CEB3957568BFAE58B6EC1C0226C",
                PasswordSalt = "000234E23D29479DF8B47FAFE00328CA5FA177290C7A63F8EB6DA2B7C6F0CD55",
                LastLoggedIn = DateTime.UtcNow,
                CreatedDateTime = DateTime.UtcNow
            });

            context.Users.AddOrUpdate(new User
            {
                Id = 2,
                EmailAddress = "admin@adminaccount.co.uk",
                FirstName = "Main",
                SecondName = "Admin",
                IsAdmin = true,
                //123abc
                PasswordHash = "A5154F3A50C3C368FB78F63D23C2676EE08C001737B9773D99AAD181D5252BEF",
                PasswordSalt = "205A6E257F39B9971CC4C8623225088E6B60462E287A45607DEF55CA35833DC1",
                LastLoggedIn = DateTime.UtcNow,
                CreatedDateTime = DateTime.UtcNow
            });

            context.Users.AddOrUpdate(new User
            {
                Id = 2,
                EmailAddress = "nonadmin@adminaccount.co.uk",
                FirstName = "Non",
                SecondName = "Admin",
                IsAdmin = true,
                PasswordHash = "A5154F3A50C3C368FB78F63D23C2676EE08C001737B9773D99AAD181D5252BEF",
                PasswordSalt = "205A6E257F39B9971CC4C8623225088E6B60462E287A45607DEF55CA35833DC1",
                LastLoggedIn = DateTime.UtcNow,
                CreatedDateTime = DateTime.UtcNow
            });

            context.SaveChanges();
        }
    }
}