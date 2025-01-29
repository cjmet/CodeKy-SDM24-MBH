using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System;
using System.IO;

namespace Data
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
            //var path = FileSystem.AppDataDirectory;
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            DbPath = Path.Join(path, "product.db");
            LogToDebug($"SQLite DbPath: {DbPath}");
            LogToDebug($"SQLite ContextId: {this.ContextId}");
            if (!File.Exists(DbPath))
            {
                LogToDebug($"Creating Database: {DbPath}");
                // cjm 
                // 1) android sdk needs to be installed for the build to work since this is linked to a maui/blazor hybrid project.
                // 2) I pulled this out separately due to some android sdk errors ... but that can probably be undone now.
                // 3) Migrations run in command line and command line appdata is not the same as muaiblazor appdata.
                // 4) In this case it created some bizare results of ... file.db is in normal appdata dir, while file.wal and file.shm are in the mauiblazor appdata dir.

                // *** ---> the following line breaks the initial create migration.
                // this.Database.EnsureCreated();
            }
        }


    }

}
