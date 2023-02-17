using PTMKConsoleApp.Tasks;

namespace PTMK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (int.TryParse(args[0], out int taskNum) == false) return;

            switch(taskNum)
            {
                case 1:
                    if(Task1.CreateClientsTable()) Console.WriteLine("Table created successfly");
                    else Console.WriteLine("Table creation error");
                    break;
                case 2:
                    string fullname = args[1];
                    string dateOfBirth = args[2];
                    int sex = int.Parse(args[3]);

                    Task2.InsertClientsRecord(fullname, dateOfBirth, sex);
                    break; 
                case 3:
                    var uniqueClients = Task3.SelectUniqueClientsByFullname().Result;
                    Task3.PrintUniqueClients(uniqueClients);
                    break; 
                case 4:
                    Console.WriteLine("Filling Datebase clients...");
                    Task4.FillClientsDB();
                    Console.WriteLine("Database Successfly filled");
                    break; 
                case 5:
                    Task5.GetMaleClientsBySurname("F");
                    break;
                default: 
                    return;
            }

            Console.ReadLine();
        }
    }
}