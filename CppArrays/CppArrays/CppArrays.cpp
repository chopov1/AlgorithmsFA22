// CppArrays.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "Log.h"
#include <iostream>


//this has O(n) or linear runtime
void sort(int* arry, int size) {

    int current;
    for (int i = 1; i < size; i++) {
        if (arry[i] < arry[i - 1]) {
            current = arry[i - 1];
            arry[i - 1] = arry[i];
            arry[i] = current;
        }
    }
}

bool isSorted(int * arry, int size) {
    for (int i = 1; i < size; i++) {
        if (i == size) {
            return true;
        }
        else if (arry[i] < arry[i - 1]) {
            return false;
        }
    }
}

//this has O(n) runtime
void printArray(int* ptr, int size) {
    for (int i = 0; i < size; i++) {
        std::cout << *(ptr + i) << std::endl;
    }
}

//this has O(n^2) or quadratic runtime
void printBanana(int timesToPrint) {
    for (int i = 0; i < timesToPrint; i++) {
        std::cout << "Banana";
        for (int j = 0; j < timesToPrint; j++) {
            std::cout << "!";
        }
        std::cout<<"" << std::endl;
    }
}

int main()
{
    /*int a = 8;
    a++;

    const char* string = "harvey has arrived";
    
    for (int i = 0; i < 18; i++) {
        std::cout << string[i] << std::endl;
    }*/

    int array[5] = { 0, 3, 4, 2, 1 };
    
    while (!isSorted(array, 5)) {
        sort(&array[0], 5);
    }
    printArray(&array[0], 5);

    printBanana(array[4]);
    //Log function has O(1) or constant runtime
    Log("gary is here");
    std::cout << "Hello World!\n";
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
