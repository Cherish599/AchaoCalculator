#include <iostream>
#include <time.h>

using namespace std;


int main()
{
	int N, num1, num2, num3, count = 0, result, resultTrue, flag;
	char op1, op2;

	cout << "请输入你想生成的题目数目：" << endl;
	cin >> N;//题数
	cout << "这里有" << N << "道题，开始计算吧！";

	srand(time(NULL));//生成随机数

	do {
		num1 = rand() % 100 + 1;
		num2 = rand() % 100 + 1;
		num3 = rand() % 100 + 1;

		if (num1 % num2 != 0 || num2 % num3 != 0 || (num1 / num2) % num3 != 0)
		{
			num1 = rand() % 100 + 1;
			num2 = rand() % 100 + 1;
			num3 = rand() % 100 + 1;//保证运算中不会出现小数
		}
		else
		{
			count++;//生成一个算式并计算后count加1
			switch (num1 % 4)//随机生成4种运算符
			{
			case 0:
				op1 = '+';
				break;
			case 1:
				op1 = '-';
				break;
			case 2:
				op1 = '*';
				break;
			case 3:
				op1 = '/';
				break;
			default:
				break;
			}
			switch (num2 % 4)//同上，随机生成第二种运算符
			{
			case 0:
				op2 = '+';
				flag = 0;
				break;
			case 1:
				op2 = '-';
				flag = 0;
				break;
			case 2:
				op2 = '*';
				if ((op1 == '*') || (op1 == '/')) flag = 0;
				else flag = 1;
				break;
			case 3:
				op2 = '/';
				if ((op1 == '*') || (op1 == '/')) flag = 0;
				else flag = 1;
				break;
			default:
				break;
			}
			cout << num1 << " " << op1 << " " << num2 << " " << op2 << " " << num3 << " " << "=";//生成算术式

			if (flag == 0)//运算先后顺序的确定，flag0为先计算num1,num2,flag1为先计算num2,num3
			{
				resultTrue = 0;
				switch (op1)
				{
				case '+':
					resultTrue = num1 + num2;
					break;
				case '-':
					resultTrue = num1 - num2;
					break;
				case '*':
					resultTrue = num1*num2;
					break;
				case '/':
					resultTrue = num1 / num2;
					break;
				default:
					break;
				}
				switch (op2)
				{
				case '+':
					resultTrue += num3;
					break;
				case '-':
					resultTrue -= num3;
					break;
				case '*':
					resultTrue *= num3;
					break;
				case '/':
					resultTrue /= num3;
					break;
				default:
					break;
				}
			}

			else
			{
				resultTrue = 0;
				switch (op2)
				{
				case '+':
					resultTrue = num2 + num3;
					break;
				case '-':
					resultTrue = num2 - num3;
					break;
				case '*':
					resultTrue = num2*num3;
					break;
				case '/':
					resultTrue = num2 / num3;
					break;
				default:
					break;
				}
				switch (op1)
				{
				case '+':
					resultTrue += num1;
					break;
				case '-':
					resultTrue -= num1;
					break;
				case '*':
					resultTrue *= num1;
					break;
				case '/':
					resultTrue /= num1;
					break;
				default:
					break;
				}
			}

			cin >> result;
			if (result == resultTrue)
				cout << "Right!你真的太棒了！" << endl;
			else
				cout << "faulse！继续加油哦，进行下一题的计算吧！";
		}
	}

	while (count <= N - 1);//题数生成终止条件
	return 0;
}