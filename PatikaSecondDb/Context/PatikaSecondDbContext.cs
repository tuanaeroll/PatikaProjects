using Microsoft.EntityFrameworkCore;
using PatikaSecondDb.Entities;

namespace PatikaSecondDb.Context
{
    public class PatikaSecondDbContext : DbContext
    {
        public PatikaSecondDbContext(DbContextOptions<PatikaSecondDbContext> options) : base(options)
        {
        }

        // Tabloları oluşturacak metotları yazdık.
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<PostEntity> Posts { get; set; }

    }
}
