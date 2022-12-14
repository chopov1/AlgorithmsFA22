# SortingDemos
 
## **Bubble Sort**
>Continuously loops through a set of data untill it finds that no elements are out of order.

Runtimes
* Worst case: _O(n^2)_

* Average case: _O(n^2)_

Memory
*  _O(1)_


Pseudocode
```
    while(is not sorted)
        for i in length of data -1
            if element i < element i-1
                swap elements
```
C# Implementation

```c#
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
```

## **Insertion Sort**
>For each element X in a data set, this algorithm checks it against each previous element. If the element X is smaller then the one it is being checked against, the elements swap indicies.

Runtimes
* Worst case: _O(n^2)_

* Average case: _O(n^2)_

Memory
* _O(n)_

PseudoCode

```
    for i in data
        for j = i while j > 0 
            if element at j < element at j - 1
                swap elements at j and j -1
```
C# Implementation

```c#
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
```

## **Selection Sort**
>For each element in the array, check against the rest of the array with indicies larger then the current. If the value at any of the other indicies is larger then the value at the current, swap those values.

Runtimes
* Worst case: _O(n^2)_

* Average case: _O(n^2)_

Memory
* _O(1)_

Pseudocode
```
    for i to length of data - 1
        for j to length of data -1
            if element at j < element at i
                swpa elements at j and i
```
C# Implementation
```C#
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
```



## **Quick Sort**
>Uses recursion to divide a data set in half to create two smaller sets. With each recursion sort the smaller sets by comparing them to a "pivot" element and placing smaller elements on one side of the pivot and larger on the other. Can be optimized by different methods of choosing a pivot element.

Runtimes
* Worst case: _O(n^2)_

* Average case: _O(log n)_

Memory
* _O(n)_

C# Implementation 
```c#
        private void quickSort(int[] data, int low, int high)
        {
            if(low < high)
            {
                int pivot = partition(data, low, high);
                quickSort(data, low, pivot -1);
                quickSort(data, pivot + 1, high);
            }
        }
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
```

## **Merge Sort**
>Uses recursion to divide a data set in half to create two smaller sets. When a set is 1 element sort it, then merge it back with all of the other sets where the elements at surrounding indicies are in order with its value.

Runtimes
* Worst case: _O(log n)_

* Average case: _O(log n)_

C# Implementation
```C#
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
```

## **Heap Sort**
>Heap sort uses a heap data structure and rebuilds the heap each time an element is popped from the root node. This ensures that to access the largest or smallest element depedning on the type of heap is always O(1) time.

Runtimes
* Worst case: _O(log n)_

* Average case: _O(log n)_
