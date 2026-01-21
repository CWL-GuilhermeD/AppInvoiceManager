using Microsoft.EntityFrameworkCore;

namespace InvoiceDataAccess.Configuration
{
    public class Conn : DbContext
    {
        public DbSet<SpentModel> SpentsModel { get; set; }

        //public Conn() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Invoice.db");
        }
    }
}
