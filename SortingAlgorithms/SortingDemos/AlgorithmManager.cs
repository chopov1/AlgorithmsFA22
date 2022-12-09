using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SortingDemos
{
    public class AlgorithmManager
    {
        MyTimer tmr;
        public AlgorithmManager()
        {
            tmr = new MyTimer(1);
           
        }

        private void swap(int[] data, int index1, int index2)
        {
            int temp = data[index1];
            data[index1] = data[index2];
            data[index2] = temp;
        }

        public void PrintData(int[] data)
        {
            foreach (var t in data)
            {
                Console.WriteLine(t.ToString());
            }
        }

        public void BubbleSort(int[] data)
        {
            tmr.ALGO = "Bubble Sort";
            //tmr.StartTimer();
            Console.WriteLine("-------------- BUBBLE SORT --------------");
            tmr.StartTimer();
            bool isSorted = false;
            while (!isSorted)
            {
                isSorted = true;
                for(int i = 0; i < data.Length - 1; i++)
                {
                    if (data[i] > data[i + 1])
                    {
                        swap(data, i, i + 1);
                        isSorted = false;
                    }
                }
            }
            tmr.StartTimer();
            /*double te = tmr.StopTimer();
            Console.WriteLine($"the operation took {te}");*/
            PrintData(data);
        }

        public void InsertionSort(int[] data)
        {
            tmr.ALGO = "Insertion Sort";
            Console.WriteLine("-------------- INSERTION SORT --------------");
            tmr.StartTimer();
            for (int i =0; i < data.Length - 1; i++)
            {
                for(int j = i + 1; j > 0; j--)
                {
                    if (data[j] < data[j - 1])
                    {
                        swap(data, j, j - 1);
                    }
                }
            }
            tmr.StartTimer();
            PrintData(data);
        }

        public void SelectionSort(int[] data)
        {
            tmr.ALGO = "Selection Sort";
            Console.WriteLine("-------------- SELECTION SORT --------------");
            tmr.StartTimer();
            for (int i = 0; i < data.Length - 1; i++)
            {
                for(int j = data.Length - 1; j > i; j--)
                {
                    if (data[j] < data[i])
                    {
                        swap(data, j, i);
                    }
                }
            }
            tmr.StartTimer();
            PrintData(data);
        }

        public void HeapSort(int[] data)
        {
            Console.WriteLine("-------------- HEAP --------------");
            tmr.ALGO = "Heap Sort";
            tmr.StartTimer();
            Heap heap = new Heap(data);
            heap.PrintHeapByPopping();
            tmr.StartTimer();
        }

        public void QuickSort(int[] data)
        {
            
            tmr.ALGO = "Quick Sort";
            Console.WriteLine("-------------- QUICK SORT --------------");
            tmr.StartTimer();
            quickSort(data, 0, data.Length-1);
            tmr.StartTimer();
            PrintData(data);
        }

        private void quickSort(int[] data, int low, int high)
        {
            if(low < high)
            {
                int pivot = partition(data, low, high);
                quickSort(data, low, pivot -1);
                quickSort(data, pivot + 1, high);
            }
        }

        //implement a better way to pick the pivot point
        private int partition(int[] data, int low, int high)
        {
            int pivot = data[high];
            int i = low - 1;

            for(int j = low; j <= high-1; j++)
            {
                if (data[j] < pivot)
                {
                    i++;
                    swap(data, i, j);
                }
            }

            swap(data, i + 1, high);
            return (i + 1);
        }

        public void MergeSort(int[] data)
        {
            //REDO MERGE SORT
            tmr.ALGO = "Merge Sort";
            Console.WriteLine("-------------- MERGE SORT --------------");
            tmr.StartTimer();
            mergeSort(data, 0, data.Length-1);
            tmr.StartTimer();
            PrintData(data);
        }

        private void mergeSort(int[] data, int start, int end)
        {
            if(start < end)
            {
                int midpoint = start + (end - start) / 2;
                mergeSort(data, start, midpoint);
                mergeSort(data, midpoint + 1, end);
                merge(data, start, midpoint, end);
            }
        }

        private void merge(int[] data, int start, int midpoint, int end)
        {
            int length1 = midpoint - start + 1;
            int length2 = end - midpoint;

            int[] left = new int[length1];
            int[] right = new int[length2];

            int leftPtr;
            int rightPtr;

            for(leftPtr = 0; leftPtr < length1; leftPtr++)
            {
                left[leftPtr] = data[start + leftPtr];
            }
            for(rightPtr = 0; rightPtr < length2; rightPtr++)
            {
                right[rightPtr] = data[midpoint+ 1 + rightPtr];
            }

            leftPtr = 0;
            rightPtr = 0;

            int mainPtr = start;
            while(leftPtr < length1 && rightPtr < length2)
            {
                if(left[leftPtr] <= right[rightPtr])
                {
                    data[mainPtr] = left[leftPtr];
                    leftPtr++;
                }
                else
                {
                    data[mainPtr] = right[rightPtr];
                    rightPtr++;
                }
                mainPtr++;
            }

            while(leftPtr < length1)
            {
                data[mainPtr] = left[leftPtr];
                leftPtr++;
                mainPtr++;
            }

            while(rightPtr < length2)
            {
                data[mainPtr] = right[rightPtr];
                rightPtr++;
                mainPtr++;
            }

        }
        
        
    }
}
