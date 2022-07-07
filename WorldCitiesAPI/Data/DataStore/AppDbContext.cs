global using WorldCitiesAPI.Data.Models;

namespace WorldCitiesAPI.Data.DataStore
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<City>().ToTable("Cities");

        //    builder.Entity<City>().HasKey(x => x.Id);

        //    builder.Entity<City>().Property(x => x.Id).IsRequired();

        //    builder.Entity<City>()
        //    .Property(x => x.Lat).HasColumnType("decimal(7,4)");

        //    builder.Entity<City>()
        //    .Property(x => x.Lon).HasColumnType("decimal(7,4)");

        //    builder.Entity<Country>().ToTable("Countries");

        //    builder.Entity<Country>()
        //    .HasKey(x => x.Id);

        //    builder.Entity<Country>()
        //    .Property(x => x.Id).IsRequired();

        //    builder.Entity<City>()
        //    .HasOne(x => x.Country)
        //    .WithMany(y => y.Cities)
        //    .HasForeignKey(x => x.CountryId);

        //    //for EntityTypeConfiguration(CityEntityTypeConfiguration and CountryEntityTypeConfigurations)
        //    //builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        //}
        public DbSet<City> Cities => Set<City>();
        public DbSet<Country> Countries => Set<Country>();

    }
}
