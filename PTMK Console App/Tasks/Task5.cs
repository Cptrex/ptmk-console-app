using Microsoft.EntityFrameworkCore;
using PTMKConsoleApp.Models;
using PTMKConsoleApp.Models.Context;
using PTMKConsoleApp.Models.ViewModels;

namespace PTMKConsoleApp.Tasks
{
    public class Task5
    {
        public static async void GetMaleClientsBySurname(string surname = "F")
        {
            Console.WriteLine($"[{DateTime.Now}]Getting Male clients from database....");
            using (var context = new PTMKContext())
            {
                List<ClientViewModel> clients = await context.Clients.Select(c => new ClientViewModel
                {
                    FullName = c.FullName,
                    DateOfBirth = c.DateOfBirth,
                    Sex = c.Sex,
                }).Where(c => c.Sex == Utils.Sex.Male && c.FullName.StartsWith(surname)).ToListAsync();

                Console.WriteLine($"[{DateTime.Now}]Returned {clients.Count} records");
            }
        }
    }
}