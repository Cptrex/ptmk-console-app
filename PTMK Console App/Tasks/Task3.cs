using Microsoft.EntityFrameworkCore;
using PTMKConsoleApp.Models.Context;
using PTMKConsoleApp.Models.ViewModels;

namespace PTMKConsoleApp.Tasks;

public class Task3
{
    public static async Task<List<ClientViewModel>> SelectUniqueClientsByFullname()
    {
        using (PTMKContext context = new PTMKContext())
        {
            List<ClientViewModel> clientViewList = await context.Clients.Select(c => new ClientViewModel {
                FullName = c.FullName,
                DateOfBirth = c.DateOfBirth, 
                Sex = c.Sex,
                Age = CalculateAgeByDateOfBirth(c.DateOfBirth)
            }).Distinct().ToListAsync();

            return clientViewList;
        }
    }

    public static void PrintUniqueClients(List<ClientViewModel> clientViewList)
    {
        Console.WriteLine($"Clients unique Records");
        foreach (var client in clientViewList)
        {
            Console.WriteLine($"Fullname: {client.FullName} | Date of Birth:{client.DateOfBirth} | Sex:{client.Sex} | Age:{client.Age}");
        }
    }

    private static int CalculateAgeByDateOfBirth(DateTime date)
    {
        var today = DateTime.Today;
        var age = today.Year - date.Year;

        if (date.Date > today.AddYears(-age)) age--;

        return age;
    }
}