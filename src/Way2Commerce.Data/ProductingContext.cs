using Microsoft.EntityFrameworkCore;
using Way2Commerce.Domain.Entities;

namespace Way2Commerce.Data;
public class ProductingContext : DbContext
{
        public DbSet<Product> Products { get; set; }

        public string DbPath { get; }

        public ProductingContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "producting.db");
        }
        
        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
}
