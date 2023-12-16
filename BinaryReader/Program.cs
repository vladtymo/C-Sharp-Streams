using System;
using System.IO;

////////// Використання BinaryReader

namespace BinaryReader
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = File.Open(@"info.bin", FileMode.Open);

            var reader = new System.IO.BinaryReader(file);

            long number = reader.ReadInt64();
            byte[] bytes = reader.ReadBytes(4);
            string s = reader.ReadString();

            reader.Close();

            Console.WriteLine(number);
            foreach (byte b in bytes)
            {
                Console.Write("[{0}]", b);
            }

            Console.WriteLine();
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
