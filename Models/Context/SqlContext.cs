using Microsoft.EntityFrameworkCore;

namespace SignAppBongi.Models.Context
{
    public class SqlContext: DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options ) : base(options) { }

        public DbSet<UserModel> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)

    {

        modelBuilder.Entity<UserModel>()

            .HasKey(u => u.Id); // Add this line

    }
    }
}
