//github提交测试1
#define _CRT_SECURE_NOWARNINGS
#include<iostream>
#include<fstream>
#include<stdlib.h>
#include<ctime>
#include<cstdlib>
using namespace std;
char Getachar()//返回一个运算符
{
	int i = rand() % 4;
	switch (i)
	{
	case 0:return '*'; break;
	case 1:return '/'; break;
	case 2:return '+'; break;
	case 3:return '-'; break;
	default:
		break;
	}
}
void TheFourSpecies(int num)//四则运算:a+b*c=
{
	fstream fp;//存储题目
	fstream fp1;//存储答案
	fp.open("题库.txt", ios::out);//清空文件中原有内容
	fp1.open("答案.txt", ios::out);//同上
	fp.close();
	fp1.close();
	fp.open("题库.txt", ios::app);//以追加的方式打开文件
	fp1.open("答案.txt", ios::app);//同上
	int a = 0;
	int b = 0;
	int c = 0;
	int n = 1;
	int numofnum = 0;//表达式中数字的个数
	char ch1;//运算符1
	char ch2;//运算符2
	srand(time(nullptr));
	for (int i = 0; i < num; ++i)//生成num道四则运算题目写入到题库.txt中
	{
		numofnum = 2 + rand() % 2;//运算题中的数字的个数:2或3
		a = rand() % 100;
		b = rand() % 100;
		c = rand() % 100;
		ch1 = Getachar();//得到一个随机的运算符
		ch2 = Getachar();//得到一个随机的随机数
		if (numofnum == 2)//两个运算数
		{
			switch (ch1)
			{
			case '+':
				fp << a << ch1 << b << '=' << "        ";
				fp1 << a + b << "        ";
				break;
			case '-':
				if (a - b < 0)
				{
					while (a - b < 0)
					{
						a = rand() % 100;
						b = rand() % 100;
					}
				}
				fp << a << ch1 << b << '=' << "        ";
				fp1 << a - b << "        ";
				break;
			case '*':
				fp << a << ch1 << b << '=' << "        ";
				fp1 << a * b << "        ";
				break;
			case '/':
				if (b == 0 || a != b * (a / b))//当商不为整数时，重新为a,b赋值
				{
					while (b == 0 || a != b * (a / b))
					{
						a = rand() % 100;
						b = rand() % 100;
					}
				}
				fp << a << ch1 << b << '=' << "        ";
				fp1 << a / b << "        ";
				break;
			default:
				break;
			}
		}
		else//三个运算数
		{
			switch (ch1)
			{
			case '+':////////////////////////////////////////////////////
				switch (ch2)
				{
				case'+':
					fp << a << '+' << b << '+' << c << '=' << "        ";
					fp1 << a + b + c << "        ";
					break;
				case '-':
					if (b - c < 0)
					{
						while (b - c < 0)
						{
							b = rand() % 100;
							c = rand() % 100;
						}
					}
					fp << a << '+' << b << '-' << c << '=' << "        ";
					fp1 << a + b - c << "        ";
					break;
				case '*':
					fp << a << '+' << b << '*' << c << '=' << "        ";
					fp1 << a + b * c << "        ";
					break;
				case '/':
					if (c == 0 || b != c * (b / c))//当商不为整数时，重新为b,c赋值
					{
						while (c == 0 || b != c * (b / c))
						{
							b = rand() % 100;
							c = rand() % 100;
						}
					}
					fp << a << '+' << b << '/' << c << '=' << "        ";
					fp1 << a + b / c << "        ";
					break;
				default:
					break;
				}
				break;
				/*****************************************/
			case '-':
				switch (ch2)
				{
				case '+':
					if (a - b < 0)
					{
						while (a - b < 0)
						{
							a = rand() % 100;
							b = rand() % 100;
						}
					}
					fp << a << '-' << b << '+' << c << '=' << "        ";
					fp1 << a - b + c << "        ";
					break;
				case '-':
					if (a < b + c)
					{
						while (a < b + c)
						{
							a = rand() % 100;
							b = rand() % 100;
							c = rand() % 100;
						}
					}
					fp << a << '-' << b << '-' << c << '=' << "        ";
					fp1 << a - b - c << "        ";
					break;
				case '*':
					if ((a - (b * c)) < 0)//当商不为整数时，重新为b,c赋值
					{
						while ((a - (b * c)) < 0)
						{
							a = rand() % 100;
							b = rand() % 100;
							c = rand() % 100;
						}
					}
					fp << a << '-' << b << '*' << c << '=' << "        ";
					fp1 << a - b * c << "        ";
					break;
				case '/':
					if (c == 0 || (b != c * (b / c)) || (a - (b / c) < 0))
					{
						while (c == 0 || (b != c * (b / c)) || (a - (b / c) < 0))
						{
							a = rand() % 100;
							b = rand() % 100;
							c = rand() % 100;
						}
					}
					fp << a << '-' << b << '/' << c << '=' << "        ";
					fp1 << a - b / c << "        ";
					break;
				default:
					break;
				}
				break;
				/****************************************/
			case '*':
				switch (ch2)
				{
				case '+':
					fp << a << '*' << b << '+' << c << '=' << "        ";
					fp1 << a * b + c << "        ";
					break;
				case '-':
					if (a*b < c)
					{
						while (a*b < c)
						{
							a = rand() % 100;
							b = rand() % 100;
							c = rand() % 100;
						}
					}
					fp << a << '*' << b << '-' << c << '=' << "        ";
					fp1 << a * b - c << "        ";
					break;
				case '*':
					fp << a << '*' << b << '*' << c << '=' << "        ";
					fp1 << a * b * c << "        ";
					break;
				case '/':
					if (c == 0 || b != c * (b / c))
					{
						while (c == 0 || b != c * (b / c))
						{
							b = rand() % 100;
							c = rand() % 100;
						}
					}
					fp << a << '*' << b << '/' << c << '=' << "        ";
					fp1 << a * b / c << "        ";
					break;
				default:
					break;
				}
				break;
				/****************************************/
			case '/':
				switch (ch2)
				{
				case '+':
					if (b == 0 || a != b * (a / b))
					{
						while (b == 0 || a != b * (a / b))
						{
							a = rand() % 100;
							b = rand() % 100;
						}
					}
					fp << a << '/' << b << '+' << c << '=' << "        ";
					fp1 << a / b + c << "        ";
					break;
				case '*':
					if (b == 0 || a != b * (a / b))
					{
						while (b == 0 || a != b * (a / b))
						{
							a = rand() % 100;
							b = rand() % 100;
						}
					}
					fp << a << '/' << b << '*' << c << '=' << "        ";
					fp1 << a / b * c << "        ";
					break;
				case '-':
					if (b == 0 || a != b * (a / b) || a / b < c)
					{
						while (b == 0 || a != b * (a / b) || a / b < c)
						{
							a = rand() % 100;
							b = rand() % 100;
							c = rand() % 100;
						}
					}
					fp << a << '/' << b << '-' << c << '=' << "        ";
					fp1 << a / b - c << "        ";
					break;
				case '/':
					if (c == 0 || b == 0 || a != b * (a / b) || b != c * (b / c))
					{
						while (c == 0 || b == 0 || a != b * (a / b) || b != c * (b / c))
						{
							a = rand() % 100;
							b = rand() % 100;
							c = rand() % 100;
						}
					}
					fp << a << '/' << b << '/' << c << '=' << "        ";
					fp1 << a / b / c << "        ";
					break;
				default:
					break;
				}
				break;
			default:
				break;
			}
		}
		if (n % 3 == 0)
		{
			fp << '\n';
			fp1 << '\n';
		}
		++n;
	}
	fp.close();
	fp1.close();
}
int main()
{
	int num = 0;//记录用户想要出的题目的个数
	bool flag = 1;
	cout << "请输入需要的题目个数(请输入一个整数)：";
	cin >> num;
	TheFourSpecies(num);
	cout << "<题目以及答案已写入相应的txt文件>" << endl;
	system("pause");
	return 0;
}