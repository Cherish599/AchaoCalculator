#include<iostream>
#include<string>
#include<stack>
#include"Calculater.h"
#include"Produce.h"
using namespace std;
int main()
{
	srand(static_cast<unsigned int>(time(0)));
	int num;
	cout << "Input num" << endl;
	cin >> num;
	while (num)
	{
		p_str str;
		cal_data cal(str.get_str());
		--num;
	}
	return 0;
}