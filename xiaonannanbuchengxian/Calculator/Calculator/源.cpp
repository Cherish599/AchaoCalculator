#include <iostream>
#include <time.h>

using namespace std;


int main()
{
	int N, num1, num2, num3, count = 0, result, resultTrue, flag;
	char op1, op2;

	cout << "�������������ɵ���Ŀ��Ŀ��" << endl;
	cin >> N;//����
	cout << "������" << N << "���⣬��ʼ����ɣ�";

	srand(time(NULL));//���������

	do {
		num1 = rand() % 100 + 1;
		num2 = rand() % 100 + 1;
		num3 = rand() % 100 + 1;

		if (num1 % num2 != 0 || num2 % num3 != 0 || (num1 / num2) % num3 != 0)
		{
			num1 = rand() % 100 + 1;
			num2 = rand() % 100 + 1;
			num3 = rand() % 100 + 1;//��֤�����в������С��
		}
		else
		{
			count++;//����һ����ʽ�������count��1
			switch (num1 % 4)//�������4�������
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
			switch (num2 % 4)//ͬ�ϣ�������ɵڶ��������
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
			cout << num1 << " " << op1 << " " << num2 << " " << op2 << " " << num3 << " " << "=";//��������ʽ

			if (flag == 0)//�����Ⱥ�˳���ȷ����flag0Ϊ�ȼ���num1,num2,flag1Ϊ�ȼ���num2,num3
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
				cout << "Right!�����̫���ˣ�" << endl;
			else
				cout << "faulse����������Ŷ��������һ��ļ���ɣ�";
		}
	}

	while (count <= N - 1);//����������ֹ����
	return 0;
}