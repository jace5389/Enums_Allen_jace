using System;
using System.IO;

namespace Enums_Allen_Jace
{ 
    // All 12 months
    enum Months
    {
        Jan = 1,
        Feb = 2,
        Mar = 3,
        Apr = 4,
        May = 5,
        Jun = 6,
        Jul = 7,
        Aug = 8,
        Sep = 9,
        Oct = 10,
        Nov = 11,
        Dec = 12,
    }
    class Program
    {
        static void Main(string[] args)
        { 
            // My Birth day, month, and year
            int myBirthMonth = (int)Months.Nov;
            int myBirthDay = 28;
            int myBirthYear = 2006;
            // My BirthDate along with Month, Day, and Year
            string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}";
            // My text inside my file
            File.WriteAllText("myFile.txt" ,"This is my text file!\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));
            // Another text in my file
            File.AppendAllText("myFile.txt", "WooMoo more text added to file!\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));
            // MyFile text
            if (File.Exists("myFile.txt"))
            {
                //MyFile and newFile text
                File.Copy("myFile.txt", "newFile.txt");
            }
            else
            {
                // File has newFile, myFile, and backupFile text
                File.Replace("newFile.txt", "myFile.txt", "backupFile.txt");
            }
            // My file has text and BirthDate
            File.AppendAllText("newFile.txt", myBirthDate);
            Console.WriteLine(File.ReadAllText("newFile.txt"));
        }
    }
}
