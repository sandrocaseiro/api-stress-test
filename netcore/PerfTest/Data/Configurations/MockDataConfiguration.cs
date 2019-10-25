using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PerfTest.Domain;

namespace PerfTest.Data.Configurations
{
    public class MockDataConfiguration : IEntityTypeConfiguration<MockData>
    {
        public void Configure(EntityTypeBuilder<MockData> builder)
        {
            builder.ToTable("MOCKDATA", "MOCK");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("ID");

            builder.Property(e => e.Email)
                .HasColumnName("EMAIL");

            builder.Property(e => e.FirstName)
                .HasColumnName("FIRST_NAME");

            builder.Property(e => e.LastName)
                .HasColumnName("LAST_NAME");

            builder.Property(e => e.Address)
                .HasColumnName("ADDRESS");

            builder.Property(e => e.City)
                .HasColumnName("CITY");

            builder.Property(e => e.Identification)
                .HasColumnName("IDENTIFICATION");

            builder.Property(e => e.IdSearch)
                .HasColumnName("ID_SEARCH");
        }
    }
}
