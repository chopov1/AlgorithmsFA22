This has O(n) or linear runtime. The runtime grows only with the size of the array.

```c++
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

```

This has O(n^2) or quadratic runtime this runtime is squared depending on the int passed in, as it is run on a nested for loop.

```c++
void printBanana(int timesToPrint) {
    for (int i = 0; i < timesToPrint; i++) {
        std::cout << "Banana";
        for (int j = 0; j < timesToPrint; j++) {
            std::cout << "!";
        }
        std::cout<<"" << std::endl;
    }
}
```

This function has O(1) or constant runtime, as it only ever does one thing no matter what is passed in.

```c++
void Log(const char* message) {
	std::cout << message << std::endl;
}
```