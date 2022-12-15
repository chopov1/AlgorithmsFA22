#pragma once
#include <vector>

using namespace std;

struct Node {
public:
    int value;
    int index;
    Node(int v, int i);
    Node();
    
};

class Heap {
public:
    vector<Node> nodes;
    Node root;

    Heap(vector<int> &data);

    void printHeapByPopping(vector<Node> &list);

private:
    vector<Node> createHeap(vector<int> &data);
    void addNode(Node node, vector<Node> &list);
    int remove(vector<Node> &list);
    void heapifyDown(int index, vector<Node> &list);
    void heapifyUp(int index, vector<Node> &list);
    int checkPartner(int index, vector<Node> &list);
    void swapNodes(int i1, int i2, vector<Node> &list);
    int getParent(int i);
    int getRight(int i);
    int getLeft(int i);
};