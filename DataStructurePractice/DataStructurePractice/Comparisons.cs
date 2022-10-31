using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace DataStructurePractice
{
    public class Comparisons
    {
        string xmlPath = "../../../xmlfiles/data.txt";


        public List<string> readFile()
        {
            /*XmlDocument scoreDoc = new XmlDocument();
            scoreDoc.Load(xmlPath);*/
            return File.ReadAllLines(xmlPath).ToList();

        }

        

        public Stack<string> stringsToStack(List<string> lines)
        {
            //I am pushing the items to the stack backwords, so when I pop the items it will read
            //in the correct order
            Stack<string> stack = new Stack<string>();
            for(int i = lines.Count-1; i > 0; i--)
            {
                stack.Push(lines[i]);
            }
            return stack;
        }

        public Queue<string> stringsToQueue(List<string> lines)
        {
            //enqueue the items from top to bottom in terms of the line order of the data file
            //so when dequeueing it reads in the correct order.
            Queue<string> queue = new Queue<string>();
            foreach(string line in lines)
            {
                queue.Enqueue(line);
            }
            return queue;
        }

        public string[] stringsToArray(List<string> lines)
        {
            //simply creating an array. if I want to read out the data in order 
            // i can just linearly searching through and read each value
            //however if I want to know a specific word used in the data i will need to linearly search
            //vs the map, which I can simply use the first letter of the word i am looking for 
            //and get a result much quicker
            string[] arry = new string[lines.Count];
            for(int i =0; i < arry.Length; i++)
            {
                arry[i] = lines[i];
            }
            return arry;
        }

        public Dictionary<char, List<string>> stringsToMap(List<string> lines)
        {
            //I am in a way creeating my own hash function. it is simply assigning values
            //to be at the key associated with the first letter of the value. I create arrays
            //as there will be more than one word that shares the same letter. My buckets
            //in this case are the arrays I create to contain the values when ther are collisions
            //
            Dictionary<char, List<string>> result = new Dictionary<char, List<string>>();
            foreach(var line in lines)
            {
                if (!result.ContainsKey(line[0]))
                {
                    List<string> list = new List<string>();
                    list.Add(line);
                    result.Add(line[0], list);
                }
                else
                {
                    result[line[0]].Add(line);
                }
            }
            return result;
        }
    }
}
