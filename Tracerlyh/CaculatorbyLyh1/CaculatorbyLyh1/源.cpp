//github�ύ����2
#define _CRT_SECURE_NOWARNINGS
#include<iostream>
#include<fstream>
#include<stdlib.h>
#include<ctime>
#include<cstdlib>
#include"Calculator.h"
using namespace std;
int main()
{
	int num = 0;//��¼�û���Ҫ������Ŀ�ĸ���
	bool flag = 1;
	cout << "��������Ҫ����Ŀ����(������һ������)��";
	cin >> num;
	TheFourSpecies(num);
	cout << "<�����ɹ�����Ŀ�Լ�����д����Ӧ��txt�ļ��������>" << endl;
	system("pause");
	return 0;
}