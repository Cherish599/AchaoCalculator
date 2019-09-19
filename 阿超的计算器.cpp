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


int tool()//最后生成算式时的判断条件
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
	float num1, num2, num6, n;//依次分别是第一个数，第二个数，第三个数和需要算式的数量
	int num3, num4, num5;//num3是输出算式的表达结果，num4是第一个算数符号，num5是第二个算数符号
	float sum = 0, sum1 = 0;//sum为前两个数的和，sum1为sum和第三个数的和
	char a[4] = { '+','-','*','/' };//初始化一个数组，0,1,2,3分别代表+，-，*，/
	
	ofstream out("给阿超儿子的题目.txt");//将输出的算式写入txt文件里，而不是在屏幕上呈现


	srand(time(NULL));//用time头文件来实现真正的随机数

	cout << "请输入你需要多少个算式：" << endl;

	cin >> n;//输入你需要的算式个数

	for (float i = 0;i < n;i++)
	{
		num1 = number1();
		num2 = number2();
		num6 = number3();
		num3 = tool();
		num4 = sign1();
		num5 = sign2();

		//第一个算式符为‘+’时
		if (num4 == 0) {
			sum = num1 + num2;//前两个数之和

			do {
				num6 = number3();
				switch (num5)
				{
				case 0:sum1 = sum + num6;break;
				case 1:sum1 = sum - num6;break;
				case 2:sum1 = sum * num6;break;
				case 3:sum1 = sum / num6;break;//这个judge函数主要是给除法来用的，下面的if语句用法和这个类似
				}
			} while (!judge(sum1));//如果其中的除法运算为小数时，就继续生成随机数3，直到除法运算可以正常运行（即符合题目要求）
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
			} while (!judge(sum1));//同理
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
			} while (!judge(sum1));//同理
		}

		if (num4 == 3) {
			do {
				num1 = number1();
				num2 = number2();
				sum = num1 / num2;//因为第一个运算符为除法，所以要把第一个和第二个数一起随机出现，直到两数相除符合题目要求
			} while (!judge(sum));//同理

			do {
				num6 = number3();
				switch (num5)
				{
				case 0:sum1 = sum + num6;break;
				case 1:sum1 = sum - num6;break;
				case 2:sum1 = sum * num6;break;
				case 3:sum1 = sum / num6;break;
				}
			} while (!judge(sum1));//同理
		}
		//最后把n个计算式写入到txt文件里（main函数最开始已经定义了）
		switch (num3)
		{
		case 0:out << num1 << a[num4] << num2 << a[num5] << num6 << "=" << sum1 << endl;break;

		case 1:out << num1 << a[num4] << num2 << a[num5] << num6 << "=" << sum1 << endl;break;

		case 2:out << num1 << a[num4] << num2 << a[num5] << num6 << "=" << sum1 << endl;break;

		case 3:out << num1 << "+" << num2 << "*" << num6 << "-" << num1 << "=" << num1 + num2 * num6 - num1 << endl;break;
		}

	}
	out.close();//关闭txt文件
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
