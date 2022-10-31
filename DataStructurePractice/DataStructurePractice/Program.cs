namespace DataStructurePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comparisons c = new Comparisons();
            List<string> list = c.readFile();

            Stack<string> stack = c.stringsToStack(list);
            Queue<string> queue = c.stringsToQueue(list);

            string[] arry = c.stringsToArray(list);
            Dictionary<char, List<string>> map = c.stringsToMap(list);

            Console.WriteLine("-------STACK-------");
            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
            Console.WriteLine("-------Queue-------");
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
            Console.WriteLine("-------Array-------");
            string s;
            for(int i = 0; i < arry.Length; i++)
            {
                s = arry[i];
                if (s[0] == 't')
                {
                    Console.WriteLine(s);
                }
            }
            Console.WriteLine("-------Map-------");
            foreach(string j in map['t'])
            {
                Console.WriteLine(j);
            }

            Console.ReadKey();
        }

    }
}