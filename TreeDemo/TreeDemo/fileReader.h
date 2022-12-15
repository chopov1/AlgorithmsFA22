#pragma once

#include <iostream>
#include <fstream>
#include <string>
#include <vector>

//starting directory for reading files in c++ visual studio seems to be the Source Files folder

using namespace std;
class reader {
public:
	string path;
	reader(string p);
	vector<int> data;
	void readText();

};