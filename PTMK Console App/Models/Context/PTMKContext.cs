using Microsoft.EntityFrameworkCore;

namespace PTMKConsoleApp.Models.Context
{
    public class PTMKContext : DbContext
    {
        public DbSet<Client> Clients { get; set; } = null!;  

        public PTMKContext()
        {
            //Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string contextConnection = "Server=localhost;Uid=root;Pwd=root;Database=pmk_db;";
            //string contextConnection = DbConnection.GetStringConnection("./connection.json");
            optionsBuilder.UseMySql(contextConnection, ServerVersion.AutoDetect(contextConnection));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}