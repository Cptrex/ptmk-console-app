using PTMKConsoleApp.Models;
using PTMKConsoleApp.Models.Context;
using PTMKConsoleApp.Utils;

namespace PTMKConsoleApp.Tasks;

public class Task2
{
    public static void InsertClientsRecord(string fullname, string dateOfBirth, int sex)
    {
        using (PTMKContext context = new PTMKContext())
        {
            DateTime date = FormatDateFrom(dateOfBirth);
            Client client = new Client(fullname, date, (Sex)sex);
            context.Clients.Add(client);
            context.SaveChanges();
        }

        Console.WriteLine("Record Added successfly");
    }

    private static DateTime FormatDateFrom(string date)
    {
        return Convert.ToDateTime(date);
    }
}