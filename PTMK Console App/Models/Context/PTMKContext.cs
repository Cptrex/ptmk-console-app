using Microsoft.EntityFrameworkCore;

namespace PTMKConsoleApp.Models.Context;

public class PTMKContext : DbContext
{
    public DbSet<Client> Clients { get; set; } = null!;  

    public PTMKContext()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string contextConnection = "Server=localhost;Uid=root;Pwd=root;Database=pmk_db;";
        optionsBuilder.UseMySql(contextConnection, ServerVersion.AutoDetect(contextConnection));
      /*  using (StreamReader file = new StreamReader("./connection.json"))
        {
            try
            {
                string connectionString = file.ReadToEnd();
              
            }
            catch (Exception)
            {
                Console.WriteLine("Problem reading file");
            }
        }*/
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}