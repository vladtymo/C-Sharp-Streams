using System;
using System.IO;
using System.Text;

namespace StreamWriterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string root = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //StreamWriter sw = File.CreateText(@"C:\Users\Vlad\Desktop\textFile.txt"));
            using (StreamWriter sw = new StreamWriter(root + @"\textFile.txt"))
            {
                sw.Write("Hello!");
                sw.WriteLine();
                sw.WriteLine("How are you?");
                sw.WriteLine("Fine?");
            }

            using (StreamReader sr = new StreamReader(root + @"\textFile.txt"))
            {
                //sr.Read(); // read one symbol
                //sr.ReadBlock(); // read symbol array
                while(!sr.EndOfStream)
                    Console.WriteLine(sr.ReadLine() + "!!!"); // read one line
                //Console.WriteLine(sr.ReadToEnd()); // read all text
            }

            FileStream file = null;
            //file = new FileStream(@"test.txt", FileMode.Create);
            //file = File.Open(@"test.txt", FileMode.Open, FileAccess.Write, FileShare.Write);                      
            file = File.Create(@"test.txt");

            // 1.
            var writer = new StreamWriter(file);
            writer.Write("Hello");
            writer.WriteLine("\tworld");
            writer.Close();
            file?.Close(); // null-conditional operator

            // 2.
            writer = File.CreateText(@"test.txt");
            writer.WriteLine("Hello");
            writer.Close();

            // 3.
            File.WriteAllText(@"test.txt", "Hello");
        }
    }
}
