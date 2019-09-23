// ConsoleApplication1.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
//

#include "pch.h"
#include <iostream>
#include<stdlib.h>
#include <cmath>
using namespace std;

int main()
{
	int n,h,f,j[4];//辅助变量
	double s[4],a[4];
	int m,b[4] = {'+','-','*','/'}, i;//i运算符个数，m题目个数
	char p[3];
	cout << "请输入需要的题目个数：" << endl;
	cin >> m;
	for (int e = 1; e <= m; e++)
	{
		i = (rand() % (3 - 2 + 1)) + 2;//运算符的个数2-3之间


		for (n = 0; n < i; n++)
		{
			a[n] = (rand() % (99 - 1 + 1)) + 1;//随机产生数字a[n]在0-100之间
			h = (rand() % (3 - 0 + 1)) + 0;//随机生成运算符并排序
			p[n] = b[h];
		}
		a[i] = (rand() % (99 - 1 + 1)) + 1;//最后一个数


		for (n = 0; n < i; n++)//判断是否会出现小数
		{
			if (p[n] == '/')
				s[n] = a[n] / a[n + 1];
			else
				s[n] = 1;
		}

		for (n = 0; n < i; n++)
		{
			j[n] = (int)(s[n]);
		}

		int op = 1;
		for (n = 0; n < i; n++)//判断是否出现了小数
		{
			if (s[n] != j[n])
				op = 0;
		}

		if (op == 1)
		{
			for (n = 0; n < i; n++)//输出
			{
				cout << a[n];
				cout << p[n];
			}
			cout << a[i] << " " << '=' << endl;
		}
		else
			e = e - 1;
		
	}
	
}

// 运行程序: Ctrl + F5 或调试 >“开始执行(不调试)”菜单
// 调试程序: F5 或调试 >“开始调试”菜单

// 入门提示: 
//   1. 使用解决方案资源管理器窗口添加/管理文件
//   2. 使用团队资源管理器窗口连接到源代码管理
//   3. 使用输出窗口查看生成输出和其他消息
//   4. 使用错误列表窗口查看错误
//   5. 转到“项目”>“添加新项”以创建新的代码文件，或转到“项目”>“添加现有项”以将现有代码文件添加到项目
//   6. 将来，若要再次打开此项目，请转到“文件”>“打开”>“项目”并选择 .sln 文件


