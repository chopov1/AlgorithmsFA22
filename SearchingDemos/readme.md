# Searching Algorithms

## Linear Search
>Checks each index of a data set one by one looking for a match

#### Runtimes
* Worst Case: _O(n)_
* Average Case: _O(n/2)_
* Best case: _O(1)_

C# Implementation
```c#
            for(int i =0; i < data.Length; i++)
            {
                if(data[i] == element)
                {
                    return data[i];
                }
            }
```

## Binary Search
>Requires a sorted data set. Compares the value in the middle of the set to the desired value. If that value is greater then the desired value, search the left half of the data. If the value is less then vis versa. Repeat untill value is found or data has been fully searched.

#### Runtimes
* Worst Case: _O(n/2)_
* Best case: _O(1)_

C# Implementation
```C#
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
                    return data[mid];
                }
            }
```

## Interpolation Search
>Requires a sorted data set. Uses a formula to determine the best guess at where the value might be. Acts the same as binary search in that the formula is then performed on the lower or higher half of the data untill the value is found or the set has been searched.

#### Runtimes
* Worst Case: _O(n/2)_
* Best case: _O(1)_

C# Implementation
```C#
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
                    return data[key];
                }
                key = getKey(data, target, left, right);
            }

        private int getKey(int[] data,int target, int left, int right)
        {
            return left + ((right - left) / (data[right]- data[left])) * (target - data[left]);
        }
```
