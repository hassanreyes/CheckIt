using CheckIt.Entities;
using CheckIt.Mapping;
using System.Data.Entity;

namespace CheckIt.Doamin
{
    public class DbBuilderContext : DbContext
    {
        public DbSet<User> Users { get; set; }
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

        public DbBuilderContext (string connStringName):
            base("CheckItContext")
        {
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new AccountMapping());
            modelBuilder.Configurations.Add(new AreaMapping());
            modelBuilder.Configurations.Add(new CategoryMapping());
            modelBuilder.Configurations.Add(new ChecklistMapping());
            modelBuilder.Configurations.Add(new SectionMapping());
            modelBuilder.Configurations.Add(new ItemMapping());
            modelBuilder.Configurations.Add(new KeywordMapping());
            modelBuilder.Configurations.Add(new FolderMapping());
            modelBuilder.Configurations.Add(new FavoriteMapping());
            modelBuilder.Configurations.Add(new AnswerMapping());
        }

    }
}
