//github�ύ����1
#define _CRT_SECURE_NOWARNINGS
#include<iostream>
#include<fstream>
#include<stdlib.h>
#include<ctime>
#include<cstdlib>
using namespace std;
char Getachar()//����һ�������
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
void TheFourSpecies(int num)//��������:a+b*c=
{
	fstream fp;//�洢��Ŀ
	fstream fp1;//�洢��
	fp.open("���.txt", ios::out);//����ļ���ԭ������
	fp1.open("��.txt", ios::out);//ͬ��
	fp.close();
	fp1.close();
	fp.open("���.txt", ios::app);//��׷�ӵķ�ʽ���ļ�
	fp1.open("��.txt", ios::app);//ͬ��
	int a = 0;
	int b = 0;
	int c = 0;
	int n = 1;
	int numofnum = 0;//���ʽ�����ֵĸ���
	char ch1;//�����1
	char ch2;//�����2
	srand(time(nullptr));
	for (int i = 0; i < num; ++i)//����num������������Ŀд�뵽���.txt��
	{
		numofnum = 2 + rand() % 2;//�������е����ֵĸ���:2��3
		a = rand() % 100;
		b = rand() % 100;
		c = rand() % 100;
		ch1 = Getachar();//�õ�һ������������
		ch2 = Getachar();//�õ�һ������������
		if (numofnum == 2)//����������
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
				if (b == 0 || a != b * (a / b))//���̲�Ϊ����ʱ������Ϊa,b��ֵ
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
		else//����������
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
					if (c == 0 || b != c * (b / c))//���̲�Ϊ����ʱ������Ϊb,c��ֵ
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
					if ((a - (b * c)) < 0)//���̲�Ϊ����ʱ������Ϊb,c��ֵ
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
	int num = 0;//��¼�û���Ҫ������Ŀ�ĸ���
	bool flag = 1;
	cout << "��������Ҫ����Ŀ����(������һ������)��";
	cin >> num;
	TheFourSpecies(num);
	cout << "<��Ŀ�Լ�����д����Ӧ��txt�ļ�>" << endl;
	system("pause");
	return 0;
}