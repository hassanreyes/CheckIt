namespace CheckIt.Domain.Migrations
{
    using CheckIt.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CheckIt.Domain.CheckItContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CheckIt.Domain.CheckItContext context)
        {
            //  This method will be called after migrating to the latest version.

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

            context.Users.AddOrUpdate(
                u => u.UserName,
                new User { UserName = "Administrator", PasswordHash = "", Email = "hassan.reyes@gmail.com"},
                new User { UserName = "_Temp_", PasswordHash = "", IsTemporal = true}
                );
        }
    }
}
