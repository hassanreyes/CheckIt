namespace CheckIt.Domain.Migrations
{
    using CheckIt.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;

    internal sealed class Configuration : DbMigrationsConfiguration<CheckIt.Domain.CheckItContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = false;
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

            try
            {
                StringBuilder sqlCmd = new StringBuilder();

                //Full-Text Index
                //Moved to FTS Migration

                //NLog table
                sqlCmd = new StringBuilder();
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

                //context.Database.ExecuteSqlCommand(sqlCmd.ToString());

                context.Users.AddOrUpdate(
                    u => u.Id,
                    new User { Id = "admin", UserName = "Administrator", PasswordHash = "chazin", Email = "hassan.reyes@gmail.com" },
                    new User { Id = CheckItContext.AnonymousUserName, UserName = CheckItContext.AnonymousUserName, PasswordHash = "", IsTemporal = true }
                    );

                Area area = new Area { Name = CheckItContext.DefaultAreaName, CreatedBy = "System", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow };
                Category catUndefined = new Category { Name = CheckItContext.UndefinedCategoryName, CreatedBy = "System", Area = area, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow };
                Category catImplementation = new Category { /*Id = Guid.Parse(""),*/ Name = "Implementation", CreatedBy = "System", Area = area, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow };
                Category catSupport = new Category { /*Id = Guid.Parse(""),*/ Name = "Support", CreatedBy = "System", Area = area, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow };
                Category catAnalysisAndDesign = new Category { /*Id = Guid.Parse(""),*/ Name = "Analysis and Design", CreatedBy = "System", Area = area, SuperCategory = catImplementation, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow };
                Category catCoding = new Category { /*Id = Guid.Parse(""),*/ Name = "Coding", CreatedBy = "System", Area = area, SuperCategory = catImplementation, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow };
                Category catDeploying = new Category { /*Id = Guid.Parse(""),*/ Name = "Deploying", CreatedBy = "System", Area = area, SuperCategory = catImplementation, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow };
                Category catPlanning = new Category { /*Id = Guid.Parse(""),*/ Name = "Planning", CreatedBy = "System", Area = area, SuperCategory = catImplementation, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow };
                Category catRequirements = new Category { /*Id = Guid.Parse(""),*/ Name = "Requirements", CreatedBy = "System", Area = area, SuperCategory = catImplementation, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow };
                Category catTesting = new Category { /*Id = Guid.Parse(""),*/ Name = "Testing", CreatedBy = "System", Area = area, SuperCategory = catImplementation, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow };
                Category catArchitectural = new Category { /*Id = Guid.Parse(""),*/ Name = "Architectural", CreatedBy = "System", Area = area, SuperCategory = catAnalysisAndDesign, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow };
                Category catComponent = new Category { /*Id = Guid.Parse(""),*/ Name = "Component", CreatedBy = "System", Area = area, SuperCategory = catAnalysisAndDesign, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow };
                Category catDataBase = new Category { /*Id = Guid.Parse(""),*/ Name = "Data Base", CreatedBy = "System", Area = area, SuperCategory = catAnalysisAndDesign, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow };
                Category catInterface = new Category { /*Id = Guid.Parse(""),*/ Name = "Interface", CreatedBy = "System", Area = area, SuperCategory = catAnalysisAndDesign, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow };
                Category catC = new Category { /*Id = Guid.Parse(""),*/ Name = "C/C++", CreatedBy = "System", Area = area, SuperCategory = catCoding, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow };
                Category catCSharp = new Category { /*Id = Guid.Parse(""),*/ Name = "C#", CreatedBy = "System", Area = area, SuperCategory = catCoding, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow };
                Category catJava = new Category { /*Id = Guid.Parse(""),*/ Name = "Java", CreatedBy = "System", Area = area, SuperCategory = catCoding, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow };
                Category catObjectiveC = new Category { /*Id = Guid.Parse(""),*/ Name = "Objective-C", CreatedBy = "System", Area = area, SuperCategory = catCoding, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow };

                context.Areas.AddOrUpdate(
                    x => x.Name,
                    area
                    );

                context.Categories.AddOrUpdate(
                    x => x.Name,
                    catUndefined,
                    catImplementation,
                    catSupport,
                    catAnalysisAndDesign,
                    catCoding,
                    catDeploying,
                    catPlanning,
                    catRequirements,
                    catTesting,
                    catArchitectural,
                    catComponent,
                    catDataBase,
                    catInterface,
                    catC,
                    catCSharp,
                    catJava,
                    catObjectiveC
                    );
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
    }
}
