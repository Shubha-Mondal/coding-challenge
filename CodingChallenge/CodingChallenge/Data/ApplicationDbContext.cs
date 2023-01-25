using CodingChallenge.Data.ContextConfigurations;
using CodingChallenge.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.Spatial;

namespace CodingChallenge.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Apply configuration for the three contexts in our application
            // This will create the demo data for our GraphQL endpoint.
            builder.ApplyConfiguration(new OfficeContextConfigurations());
        }

        // Add the DbSets for each of our models we would like at our database
        public DbSet<Office> Offices { get; set; }
    }
}
