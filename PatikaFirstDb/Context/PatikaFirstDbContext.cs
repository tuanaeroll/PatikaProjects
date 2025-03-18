using Microsoft.EntityFrameworkCore;
using PatikaFirstDb.Entities;

namespace PatikaFirstDb.Context;
public class PatikaFirstDbContext : DbContext
{
    public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options) : base(options)
    {

    }

    public DbSet<MovieEntity> Movies { get; set; }

    public DbSet<GameEntity> Games { get; set; }

}

