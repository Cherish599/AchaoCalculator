#pragma once
#include<ctime>
#include<cstdlib>
#include<string>
class p_str
{
public:
	p_str()
	{
		pruduce();
	}
	std::string get_str() { return expr; }
private:
	std::string expr;
	void pruduce();
	char set_oper(int  c);
};

