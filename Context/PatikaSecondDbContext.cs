using CodeFirstRelation.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstRelation.Context
{
    public class PatikaSecondDbContext : DbContext
    {
        public PatikaSecondDbContext(DbContextOptions<PatikaSecondDbContext> options) : base(options)
        {
        }
        //DbSetler
        public DbSet<PostEntity> Posts => Set<PostEntity>();
        public DbSet<UserEntity> Users => Set<UserEntity>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostEntity>()
                .HasOne(e => e.User) // Her postun bir kullanıcısı vardır.
                .WithMany(e => e.Posts) // Her kullanıcının birden fazla postı olabilir.
                .HasForeignKey(e => e.UserId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
