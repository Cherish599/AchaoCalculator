#include <fstream>
#include<iostream>
#include<stdlib.h>
using namespace std;
int main()
{


	int n, m = 0;
	cout << "请输入要产生的题目数目" << endl;
	cin >> n;
	do

	{
		int num4;
		srand(rand());
		int num1 = rand() % 100;
		int num2 = rand() % 100;
		int num5 = rand() % 100;
		int num3 = rand() % 16;
		if (num3 == 0)
		{
			num4 = num1 + num2 + num5;
			cout << num1 << "+" << num2 << "+" << num5 << "=" << num4 << endl;
			;
			m = m + 1;

		}
		else if (num3 == 1)
		{
			num4 = num1 + num2 - num5;
			cout << num1 << "+" << num2 << "-" << num5 << "=" << num4 << endl;
			m = m + 1;
		}
		else if (num3 == 2)
		{
			num4 = num1 + num2 * num5;
			cout << num1 << "+" << num2 << "*" << num5 << "=" << num4 << endl;
			m = m + 1;
		}
		else if (num3 == 3 && num2%num5 == 0)
		{
			num4 = num1 + num2 / num5;
			cout << num1 << "+" << num2 << "/" << num5 << "=" << num4 << endl;
			m = m + 1;
		}
		else if (num3 == 3 && num2%num5 != 0)
		{
			if (num2 > num5)
			{
				do {
					num2++;
				} while (num2%num5 != 0);
			}
			if (num2 < num5)
			{
				do {
					num2--;
				} while (num2%num5 != 0);
			}
			num4 = num1 + num2 / num5;
			cout << num1 << "+" << num2 << "/" << num5 << "=" << num4 << endl;
		}
		else if (num3 == 4)
		{
			num4 = num1 - num2 + num5;
			cout << num1 << "-" << num2 << "+" << num5 << "=" << num4 << endl;
			m = m + 1;
		}
		else if (num3 == 5)
		{
			num4 = num1 - num2 - num5;
			cout << num1 << "-" << num2 << "-" << num5 << "=" << num4 << endl;
			m = m + 1;
		}
		else if (num3 == 6)
		{
			num4 = num1 - num2 * num5;
			cout << num1 << "-" << num2 << "*" << num5 << "=" << num4 << endl;
			m = m + 1;
		}
		else if (num3 == 7 && num2%num5 == 0)
		{
			num4 = num1 - num2 / num5;
			cout << num1 << "-" << num2 << "/" << num5 << "=" << num4 << endl;
			m = m + 1;
		}
		else if (num3 == 7 && num2%num5 != 0)
		{
			if (num2 > num5)
			{
				do {
					num2++;
				} while (num2%num5 != 0);
			}
			if (num2 < num5)
			{
				do {
					num2--;
				} while (num2%num5 != 0);
			}
			num4 = num1 - num2 / num5;
			cout << num1 << "-" << num2 << "/" << num5 << "=" << num4 << endl;
		}
		else if (num3 == 8)
		{
			num4 = num1 * num2 + num5;
			cout << num1 << "*" << num2 << "+" << num5 << "=" << num4 << endl;
			m = m + 1;
		}
		else if (num3 == 9)
		{
			num4 = num1 * num2 - num5;
			cout << num1 << "*" << num2 << "-" << num5 << "=" << num4 << endl;
			m = m + 1;
		}
		else if (num3 == 10)
		{
			num4 = num1 * num2 * num5;
			cout << num1 << "*" << num2 << "*" << num5 << "=" << num4 << endl;
			m = m + 1;
		}
		else if (num3 == 11 && num2%num5 == 0)
		{
			num4 = num1 * num2 / num5;
			cout << num1 << "*" << num2 << "/" << num5 << "=" << num4 << endl;
			m = m + 1;
		}
		else if (num3 == 11 && num2%num5 != 0)
		{
			if (num2 > num5)
			{
				do {
					num2++;
				} while (num2%num5 != 0);
			}
			if (num2 < num5)
			{
				do {
					num2--;
				} while (num2%num5 != 0);
			}
			num4 = num1 * num2 / num5;
			cout << num1 << "*" << num2 << "/" << num5 << "=" << num4 << endl;
		}
		else if (num3 == 12 && num1%num2 == 0)
		{
			num4 = num1 / num2 + num5;
			cout << num1 << "/" << num2 << "+" << num5 << "=" << num4 << endl;
			m = m + 1;
		}
		else if (num3 == 12 && num1%num2 != 0)
		{
			if (num1 > num2)
			{
				do {
					num2++;
				} while (num1%num2 != 0);
			}
			if (num1 < num2)
			{
				do {
					num2--;
				} while (num1%num2 != 0);
			}
			num4 = num1 / num2 + num5;
			cout << num1 << "/" << num2 << "+" << num5 << "=" << num4 << endl;
		}
		else if (num3 == 13 && num1%num2 == 0)
		{
			num4 = num1 / num2 - num5;
			cout << num1 << "/" << num2 << "-" << num5 << "=" << num4 << endl;
			m = m + 1;
		}
		else if (num3 == 13 && num1%num2 != 0)
		{
			if (num1 > num2)
			{
				do {
					num2++;
				} while (num1%num2 != 0);
			}
			if (num1 < num2)
			{
				do {
					num2--;
				} while (num1%num2 != 0);
			}
			num4 = num1 / num2 - num5;
			cout << num1 << "/" << num2 << "-" << num5 << "=" << num4 << endl;
		}
		else if (num3 == 14 && num1%num2 == 0)
		{
			num4 = num1 / num2 * num5;
			cout << num1 << "/" << num2 << "*" << num5 << "=" << num4 << endl;
			m = m + 1;
		}
		else if (num3 == 14 && num1%num2 != 0)
		{
			if (num1 > num2)
			{
				do {
					num2++;
				} while (num1%num2 != 0);
			}
			if (num1 < num2)
			{
				do {
					num2--;
				} while (num1%num2 != 0);
			}
			num4 = num1 / num2 * num5;
			cout << num1 << "/" << num2 << "*" << num5 << "=" << num4 << endl;
		}
		else if (num3 == 12 && num1%num2 == 0 && (num1%num2) % num5 == 0)
		{
			num4 = num1 / num2 / num5;
			cout << num1 << "/" << num2 << "/" << num5 << "=" << num4 << endl;
			m = m + 1;




		}
	} while (m != n - 1);
}
