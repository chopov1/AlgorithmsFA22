
1. We will loop through each index of the array starting at the last index minus 1.
1. We get a random number between the 1st index of arry and the ith index.
1. We then swap those numbers and repeat, this way the sequence will b different from the original.
1. We make sure to create a temp object to store the obj at index i before we set i =j. then we set j = to temp.
1. Return the newly shuffled array.
```c#
public static object[] doYatesShuffle(this object[] objects)
        {
            for(int i = objects.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                objects.swap(i, j);
            }
            return objects;
        }
```
### Improvments to make
* We could check if j is equal to i before we do the swap so that we are not wasting time.
* We could create object temp as a class variable or even inside yatesshuffle method so that we are not making abunch of work for the GC by having i objects created for temp everytime we do a shuffle
```c#
public static void swap(this object[] objects, int i, int j)
        {
            
            object temp = objects[i];
            objects[i] = objects[j];
            objects[j] = temp;
        }
```