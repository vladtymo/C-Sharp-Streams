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
            byte[] bytes = new byte[] { 10, 20, 50, 100 };
            string str = "hunger";

            writer.Write(number);
            writer.Write(bytes);
            writer.Write(str);

            writer.Close();

            Console.ReadKey();
        }
    }
}

