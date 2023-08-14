namespace PTMKConsoleApp.Repository;

public class DbConnection
{
    public static string GetStringConnection(string file)
    {
        StreamReader streamReader = new StreamReader(file);
        using (StreamReader r = streamReader)
        {
            string json = r.ReadToEnd();
            return json;
        }
    }
}