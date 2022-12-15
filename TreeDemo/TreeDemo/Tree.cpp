
#include <iostream>
#include <vector>
#include "Tree.h"

using namespace std;

Node::Node(int v, int i) {
    value = v;
    index = i;
}

Node::Node()
{
}

Heap::Heap(vector<int> &data) {
    nodes = createHeap(data);
}

void Heap::printHeapByPopping(vector<Node> &list)
{
    int length = list.size();
    for (int i = 0; i < length; i++) {
        cout << remove(list) << endl;
    }
}

vector<Node> Heap::createHeap(vector<int> &data)
{
    vector<Node> heap = vector<Node>();
    root = Node(data[0], 0);
    heap.push_back(root);
    for (int i = 1; i < data.size() - 1; i++)
    {
        addNode(Node(data[i], i), heap);
    }
    return heap;
}

void Heap::addNode(Node node, vector<Node> &list)
{
    list.push_back(node);
    heapifyUp(list.size() - 1, list);
}

int Heap::remove(vector<Node> &list)
{
    int toReturn = 0;
    if (list.size() > 0)
    {
        toReturn = list[0].value;
        list[0] = list[list.size() - 1];
        list.erase(list.end()-1);
        heapifyDown(0, list);
    }
    return toReturn;
}

void Heap::heapifyDown(int index, vector<Node> &list) {

    int largest = index;
    int left = getLeft(index);
    int right = getRight(index);

    if (left < list.size() && list[left].value > list[index].value)
    {
        largest = left;
    }
    if (right < list.size() && list[right].value > list[index].value && list[right].value > list[left].value)
    {
        largest = right;
    }
    if (largest != index)
    {
        swapNodes(index, largest, list);
        heapifyDown(largest, list);
    }
}

void Heap::heapifyUp(int index, vector<Node> &list) {
    if (index == 0)
    {
        return;
    }
    Node parent = list[getParent(index)];
    index = checkPartner(index, list);
    if (parent.index >= 0 && parent.value < list[index].value)
    {
        swapNodes(getParent(index), index, list);
        heapifyUp(getParent(index), list);
    }
}

int Heap::checkPartner(int index, vector<Node> &list) {
    int left = getLeft(index);
    int right = getRight(index);

    if (left < list.size() && list[left].value > list[index].value)
    {
        index = left;
    }
    if (right < list.size() && list[right].value > list[index].value)
    {
        index = right;
    }
    return index;
}

void Heap::swapNodes(int i1, int i2, vector<Node> &list) {
    Node temp = list[i1];
    list[i1] = list[i2];
    list[i2] = temp;
}

int Heap::getParent(int i) {
    if (i <= 0) {
        return -1;
    }
    return(i - 1) / 2;
}

int Heap::getLeft(int i) {
    return i * 2 + 1;
}

int Heap::getRight(int i) {
    return i * 2 + 2;
}