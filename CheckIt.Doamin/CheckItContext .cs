using CheckIt.Entities;
using CheckIt.Mapping;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace CheckIt.Domain
{
    public class CheckItContext : IdentityDbContext<User>
    {
        public string SchemaName { get; set; }

        //public DbSet<User> Users { get; set; }
        #region Account
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Folder> Folders { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Share> Shareds { get; set; }
        #endregion

        #region Catalog
        public DbSet<Area> Areas { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Checklist> Checklists { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Keyword> Keywords { get; set; }
        #endregion

        public CheckItContext (string connStringName):
            base(connStringName)
        {
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.AutoDetectChangesEnabled = false;

            this.SchemaName = "chkit";

            System.Diagnostics.Debug.Write(Database.Connection.ConnectionString);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Map ASP Identity
            modelBuilder.Entity<IdentityUser>().ToTable("Users", this.SchemaName);
            modelBuilder.Configurations.Add(new UserMapping(this.SchemaName));
            modelBuilder.Entity<IdentityRole>().ToTable("Roles", this.SchemaName);

            modelBuilder.Entity<User>().HasMany<IdentityUserRole>((User u) => u.Roles);
            modelBuilder.Entity<IdentityUserRole>().HasKey((IdentityUserRole r) =>
                new { UserId = r.UserId, RoleId = r.RoleId }).ToTable("UserRoles", this.SchemaName);

            EntityTypeConfiguration<IdentityUserLogin> entityTypeConfiguration = 
                modelBuilder.Entity<IdentityUserLogin>().HasKey((IdentityUserLogin l) =>
                new {
                    UserId = l.UserId,
                    LoginProvider = l.LoginProvider,
                    ProviderKey = l.ProviderKey
                }).ToTable("UserLogins", this.SchemaName);

            entityTypeConfiguration.HasRequired<IdentityUser>((IdentityUserLogin u) => u.User);
            EntityTypeConfiguration<IdentityUserClaim> table1 =
                modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaims", this.SchemaName);

            table1.HasRequired<IdentityUser>((IdentityUserClaim u) => u.User);


            modelBuilder.Configurations.Add(new AccountMapping(this.SchemaName));
            modelBuilder.Configurations.Add(new AreaMapping(this.SchemaName));
            modelBuilder.Configurations.Add(new CategoryMapping(this.SchemaName));
            modelBuilder.Configurations.Add(new ChecklistMapping(this.SchemaName));
            modelBuilder.Configurations.Add(new SectionMapping(this.SchemaName));
            modelBuilder.Configurations.Add(new ItemMapping(this.SchemaName));
            modelBuilder.Configurations.Add(new KeywordMapping(this.SchemaName));
            modelBuilder.Configurations.Add(new FolderMapping(this.SchemaName));
            modelBuilder.Configurations.Add(new FavoriteMapping(this.SchemaName));
            modelBuilder.Configurations.Add(new AnswerMapping(this.SchemaName));
            modelBuilder.Configurations.Add(new CountryMapping(this.SchemaName));
            modelBuilder.Configurations.Add(new ShareMapping(this.SchemaName));
        }

    }
}
