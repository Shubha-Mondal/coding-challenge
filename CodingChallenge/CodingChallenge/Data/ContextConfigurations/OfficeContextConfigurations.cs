using CodingChallenge.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodingChallenge.Data.ContextConfigurations
{
    public class OfficeContextConfigurations : IEntityTypeConfiguration<Office>
    {
        public OfficeContextConfigurations()
        {
        }
        /// <summary>
        /// inserting data while configuring
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder
                .HasData(
                new Office
                {
                    Id = Guid.NewGuid(),
                    Name = "Dunder Mifflin Ghent",
                    City = "Ghent",
                    Email = "ghent@dundermifflin.com",
                    Latitude = 51.043476,
                    Longitude = 3.709138
                },
                new Office
                {
                    Id = Guid.NewGuid(),
                    Name = "Dunder Mifflin Kortrijk",
                    City = "Kortrijk",
                    Email = "kortrijk@dundermifflin.com",
                    Latitude = 50.822956,
                    Longitude = 3.250962
                },
                new Office
                {
                    Id = Guid.NewGuid(),
                    Name = "Dunder Mifflin Harelbeke",
                    City = "Harelbeke",
                    Email = "harelbeke@dundermifflin.com",
                    Latitude = 50.855366,
                    Longitude = 3.312553
                });
        }
    }
}
