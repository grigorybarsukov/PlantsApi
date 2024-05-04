using Microsoft.EntityFrameworkCore;
using Plants.Domain;

namespace Plants.Persistent;

public class PlantsDbContext : DbContext
{
    private readonly PgsSettings settings;

    public PlantsDbContext(PgsSettings settings)
    {
        this.settings = settings;
    }

    public DbSet<Plant> Plants { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PlantsDbContext).Assembly);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(settings.ConnectionString);
        base.OnConfiguring(optionsBuilder);
    }
}