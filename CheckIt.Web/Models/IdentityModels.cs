using CheckIt.Entities;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CheckIt.Web.Models
{
    
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUser>().ToTable("Users").Property(p => p.Id).HasColumnName("UserId");
            modelBuilder.Entity<User>().ToTable("Users").Property(p => p.UserId).HasColumnName("UserId");
            //modelBuilder.Entity<IdentityUserRole>().ToTable("UserRoles");
            //modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogins");
            //modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaims");
            //modelBuilder.Entity<IdentityRole>().ToTable("Roles");

            base.OnModelCreating(modelBuilder);
        }
    }
}