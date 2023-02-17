using PTMKConsoleApp.Tasks;

namespace PTMKConsoleApp_Test
{
    public class UnitTest
    {
        [Fact]
        public void InsertClientsRecord_Test()
        {
            string fullname = "FBB";
            string dateOfBirth = "15-02-1999";
            int sex = 1;

            Task2.InsertClientsRecord(fullname, dateOfBirth, sex);
        }
    }
}