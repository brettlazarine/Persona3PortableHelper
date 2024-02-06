using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3PHelper
{// DOUBLECHECK THE USE OF THIS CLASS
    public static class Constants
    {
        public static SQLiteConnection Connection;
        private const string DBFileName = "persona3.db3";

        public const SQLiteOpenFlags Flags =
            SQLiteOpenFlags.ReadWrite |
            SQLiteOpenFlags.Create |
            SQLiteOpenFlags.SharedCache;

        public static string DatabasePath
        {
            get
            {
                var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DBFileName);
                return dbPath;
            }
        }

        public static async Task InitializeDatabaseAsync()
        {
            try
            {
                var dbPath = Path.Combine(FileSystem.AppDataDirectory, "persona3.db3");
                if (!File.Exists(dbPath))
                {
                    using var stream = await FileSystem.OpenAppPackageFileAsync("persona3.db3");
                    using var newStream = File.OpenWrite(dbPath);
                    await stream.CopyToAsync(newStream);

                    Debug.WriteLine("*** Database copied ***");
                }
                else
                {
                    Debug.WriteLine("*** Database not copied ***");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"*** Error while initializing database: {ex.Message} ***");
            }
        }
    }
}
