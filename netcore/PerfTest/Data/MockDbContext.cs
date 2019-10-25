using Microsoft.EntityFrameworkCore;
using PerfTest.Data.Configurations;
using PerfTest.Domain;

namespace PerfTest.Data
{
    public class MockDbContext : DbContext
    {
        

        public DbSet<MockData> MockDatas { get; set; }

        public MockDbContext(DbContextOptions options)
            : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MockDataConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
