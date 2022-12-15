#include "fileReader.h"

using namespace std;

reader::reader(string p)
{
	path = p;
}

void reader::readText()
{
	std::ifstream myfile(path);
	string s;
	if (myfile.is_open()) {
		while (myfile) {
			myfile >> s;
			data.push_back(stoi(s));
		}
	}
	else {
		cout << "uh oh";
	}
}
