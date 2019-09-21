// ca'lculator.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
#include "pch.h"
#include"Calculator.h"
#include <iostream>
#include<fstream>
#include<stdlib.h>
#include<time.h>

std::ofstream OutFile;
using namespace std;
//输入题目数量
void Calculator::calculator()

{
	cout << "Please input how many quetions you want to set:";
	cin >> Quenumbers;
}

//将题目内容显示在屏幕中
void Calculator::showQuestions()
{
	int a, b, c, d;//参与运算的数字
	int key;//用于控制随机式子
	srand((unsigned)time(NULL));



	for (int i = 0; i < Quenumbers; i++)
	{
		do
		{
			a = rand() % 101;
			b = rand() % 101;
			c = rand() % 101;
			d = rand() % 101;
			key = rand() % 10 + 1;
			switch (key)
			{
			case 1:
				answers[i] = a + b * c;
				if (Is_int(answers[i]))
				{
					cout << a << "+" << b << "*" << c << "=" << endl;
					OutFile.open("subject.txt", ios::app);
					OutFile << a << "+" << b << "*" << c << "=" << endl;
					OutFile.close();
				}
				break;
			case 2:
				answers[i] = a + b - c;
				if (Is_int(answers[i]))
				{
					cout << a << "+" << b << "-" << c << "=" << endl;
					OutFile.open("subject.txt", ios::app);
					OutFile << a << "+" << b << "-" << c << "=" << endl;
					OutFile.close();
				}
				break;
			case 3:
				answers[i] = a * 1.0*b / c;
				if (Is_int(answers[i]))
				{
					cout << a << "*" << b << "÷" << c << "=" << endl;
					OutFile.open("subject.txt", ios::app);
					OutFile << a << "*" << b << "÷" << c << "=" << endl;
					OutFile.close();
				}
				break;
			case 4:
				answers[i] = a - 1.0*b / c;
				if (Is_int(answers[i]))
				{
					cout << a << "-" << b << "÷" << c << "=" << endl;
					OutFile.open("subject.txt", ios::app);
					OutFile << a << "-" << b << "÷" << c << "=" << endl;
					OutFile.close();
				}

				break;
			case 5:
				answers[i] = a * b - c;
				if (Is_int(answers[i]))
				{
					cout << a << "*" << b << "-" << c << "=" << endl;
					OutFile.open("subject.txt", ios::app);
					OutFile << a << "*" << b << "-" << c << "=" << endl;
					OutFile.close();
				}
				break;
			case 6:
				answers[i] = a * b - c + d;
				if (Is_int(answers[i]))
				{
					cout << a << "*" << b << "-" << c << "+" << d << "=" << endl;
					OutFile.open("subject.txt", ios::app);
					OutFile << a << "*" << b << "-" << c << "+" << d << "=" << endl;
					OutFile.close();
				}
				break;
			case 7:
				answers[i] = a + b * c - d;
				if (Is_int(answers[i]))
				{
					cout << a << "+" << b << "*" << c << "-" << d << "=" << endl;
					OutFile.open("subject.txt", ios::app);
					OutFile << a << "+" << b << "*" << c << "-" << d << "=" << endl;
					OutFile.close();
				}
				break;
			case 8:
				answers[i] = a * b + c - d;
				if (Is_int(answers[i]))
				{
					cout << a << "*" << b << "+" << c << "-" << d << "=" << endl;
					OutFile.open("subject.txt", ios::app);
					OutFile << a << "*" << b << "+" << c << "-" << d << "=" << endl;
					OutFile.close();
				}
				break;
			case 9:
				answers[i] = a - 1.0*b / c + d;
				if (Is_int(answers[i]))
				{
					cout << a << "-" << b << "÷" << c << "+" << d << "=" << endl;
					OutFile.open("subject.txt", ios::app);
					OutFile << a << "-" << b << "÷" << c << "+" << d << "=" << endl;
					OutFile.close();

				}
				break;
			case 10:
				answers[i] = 1.0*a / b - c * d;
				if (Is_int(answers[i]))
				{
					cout << a << "÷" << b << "-" << c << "*" << d << "=" << endl;
					OutFile.open("subject.txt", ios::app);
					OutFile << a << "÷" << b << "-" << c << "*" << d << "=" << endl;
					OutFile.close();
				}
				break;

			}
		} while (!Is_int(answers[i]));
	}

}


//判断结果是否为整数
bool Calculator::Is_int(float a)
{
	return a == static_cast<int>(a);
}




//将题目结果显示在屏幕上
void Calculator::showResult()
{


	cout << "The answers of these questions are as follows:" << endl;
	OutFile.open("subject.txt", ios::app);
	OutFile << "The answers of these questions are as follows:" << endl;
	OutFile.close();

	for (int i = 0; i < Quenumbers; i++)
	{
		cout << "Question" << i + 1 << ":" << answers[i] << endl;
		OutFile.open("subject.txt", ios::app);
		OutFile << "Question" << i + 1 << ":" << answers[i] << endl;
		OutFile.close();
	}
}




//int main()
//{
//    std::cout << "Hello World!\n"; 
//}

// 运行程序: Ctrl + F5 或调试 >“开始执行(不调试)”菜单
// 调试程序: F5 或调试 >“开始调试”菜单

// 入门提示: 
//   1. 使用解决方案资源管理器窗口添加/管理文件
//   2. 使用团队资源管理器窗口连接到源代码管理
//   3. 使用输出窗口查看生成输出和其他消息
//   4. 使用错误列表窗口查看错误
//   5. 转到“项目”>“添加新项”以创建新的代码文件，或转到“项目”>“添加现有项”以将现有代码文件添加到项目
//   6. 将来，若要再次打开此项目，请转到“文件”>“打开”>“项目”并选择 .sln 文件
