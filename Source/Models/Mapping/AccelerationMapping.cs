using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Source.Models.Mapping
{
    public class AccelerationMapping : IEntityTypeConfiguration<Acceleration>
    {
        public void Configure(EntityTypeBuilder<Acceleration> builder)
        {
            builder.ToTable(nameof(Acceleration).ToLower());

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(a => a.Slug)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(a => a.CreatedAt)
                .IsRequired();

            builder.HasOne(a => a.Challenge)
                .WithMany(c => c.Accelerations);
        }
    }
}
