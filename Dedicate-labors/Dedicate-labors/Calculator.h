#pragma once
#include <cstdio>
#include <stack>
#include <vector>
#include <iostream>
#include <cstdlib>
#include <ctime>
#include <string>  
#include<stack>

class Calculator { //��ʽ������
public:
	Calculator() {};
	std::string MakeFormula();
	std::string Solve(std::string formula);
private:
	std::string op[4] = { "+", "-", "*", "/" };
	std::string FH(char);
};
