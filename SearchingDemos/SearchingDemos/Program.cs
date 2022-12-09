namespace SearchingDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileReader reader = new FileReader();
            AlgorithmManager manager = new AlgorithmManager();
            int target = 50;//int.Parse(Console.ReadLine());
            manager.LinearSearch(reader.getData(), target);
            manager.BinarySearch(manager.BubbleSort(reader.getData()), target);
            manager.InterpolationSearch(manager.BubbleSort(reader.getData()), target);
        }
    }
}