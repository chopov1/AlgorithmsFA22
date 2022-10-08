﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYshuffle
{
    public static class ShufflerClass
    {
        static Random rnd = new Random();

        
        public static void doYatesShuffle(this object[] objects)
        {
            for(int i = objects.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                swap(objects, i, j);
            }
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
