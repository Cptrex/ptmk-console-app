using PTMKConsoleApp.Models;
using PTMKConsoleApp.Models.Context;
using PTMKConsoleApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PTMKConsoleApp.Tasks
{
    public class Task4
    {
        public static async void FillClientsDB()
        {
            string  dict = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int limit = 999900;
            Sex gender = Sex.Male;
            DateTime birthDate = DateTime.Now;

            using (PTMKContext context = new PTMKContext())
            {

                for (int i = 0; i < 100; i++)
                {
                    string fullname = $"F{dict[i % dict.Length]}{dict[((i * 10) + 1) % dict.Length]}";

                    if (i % 2 == 0) gender = Sex.Male;
                    else gender = Sex.Female;

                    Client client = new Client(fullname, birthDate, gender);

                    await context.Clients.AddAsync(client);
                    await context.SaveChangesAsync();
                }

                for (int i = 0; i < limit; i++)
                {
                    Console.WriteLine($"i:{i}");
                    string fullname = $"{dict[i % dict.Length]}{dict[(i + 10) % dict.Length]}{dict[((i * 10) + 1) % dict.Length]}";
                    birthDate = DateTime.Now;

                    if (i % 2 == 0) gender = Sex.Male;
                    else gender = Sex.Female;

                    Client client = new Client(fullname, birthDate, gender);

                    await context.Clients.AddAsync(client);
                    await context.SaveChangesAsync();
                }
            }
        }
    }
}