using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ObjectiveC;

namespace FYshuffle
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string[] strings = { "boo", "poo", "doo", "foo", "woo" };
            ShufflerClass.doYatesShuffle(strings);
            foreach(string s in strings)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
            //Console.WriteLine("Hello, World!");
        }

        
        
    }
}