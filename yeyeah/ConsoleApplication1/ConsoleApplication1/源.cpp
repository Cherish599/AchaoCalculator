

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
		int x;
		srand((int)rand());
		int n1 = rand() % 100;
		int n2 = rand() % 100;
		int n3 = rand() % 100;
		int n4 = rand() % 100;
		int y = rand() % 10;
		if (y == 0)
		{
			x = n1 + n2 + n3 + n4;
			cout << n1 << "+" << n2 << "+" << n3 << "+" << n4 << "=" << x << endl;
			;
			m = m + 1;
		}
		else if (y == 1)
		{
			x = n1 + n2 - n3 + n4;
			cout << n1 << "+" << n2 << "-" << n3 << "+" << n4 << "=" << x << endl;
			m = m + 1;
		}
		else if (y == 2)
		{
			x = n1 + n2 * n3 + n4;
			cout << n1 << "+" << n2 << "*" << n3 << "+" << n4 << "=" << x << endl;
			m = m + 1;
		}
		else if (y == 3 && n2%n3 == 0)
		{
			x = n1 + n2 / n3 + n4;
			cout << n1 << "+" << n2 << "/" << n3 << "+" << n4 << "=" << x << endl;
			m = m + 1;
		}
		else if (y == 3 && n2%n3 != 0)
		{
			if (n2 > n3)
			{
				do {
					n2++;
				} while (n2%n3 != 0);
			}
			if (n2 < n3)
			{
				do {
					n2--;
				} while (n2%n3 != 0);
			}
			x = n1 + n2 / n3 + n4;
			cout << n1 << "+" << n2 << "/" << n3 << "+" << n4 << "=" << x << endl;
		}
		else if (y == 4)
		{
			x = n1 - n2 + n3 * n4;
			cout << n1 << "-" << n2 << "+" << n3 << "*" << n4 << "=" << x << endl;
			m = m + 1;
		}
		else if (y == 5)
		{
			x = n1 - n2 - n3 + n4;
			cout << n1 << "-" << n2 << "-" << n3 << "+" << n4 << "=" << x << endl;
			m = m + 1;
		}
		else if (y == 6)
		{
			x = n1 * n2 * n3 - n4;
			cout << n1 << "*" << n2 << "*" << n3 << "-" << n4 << "=" << x << endl;
			m = m + 1;
		}
		else if (y == 7 && n1%n2 == 0)
		{
			x = n1 / n2 + n3 + n4;
			cout << n1 << "/" << n2 << "+" << n3 << "+" << n4 << "=" << x << endl;
			m = m + 1;
		}
		else if (y == 7 && n1%n2 != 0)
		{
			if (n1 > n2)
			{
				do {
					n1++;
				} while (n1%n2 != 0);
			}
			if (n1 < n2)
			{
				do {
					n1--;
				} while (n1%n2 != 0);
			}
			x = n1 / n2 + n3 + n4;
			cout << n1 << "/" << n2 << "+" << n3 << "+" << n4 << "=" << x << endl;
		}
		else if (y == 8)
		{
			x = n1 + n2 - n3;
			cout << n1 << "+" << n2 << "-" << n3 << "=" << x << endl;
			m = m + 1;
		}
	} while (m != n);
	return 0;
}
