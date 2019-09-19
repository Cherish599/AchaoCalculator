// 第二次.cpp : 定义控制台应用程序的入口点。
//

//#include "第二次.h"
#include "stdafx.h"
#include <iostream>
#include <stdlib.h>
#include <time.h>
#include <fstream>
using namespace std;
class solution
{
public:
	double calculate(string s)
	{
		double result = 0, inter_res = 0, num = 0;
		char op = '+';
		char ch;
                //找到第一个不为空的字符
		for (int pos = s.find_first_not_of(' '); pos < s.size(); pos = s.find_first_not_of(' ', pos))
		{
			ch = s[pos];
                        //判断是否是数字
			if (ch >= '0' && ch <= '9')
			{
				int num = ch - '0';
                                //判断下一个字符是否也是数字
				while (++pos < s.size() && s[pos] >= '0' && s[pos] <= '9')
					num = num * 10 + s[pos] - '0';
				switch (op)
				{
				case '+':
					inter_res += num;
					break;
				case'-':
					inter_res -= num;
					break;
				case'*':
					inter_res *= num;
					break;
				case'/':
					inter_res /= num;
					break;
				}
			}
			else
			{
				if (ch == '+' || ch == '-')
				{
					result += inter_res;
					inter_res = 0;
				}
				op = s[pos++];
			}
		}
		return result + inter_res;
	}
};
int SetRnumber(char c[],int &seed)
{
	int y;
	int  a[10],k=0;
	char b[10];
	srand((int)seed);
	y=rand()%5;
	while(y<3){
		y=rand()%5;
	}
	for(int i=0; i<y; i++)
	{
		a[i]=rand()%100;
	}
	for(int j=0; j<y-1; j++)
	{
		switch(rand()%4)
		{
		case 0:
			b[j]='+';
			break;
		case 1:
			b[j]='-';
			break;
		case 2:
			b[j]='*';
			break;
		case 3:
			b[j]='/';
			break;
		}
	}
	for(int i=0,j=0; i<y; i++,j++)
	{
		if(a[i]<9){
			c[k]=a[i]+'0';
			k++;
			c[k]=b[j];
			k++;
		}
		else{
			c[k+1]=a[i]%10+'0';
			c[k]=a[i]/10+'0';
			k=k+2;
			c[k]=b[j];
			k++;
		}
	}
	c[k-1]='\0';
		seed++;

	return 0;
}
void main()
{
	ofstream mycout("E:/output.txt");
	int seed=time(0);
	int k;
	int n;
	double m;
	char c[100]={1};
	solution s;
	mycout<<"请输入你想产生的题的数量:";
	cin>>n;
	mycout<<n<<endl;
	for(int i=1; i<=n; ){
	SetRnumber(c,seed);
	m=s.calculate(c);
	if(m-(int)m==0 &&m>0){
	for(int j=0; c[j] !='\0';j++)
		{

			mycout<<c[j];
		}
		i++;
		mycout<<'='<<m<<endl;
	}
	}
	mycout.close();
}