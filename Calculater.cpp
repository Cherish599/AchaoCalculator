#include"Calculater.h"
void cal_data::div_str(string& expr)
{
	int size = 0;
	double num = 0;
	for(string::size_type ix=0;ix<expr.size();)
	{
		if (is_number(expr.at(ix)))
		{
			size = num_size(expr, ix);
			num = stod(expr.substr(ix, ix + size));
			num_stk.push(num);
			ix += size;
		}
		else
		{
			if (oper_stk.empty())
			{
				oper_stk.push(expr.at(ix));
			}
			else if (oper_priority(expr.at(ix)) <= oper_priority(oper_stk.top()))
			{
				calculate();
				oper_stk.push(expr.at(ix));
			}
			else
			{
				oper_stk.push(expr.at(ix));
			}
			++ix;
		}
	}
	while (!oper_stk.empty())
	{
		calculate();
	}
	cout << expr<<"=" <<static_cast<int>( num_stk.top()) << endl;
	//num_stk.pop();
}
 bool cal_data::is_number(char c)
{
	string numbers = "0123456789";
	if (numbers.find(c) != string::npos)
	{
		return true;
	}
	else
		return false;
}
string::size_type 
cal_data::num_size(string& expr, string::size_type pos)
{
	string numbers = "0123456789";
	string::size_type size;
	size = expr.find_first_not_of(numbers, pos) - pos;
	return size;
}
int cal_data::oper_priority(char c)
{
	if (c == '+' || c == '-')
		return 0;
	else if (c == '*')
		return 1;
	else if (c == '/')
		return 2;
}
void cal_data::calculate()
{
	double left_num=0;
	double right_num=0;
	double result = 0;
	char op = oper_stk.top();
	oper_stk.pop();
	right_num=num_stk.top();
	num_stk.pop();
	left_num = num_stk.top();
	num_stk.pop();
	if (op == '+')
	{
		result = left_num + right_num;
	}
	else if (op == '-')
	{
		result = left_num - right_num;
	}
	else if (op == '*')
	{
		result = left_num * right_num;
	}
	else if(op=='/')
	{
		result = left_num / right_num;
	}
	num_stk.push(result);
}