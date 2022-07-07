using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WorldCitiesAPI.Data.DataStore
{
    public class CountryEntityTypeConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Countries");
            builder.Property(x => x.Id).IsRequired();
        }
    }
}
