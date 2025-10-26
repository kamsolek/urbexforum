using Microsoft.EntityFrameworkCore;
using System.IO;

namespace UrbexForum.Model
{
    public class AppDbContext : DbContext
    {
        public DbSet<Place> Places { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Pobierz ścieżkę katalogu aplikacji
            var basePath = AppContext.BaseDirectory;
            // Zbuduj ścieżkę do pliku bazy w folderze projektu
            var dbPath = Path.Combine(basePath, "dbPlaces.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
    }
}
