#include"Produce.h"
void p_str::pruduce()
{
	int num_1 = rand() % 99 + 1;
	int num_2 = rand() % 99 + 1;
	int num_3 = rand() % 99 + 1;
	int op_1(rand() % 4);
	int op_2(rand() % 4);
	expr = std::to_string(num_1) + set_oper(op_1) + std::to_string(num_2)
		+ set_oper(op_2) + std::to_string(num_3);
}
char p_str::set_oper(int  c)
{
	if (c == 0)
		return '+';
	else if (c == 1)
		return '-';
	else if (c == 2)
		return '*';
	else if (c == 3)
		return '/';
}
