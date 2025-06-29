using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WealthTracker.Repository.DataAccessObjects;
using WealthTracker.Shared.DataAccess;

namespace WealthTracker.Repository.DBContext
{
    
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserAccount> UserAccounts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Fluent API setup
            builder.Entity<UserAccount>()
                .HasOne(u => u.IdentityUser)
                .WithOne() // possibly add .WithOne(i => i.UserAccount) for bidirectional navigation
                .HasForeignKey<UserAccount>(u => u.IdentityUserId);

        }
    }
}
