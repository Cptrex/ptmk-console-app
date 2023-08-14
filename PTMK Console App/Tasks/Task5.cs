using Microsoft.EntityFrameworkCore;
using PTMKConsoleApp.Models.Context;
using PTMKConsoleApp.Models.ViewModels;

namespace PTMKConsoleApp.Tasks;

public class Task5
{
    /// <summary>
    /// Получение списка клиентов мужчин, у которых фамилия начинается с определенного символа
    /// </summary>
    /// <param name="firstLetterSurname">Первая буква фамилии</param>
    public static async void GetMaleClientsBySurname(string firstLetterSurname = "F")
    {
        Console.WriteLine($"[{DateTime.Now}]Getting Male clients from database....");
        using (var context = new PTMKContext())
        {
            List<ClientViewModel> clients = await context.Clients.Select(c => new ClientViewModel
            {
                FullName = c.FullName,
                DateOfBirth = c.DateOfBirth,
                Sex = c.Sex,
            }).Where(c => c.Sex == Utils.Sex.Male && c.FullName.StartsWith(firstLetterSurname)).ToListAsync();

            Console.WriteLine($"[{DateTime.Now}]Returned {clients.Count} records");
        }
    }
}