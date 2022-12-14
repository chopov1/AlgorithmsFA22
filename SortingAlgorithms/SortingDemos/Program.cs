namespace SortingDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileReader fileReader = new FileReader(out int[] data);
            AlgorithmManager algorithmManager = new AlgorithmManager();
            algorithmManager.BubbleSort(data);
            algorithmManager.InsertionSort(fileReader.getData());
            algorithmManager.SelectionSort(fileReader.getData());
            algorithmManager.HeapSort(fileReader.getData());
            /*algorithmManager.QuickSort(fileReader.getData());
            algorithmManager.MergeSort(fileReader.getData());*/
            Console.ReadKey();
        }
    }
}