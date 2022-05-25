using System.Text;

namespace ExelReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ExelReader reader = new ExelReader();

            reader.ReadLogs("C:\\Users\\BttAdmin\\Desktop\\Logs_Course A_StudentsActivities.xlsx");

            reader.UpdatedWikisPerId = reader.GetUserIdCount(reader.UpdatedWikis);

            Console.WriteLine(reader.UpdatedWikisPerId);
            Console.WriteLine("_____________________________________________");

            reader.UploadedFilesPerId = reader.GetUserIdCount(reader.UploadedFiles);

            Console.WriteLine("_____________________________________________");
            Console.WriteLine("StudentsResults_Year 1");

            reader.ReadLogs("C:\\Users\\BttAdmin\\Desktop\\Logs_Course A_StudentsActivities.xlsx");

            foreach (KeyValuePair<int, double> entry in reader.Scores)
            {
                Console.WriteLine(entry.Key + " " + entry.Value);
            }

            Console.WriteLine("_____________________________________________");
            Console.WriteLine("StudentsResults_Year 2");

            reader.ReadLogs("C:\\Users\\BttAdmin\\Desktop\\Logs_Course A_StudentsActivities.xlsx");

            foreach (KeyValuePair<int, double> entry in reader.Scores)
            {
                Console.WriteLine(entry.Key + " " + entry.Value);
            }
        }
    }
}
