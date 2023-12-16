using System;
using System.IO;

////////// Використання BinaryWriter

namespace BinaryWriterDemo
{
    class Program
    {
        static void Main()
        {

            FileStream file = File.Create(@"info.bin");
            BinaryWriter writer = new BinaryWriter(file);

            long number = 100;
            var bytes = new byte[] { 10, 20, 50, 100 };
            string s = "hunger";

            writer.Write(number);
            writer.Write(bytes);
            writer.Write(s);

            writer.Close();

            Console.ReadKey();
        }
    }
}

