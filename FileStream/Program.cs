using System.Text;
using System.IO;
using System;
using static System.Console;

namespace FileStreamSpace
{
    class Program
    {
        static void WriteFile(string filePath)
        {
            //FileStream fs = new FileStream("arg.txt", FileMode.Open);
            // DOING
            //fs.Read(...);
            //fs.Write(...);
            //fs.Close();

            //FileStream fs2 = new FileStream("arg.txt", FileMode.Open);
            //// DOING
            //fs2.Dispose();

            //FileStream fs3 = new FileStream("arg.txt", FileMode.Open);
            //try
            //{
            //    // DOING
            //    // ERROR
            //}
            //finally
            //{
            //    fs3.Dispose();
            //}

            // using needs IDisposable Interface
            //using (FileStream fs4 = new FileStream("arg.txt", FileMode.Open))
            //{
            //    // DOING
            //}// Dispose()

            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                // отримуємо дані для запису в файл
                Console.WriteLine("Enter the data to write to the file: ");

                string writeText = Console.ReadLine();
                // перетворюємо рядок в масив байтів
                byte[] writeBytes = Encoding.Default.GetBytes(writeText);
                // записуємо дані в файл
                fs.Write(writeBytes, 0, writeBytes.Length);
                WriteLine("Information recorded!");
            }
        }
        static string ReadFile(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                byte[] readBytes = new byte[fs.Length];
                // зчитуємо дані з файла
                fs.Read(readBytes, 0, readBytes.Length);
                // перетворюємо байти в рядок
                return Encoding.Default.GetString(readBytes);
            }
        }
        static void Main(string[] args)
        {
            string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\test.txt";
            WriteFile(filePath);
            // виводимо результат на консоль
            Console.WriteLine($"\nData read from the file: { ReadFile(filePath)}");
        }
    }
}
