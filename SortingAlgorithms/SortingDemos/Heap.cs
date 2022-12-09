using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

//https://www.youtube.com/watch?v=W5FKKOGiKxg used this video for help creating the heap as I had never attempted one before

namespace SortingDemos
{
    public struct Node {
        public int value;
        public int index;

        public Node(int v, int i)
        {
            value = v;
            index = i;
        }
    }
    public class Heap
    {
        public int Count { get; private set; }
        public List<Node> nodes;
        public Node Root;

        public Heap(int[] data)
        {
            nodes = createHeap(data);
        }

        private List<Node> createHeap(int[] data)
        {
            List<Node> heap = new List<Node>();
            Root = new Node(data[0], 0);
            Count = 1;
            for(int i = 1; i < data.Length-1; i++)
            {
                addNode(new Node(data[i], Count), heap);
            }
            return heap;
        }

        public void PrintHeap()
        {
            foreach(var node in nodes)
            {
                Console.WriteLine($"node with value {node.value} is at index {node.index}");
            }
        }

        public void PrintHeapByPopping()
        {
            while(nodes.Count > 0)
            {
                Console.WriteLine($"The root node had a value of {Remove(nodes)}");
            }
        }

        public void addNode(Node node, List<Node> list)
        {
            list.Add(node);
            HeapifyUp(list.Count - 1, list);
        }

        public int Remove(List<Node> list)
        {
            int toReturn = 0;
            if (list.Count > 0)
            {
                toReturn = list[0].value;
                list[0] = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                HeapifyDown(0, list);
            }
            return toReturn;
        }

        private void HeapifyDown(int index, List<Node> list)
        {
            int largest = index;
            int left = GetLeft(index);
            int right = GetRight(index);

            if (left < list.Count && list[left].value > list[index].value)
            {
                largest = left;
            }
            if(right < list.Count && list[right].value > list[index].value)
            {
                largest = right;
            }
            if(largest != index)
            {
                swapNodes(index, largest, list);
                HeapifyDown(largest, list);
            }
        }

        private void HeapifyUp(int index, List<Node> list)
        {
            if(index == 0)
            {
                return;
            }
            Node parent = list[GetParent(index)];
            index = checkPartner(index, list);
            if (parent.index >= 0 && parent.value < list[index].value)
            {
                swapNodes(GetParent(index), index, list);
                HeapifyUp(GetParent(index),list);
            }
        }

        private int checkPartner(int index, List<Node> list)
        {
            int left = GetLeft(index);
            int right = GetRight(index);

            if (left < list.Count && list[left].value > list[index].value)
            {
                index = left;
            }
            if (right < list.Count && list[right].value > list[index].value)
            {
                index = right;
            }
            return index;
        }

        private void swapNodes(int i1, int i2, List<Node> list)
        {
            var temp = list[i1];
            list[i1] = list[i2];
            list[i2] = temp;
        }

        public int GetParent(int index)
        {
            if(index <= 0)
            {
                return -1;
            }
            return (index - 1) / 2;
        }

        public int GetLeft(int index)
        {
            return index * 2 + 1;
        }

        public int GetRight(int index)
        {
            return index * 2 + 2;
        }
    }
}
