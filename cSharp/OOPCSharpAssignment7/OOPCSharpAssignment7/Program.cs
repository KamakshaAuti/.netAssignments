using System;
using System.IO;
namespace OOPCSharpAssignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\KAAUTI\source\repos\OOPCSharpAssignment2";

            var dir = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            var files = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);
            Console.WriteLine("******Display Directories******");
            foreach(string obj in dir)
            {
                var info = new DirectoryInfo(obj);
                Console.WriteLine($"{info.FullName}");
            }
            Console.WriteLine("------Display Files------");
            foreach (string obj2 in files)
            {
                var FInfo = new FileInfo(obj2);
                Console.WriteLine($"{Path.GetFileName(obj2)} - {FInfo.Length } bytes");
            }
            
        }
    }
}
