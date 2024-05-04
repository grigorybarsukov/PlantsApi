using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Plants.Domain;

namespace Plants.Persistent.Configuration;

public class PlantsConfiguration : IEntityTypeConfiguration<Plant>
{
    public void Configure(EntityTypeBuilder<Plant> builder)
    {
        builder
            .ToTable("Plants")
            .HasKey(e => e.Id);
    }
}