using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReaderWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"test.txt";

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }

                Console.WriteLine();

                using (StreamReader sr = new StreamReader(path, Encoding.Default))
                {
                    string line;                    
                    while ((line = sr.ReadLine()) != null)
                    {                        
                        Console.WriteLine($"<{line}>");
                    }
                }

                Console.WriteLine();
 
                using (StreamReader sr = new StreamReader(path, Encoding.Default))
                {
                    char[] array = new char[4];
                    sr.Read(array, 0, 4);
                    Console.WriteLine(array);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            string readPath = @"read.txt";
            string writePath = @"write.txt";
            string text = "";
            try
            {
                using (StreamReader sr = new StreamReader(readPath))
                {
                    text = sr.ReadToEnd();
                }
                using (StreamWriter sw = new StreamWriter(writePath, false, Encoding.Default))
                {
                    sw.WriteLine(text);
                }

                using (StreamWriter sw = new StreamWriter(writePath, true, Encoding.Default))
                {
                    sw.WriteLine("Append");
                    sw.Write(454875);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
