#pragma once
#include<stack>
#include<string>
#include<iostream>
using namespace std;
class cal_data
{
public:
	cal_data(string _expr)
		:expr(_expr) {
		div_str(expr);
	}
	string& get_str() { return expr; }
private:
	string expr;
	stack<double> num_stk;
	stack<char> oper_stk;
	inline bool is_number(char c);
	void div_str(string& expr);
	string::size_type  num_size(string& expr, string::size_type pos);
	int oper_priority(char c);
	void calculate();
};


