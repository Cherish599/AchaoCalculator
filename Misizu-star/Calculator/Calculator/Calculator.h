#pragma once
#include <string>
using namespace std;

class Calculator {
private:
	string op[4] = { "+","-","*","/" };
public:
	Calculator();
	string MakeQuestion();
	int Solve(string Subject);
};