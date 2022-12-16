using CompteRendu2TP4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Diagnostics;

namespace CompteRendu2TP4.Data
{
    public class UniversityContext : DbContext
    {
        private static UniversityContext? _instance;
        public DbSet<Student> Student { get; set; }

        public static UniversityContext Instance
        {
            get
            {
                if (_instance is null)
                {
                    Debug.WriteLine("_instance created for the first time");
                    _instance = Instantiate_UniversityContext();
                }
                Debug.WriteLine("_instance already created");
                return _instance;
            }
        }
        public UniversityContext(DbContextOptions o) : base(o) {}

        private static UniversityContext Instantiate_UniversityContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<UniversityContext>();

            optionsBuilder.UseSqlite("Data Source=C:\\GL3\\C#\\2022 GL3 .NET Framework TP4 - SQLite database.db;");

            return new UniversityContext(optionsBuilder.Options);

        }
    }

}
