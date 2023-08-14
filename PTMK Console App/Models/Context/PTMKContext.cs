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
        using (StreamReader file = new StreamReader("./connection.json"))
        {
            try
            {
                string connectionString = file.ReadToEnd();
                //string contextConnection = "Server=localhost;Uid=root;Pwd=root;Database=pmk_db;";
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }
            catch (Exception)
            {
                Console.WriteLine("Problem reading file");
            }
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}