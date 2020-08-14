using Entities;
using Microsoft.EntityFrameworkCore;
using Percisent.Configurations;

namespace Percisent
{
    public class TheSoulContext : DbContext
    {
        public DbSet<User> GetUsers { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<SpecificCategory> SpecificCategories { get; set; }
        public DbSet<Manual> Manuals { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<ChapterData> ChapterDatas { get; set; }
        public DbSet<DbFile> Files { get; set; }

        public TheSoulContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
