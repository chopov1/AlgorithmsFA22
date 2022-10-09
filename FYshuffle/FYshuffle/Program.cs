using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ObjectiveC;
using System.IO;

namespace FYshuffle
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<string> fileData = File.ReadAllLines(@"..\..\..\TextFile.txt").ToList();
            string[] strings = (string[])ShufflerClass.doYatesShuffle(fileData.ToArray());
            foreach(string s in strings)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
            //Console.WriteLine("Hello, World!");
        }

        
        
    }
}