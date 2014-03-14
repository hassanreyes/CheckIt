namespace CheckIt.Domain.Migrations
{
    using CheckIt.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Text;

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

            //NLog table
            StringBuilder sqlCmd = new StringBuilder();

            sqlCmd.Append("IF NOT EXISTS (SELECT * FROM SysObjects WHERE Name='Logging' AND Xtype='U') ");
            sqlCmd.Append("CREATE TABLE [dbo].[Logging]( ");
            sqlCmd.Append("[Id] [int] IDENTITY(1,1) NOT NULL, ");
            sqlCmd.Append("[EventDateTime] [datetime] NOT NULL, ");
            sqlCmd.Append("[EventLevel] [nvarchar](100) NOT NULL, ");
            sqlCmd.Append("[MachineName] [nvarchar](100) NOT NULL, ");
            sqlCmd.Append("[EventMessage] [nvarchar](max) NOT NULL, ");
            sqlCmd.Append("[ErrorSource] [nvarchar](100) NULL, ");
            sqlCmd.Append("[ErrorClass] [nvarchar](500) NULL, ");
            sqlCmd.Append("[ErrorMethod] [nvarchar](max) NULL, ");
            sqlCmd.Append("[ErrorMessage] [nvarchar](max) NULL, ");
            sqlCmd.Append("[InnerErrorMessage] [nvarchar](max) NULL, ");
            sqlCmd.Append("CONSTRAINT [PK_Logging] PRIMARY KEY CLUSTERED ");
            sqlCmd.Append("( [Id] ASC ) WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY] ");
            sqlCmd.Append(") ON [PRIMARY] TEXTIMAGE_ON [PRIMARY] ");

            context.Database.ExecuteSqlCommand(sqlCmd.ToString());

            //sqlCmd = new StringBuilder();
            //sqlCmd.Append("IF NOT EXISTS (SELECT * FROM SysObjects WHERE Name='DF_NLogLogging_time_stamp' AND Xtype='U') ");
            //sqlCmd.Append("ALTER TABLE [dbo].[NLog_Logging] ADD  CONSTRAINT [DF_NLogLogging_time_stamp]  DEFAULT (getdate()) FOR [time_stamp] ");

            context.Database.ExecuteSqlCommand(sqlCmd.ToString());

            context.Users.AddOrUpdate(
                u => u.Id,
                new User { Id = "admin", UserName = "Administrator", PasswordHash = "chazin", Email = "hassan.reyes@gmail.com" },
                new User { Id = "_Anonymous_", UserName = "_Anonymous_", PasswordHash = "", IsTemporal = true}
                );
        }
    }
}
