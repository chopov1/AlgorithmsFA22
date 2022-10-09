using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FYshuffle
{
    public static class ShufflerClass
    {
        static Random rnd = new Random();

        public static object[] doYatesShuffle(this object[] objects)
        {
            //we will loop through each index of the array starting at the last index minus 1
            for(int i = objects.Length - 1; i > 0; i--)
            {
                //we get a random number between the 1st index of arry and the ith index
                int j = rnd.Next(i + 1);
                //we then swap those numbers and repeat, this way the sequence will b different from the original
                //we make sure to create a temp object to store the obj at index i before we set i =j. then we set j = to temp.
                objects.swap(i, j);
            }
            //return the newly shuffled array
            return objects;
        }

        public static object[] doYatesSecondShuffle(this object[] objects)
        {
            for (int i =0; i < objects.Length - 2; i++)
            {
                int j = getRndNum((objects.Length- i)-1); 
                objects.swap(i, i+j);
            }
            return objects;
        }

        private static int getRndNum(int i)
        {
            return rnd.Next(i+1);
        }
        //could create object temp as a class variable or even
        //inside yatesshuffle method so that we are not making abunch of
        //work for the GC by having i objects created for temp everytime
        //we do a shuffle
        public static void swap(this object[] objects, int i, int j)
        {
            //we could check if j is equal to i before we do the swap so that we are not wasting time 
            object temp = objects[i];
            objects[i] = objects[j];
            objects[j] = temp;
        }
    }
}
