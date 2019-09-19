// 阿超的计算器.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
#include"pch.h"
#include<iostream>
#include<ctime>
#include<fstream>

using namespace std;



int number1()    //number1为第一个数
{
	int number1;

	number1 = rand() % 100;

	return number1;

}


int number2()  //number2为第二个数
{
	int number2;
	number2 = 1 + rand() % 100;
	return number2;
}


int number3() //number3为第三个数
{
	int number;
	number = 1 + rand() % 100;
	return number;
}


int tool()
{
	int number3;
	number3 = rand() % 4;
	return number3;
}


int sign1()//第一个的运算符 随机生成第一个+ - * /
{
	int num;
	num = rand() % 4;
	return num;
}

int sign2()//第二个的运算符 随机生成第二个+ - * /
{
	int num;
	num = rand() % 4;
	return num;
}


bool judge(float number1)//判断除法运算中，结果是否为分数
{
	return number1 == static_cast<int>(number1);
}

int main()
{
	float num1, num2, num6, n;
	int num3, num4, num5;
	float sum = 0, sum1 = 0;
	char a[4] = { '+','-','*','/' };
	
	ofstream out("给阿超儿子的题目.txt");


	srand(time(NULL));

	cout << "请输入你需要多少个算式：" << endl;

	cin >> n;

	for (float i = 0;i < n;i++)
	{
		num1 = number1();
		num2 = number2();
		num6 = number3();
		num3 = tool();
		num4 = sign1();
		num5 = sign2();

		if (num4 == 0) {
			sum = num1 + num2;

			do {
				num6 = number3();
				switch (num5)
				{
				case 0:sum1 = sum + num6;break;
				case 1:sum1 = sum - num6;break;
				case 2:sum1 = sum * num6;break;
				case 3:sum1 = sum / num6;break;
				}
			} while (!judge(sum1));
		}

		if (num4 == 1) {
			sum = num1 - num2;
			do {
				num6 = number3();
				switch (num5)
				{
				case 0:sum1 = sum + num6;break;
				case 1:sum1 = sum - num6;break;
				case 2:sum1 = sum * num6;break;
				case 3:sum1 = sum / num6;break;
				}
			} while (!judge(sum1));
		}


		if (num4 == 2) {
			sum = num1 * num2;
			do {
				num6 = number3();
				switch (num5)
				{
				case 0:sum1 = sum + num6;break;
				case 1:sum1 = sum - num6;break;
				case 2:sum1 = sum * num6;break;
				case 3:sum1 = sum / num6;break;
				}
			} while (!judge(sum1));
		}

		if (num4 == 3) {
			do {
				num1 = number1();
				num2 = number2();
				sum = num1 / num2;
			} while (!judge(sum));

			do {
				num6 = number3();
				switch (num5)
				{
				case 0:sum1 = sum + num6;break;
				case 1:sum1 = sum - num6;break;
				case 2:sum1 = sum * num6;break;
				case 3:sum1 = sum / num6;break;
				}
			} while (!judge(sum1));
		}

		switch (num3)
		{
		case 0:out << num1 << a[num4] << num2 << a[num5] << num6 << "=" << sum1 << endl;break;

		case 1:out << num1 << a[num4] << num2 << a[num5] << num6 << "=" << sum1 << endl;break;

		case 2:out << num1 << a[num4] << num2 << a[num5] << num6 << "=" << sum1 << endl;break;

		case 3:out << num1 << "+" << num2 << "*" << num6 << "-" << num1 << "=" << num1 + num2 * num6 - num1 << endl;break;
		}

	}
	out.close();
	return 0;
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
