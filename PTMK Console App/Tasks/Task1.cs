using Microsoft.EntityFrameworkCore;
using PTMKConsoleApp.Models.Context;

namespace PTMKConsoleApp.Tasks;

public class Task1
{
    public static bool CreateClientsTable()
    {
        try
        {
            using (PTMKContext context = new PTMKContext())
            {
                context.Database.ExecuteSqlRaw("CREATE TABLE IF NOT EXISTS `clients` (`id` INT NOT NULL AUTO_INCREMENT," +
                        "`fullname` VARCHAR(255) NOT NULL," +
                        "`date_of_birth` DATETIME NULL," +
                        "`sex` TINYINT NULL," +
                        "PRIMARY KEY (`id`));");
            }
            return true;
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return false;
        }
    }
}