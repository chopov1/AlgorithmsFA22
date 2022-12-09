using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SearchingDemos
{
    public class AlgorithmManager
    {
        MyTimer tmr;
        public AlgorithmManager()
        {
            tmr = new MyTimer(1);
        }

        public void LinearSearch(int[] data, int element)
        {
            for(int i =0; i < data.Length; i++)
            {
                if(data[i] == element)
                {
                    Console.WriteLine("Found the element " + data[i] + " using linear search.");
                    return;
                }
            }
            Console.WriteLine("Could not find element " + element + " using linear search.");
        }
        
        public void BinarySearch(int[] data, int target)
        {
            int left = 0;
            int right = data.Length - 1;
            int mid;

            while (left <= right)
            {
                mid = (left + right )/ 2;
                if(data[mid] < target)
                {
                    left = mid + 1;
                }
                else if(data[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    Console.WriteLine("Found the element "+ data[mid] + " using binary search.");
                    return;
                }
            }
            Console.WriteLine("Could not find " + target + " using binary search.");
        }

        public void InterpolationSearch(int[] data, int target)
        {
            int left = 0;
            int right = data.Length - 1;
            int key = getKey(data, target, left, right);
            while (left < right && target >= data[left] && target <= data[right])
            {
                if (data[key] < target)
                {
                    left = key + 1;
                }
                else if (data[key] > target)
                {
                    right = key - 1;
                }
                else
                {
                    Console.WriteLine("Found the element " + data[key] + " using interpolation search.");
                    return;
                }
                key = getKey(data, target, left, right);
            }
            Console.WriteLine("Could not find the element " + target + " using interpolation search.");
        }

        private int getKey(int[] data,int target, int left, int right)
        {
            return left + ((right - left) / (data[right]- data[left])) * (target - data[left]);
        }

        #region bubble sort for algorithms that require sorted data
        public int[] BubbleSort(int[] data)
        {
            bool isSorted = false;
            while (!isSorted)
            {
                isSorted = true;
                for (int i = 0; i < data.Length - 1; i++)
                {
                    if (data[i] > data[i + 1])
                    {
                        swap(data, i, i + 1);
                        isSorted = false;
                    }
                }
            }
            return data;
        }

        private void swap(int[] data, int index1, int index2)
        {
            int temp = data[index1];
            data[index1] = data[index2];
            data[index2] = temp;
        }

        #endregion
    }
}
