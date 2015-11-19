namespace CQCMXY.WexXin.Data.Entity.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CQCMXY.WeiXin.Data.Entity.Db>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(CQCMXY.WeiXin.Data.Entity.Db context)
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

            context.Database.ExecuteSqlCommand("CREATE UNIQUE INDEX AppTokenInfoId ON AppInterfaceInfo (AppTokenInfoId)");
            context.Database.ExecuteSqlCommand("CREATE UNIQUE INDEX AppTitle ON AppTokenInfo (AppTitle)");
            context.Database.ExecuteSqlCommand("CREATE UNIQUE INDEX appID ON AppTokenInfo (appID)");
            context.Database.ExecuteSqlCommand("CREATE UNIQUE INDEX appsecret ON AppTokenInfo (appsecret)");
        }
    }
}
