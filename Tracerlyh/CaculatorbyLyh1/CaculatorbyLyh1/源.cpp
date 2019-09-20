//github提交测试2
#define _CRT_SECURE_NOWARNINGS
#include<iostream>
#include<fstream>
#include<stdlib.h>
#include<ctime>
#include<cstdlib>
#include"Calculator.h"
using namespace std;
int main()
{
	int num = 0;//记录用户想要出的题目的个数
	bool flag = 1;
	cout << "请输入需要的题目个数(请输入一个整数)：";
	cin >> num;
	TheFourSpecies(num);
	cout << "<操作成功！题目以及答案已写入相应的txt文件，请查收>" << endl;
	system("pause");
	return 0;
}