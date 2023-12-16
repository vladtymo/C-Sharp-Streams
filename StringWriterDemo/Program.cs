using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringWriterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var writer = new StringWriter();
            writer.WriteLine("Hello all ");
            writer.Write("This is a multi-line ");
            writer.WriteLine("text string.");

            Console.WriteLine(writer.ToString());

            Console.ReadKey();
        }
    }
}
