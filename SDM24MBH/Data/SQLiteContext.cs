using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace SDM24MBH.Data
{
    public class SQLiteContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public string DbPath { get; private set; }
        public bool VerboseSQL { get; set; } = true;

        public void ResetDatabase()
        {
            this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
            this.ChangeTracker.Clear();
        }
        private void LogToDebug(string logMessage)
        {
            if (VerboseSQL)
            {
                Debug.WriteLine(logMessage);
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IEnumerable<string> cats = ["DbLoggerCategory.Database.Command.Name"];

            optionsBuilder
                .UseSqlite($"Data Source={DbPath}")
                .EnableSensitiveDataLogging()
                .LogTo(LogToDebug,
                    new[] { DbLoggerCategory.Database.Command.Name },
                    LogLevel.Information,
                    DbContextLoggerOptions.None
                    );
        }

        public SQLiteContext()
        {
            //var path = Path.Combine(FileSystem.AppDataDirectory, "products.json");
            //var folder = Environment.SpecialFolder.LocalApplicationData;
            //var path = Environment.GetFolderPath(folder);
            var path = FileSystem.AppDataDirectory;
            DbPath = Path.Join(path, "product.db");
            LogToDebug($"SQLite DbPath: {DbPath}");
            LogToDebug($"SQLite ContextId: {this.ContextId}");
            if (!File.Exists(DbPath))
            {
                LogToDebug($"Creating Database: {DbPath}");
                this.Database.EnsureCreated();
            }
        }


    }

}
