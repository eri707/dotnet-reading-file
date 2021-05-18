using System;
using System.IO;


namespace dotnet_reading_file
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use using statement with class that implements Dispose.
            //StreamReader is a class which reads text files and found in the System.IO namespace
            using (StreamReader reader = new StreamReader("./fruits.txt"))
        {
            while (true)
            {
                string line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }
                Console.WriteLine(line); 
            }
        }
        }
    }
}
