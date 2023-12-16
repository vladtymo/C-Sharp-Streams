using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReader

{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = File.OpenText(@"test.txt");

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line != null && line.Contains("Andrew"))
                {
                    Console.WriteLine("Found:");
                    Console.WriteLine(line);
                }
            }

            reader.Close();
            Console.ReadKey();
        }
    }
}
