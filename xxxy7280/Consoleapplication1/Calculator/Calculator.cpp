// Calculator.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
//

#include "pch.h"
#include <iostream>

#include "pch.h"
#include<stdlib.h>//头文件包含rand和srand函数
#include<time.h>
#include <iostream>
#include <fstream>
#include <cstdlib>
#define random()(rand()%1000)
using namespace std;
FILE * fp;
#define MaxSize 100
//符号栈
struct opstack {
	char data[MaxSize];//存储操作符 
	int top;//指向栈顶的指针 
}op;
//数值栈
struct ststack {
	float data[MaxSize];//存储操作符数 
	int top;//指向栈顶的指针 
}st;
char proOperator()//生成运算符
{
	int x;
	char op_;
	//srand(time(0));
	x = random() % 4 + 1;//x在1-4中
	switch (x)
	{
	case 1:op_ = '+'; break;
	case 2:op_ = '-'; break;
	case 3:op_ = '*'; break;
	case 4:op_ = '/'; break;
		//default:
	}
	return op_;
}
//将算术表达式exp转换为后缀表达式postexp
void trans(char exp[], char postexp[]) {
	char ch;
	int i = 0, j = 0; //i扫描exp的下标,j扫描postexp的下标
	op.top = -1;
	ch = exp[i]; i++;
	while (ch != '\0')
	{
		switch (ch) {
		case '+':   //为'+'或'-'时，其优先级不大于栈顶任何运算符的优先级，直到')'
		case '-':
			while (op.top != -1)
			{
				postexp[j] = op.data[op.top]; j++;
				op.top--;
			}
			op.top++; op.data[op.top] = ch;
			break;
		case '*':
		case '/':  //为'*'或'/'时，其优先级不大于栈顶为'*'或'/'的优先级
			while (op.top != -1 && op.data[op.top] != '(' && (op.data[op.top] == '*' || op.data[op.top] == '/'))
			{
				postexp[j] = op.data[op.top]; j++;
				op.top--;
			}
			op.top++; op.data[op.top] = ch;
			break;
		case ' ': break;  //过滤空格
		default:
			while (ch >= '0' && ch <= '9')
			{
				postexp[j] = ch; j++;
				ch = exp[i]; i++;
			}
			i--;
			postexp[j] = '#'; j++;
			//postexp[j]=' '; j++; //用空格标识一个数值串结束

		}
		ch = exp[i]; i++;
	}

	while (op.top != -1) { //此时，exp扫描完毕，栈不空时出栈并存放到postexp中
		postexp[j] = op.data[op.top]; j++;
		op.top--;
	}
	postexp[j] = '\0'; //给postexp表达式添加结束标识

}
//计算后缀表达式
float compvalue(char postexp[]) {
	float d;
	char ch;
	int i = 0;
	st.top = -1;
	ch = postexp[i]; i++;
	while (ch != '\0')
	{
		switch (ch) {
		case '+': st.data[st.top - 1] = st.data[st.top - 1] + st.data[st.top];//遇到操作符就弹出两个数 并将结果进栈 
			st.top--; break;
		case '-': st.data[st.top - 1] = st.data[st.top - 1] - st.data[st.top];
			st.top--; break;
		case '*': st.data[st.top - 1] = st.data[st.top - 1] * st.data[st.top];
			st.top--; break;
		case '/':
			if (st.data[st.top] != 0)
				st.data[st.top - 1] = st.data[st.top - 1] / st.data[st.top];
			else {
				printf("\n\t除零错误!\n");//防止除数为0 
				exit(0);
			}
			st.top--; break;
		default:
			d = 0;
			while (ch >= '0' && ch <= '9')//遇到操作数就进栈直到#为止 
			{
				d = 10 * d + ch - '0';
				ch = postexp[i]; i++;
			}
			st.top++;
			st.data[st.top] = d;

		}
		ch = postexp[i]; i++;
	}
	return st.data[st.top];//输出栈顶元素就是结果 

}

//随机产生操作数 形参为操作数数量num

void proDigital(int num)
{
	int i, x;
	char ch;
	for (i = 0; i < num + num - 1; )
	{
		//srand(time(0));
		x = random() % (101);//产生0-100的随机数作为操作数
		fprintf(fp, "%d", x);	i++;
		if (i < num + num - 2)//2+3*4-1//5
		{
			ch = proOperator();//产生一个运算符
			fputc(ch, fp); i++;
		}
	}
	fputc('=', fp);
	fputc('\n', fp);
}
//读取表达式 计算其值输入文件中
void Calculate()
{
	char buffer[256];
	char postexp[256];
	float ret;
	ifstream in("D:\\2025的作业\\四则运算\\test.txt");
	if (!in.is_open())
	{
		cout << "Error opening file"; exit(1);
	}
	while (!in.eof())
	{
		in.getline(buffer, 100);
		trans(buffer, postexp);
		ret = compvalue(postexp);
		fprintf(fp, "%f", ret);
		fputc('  ', fp);
	}
}
//产生表达式并写入文件
void proExpression(int n)
{
	int i;
	int num;//操作数数量
	for (i = 0; i < n; i++)
	{
		num = random() % 4 + 2;//随机产生操作数数量2-5
		proDigital(num);//随机产生操作数
	//产生表达式 5 a-b+c*d/3
	}
	Calculate();
}

int main()
{
	int n;//产生表达式
	errno_t  err;
	cout << "输入表达式数量";//用n接收
	cin >> n;
	err = fopen_s(&fp, "D:\\2025的作业\\四则运算\\test.txt", "r+");
	proExpression(n);
	fclose(fp);
	cout << "it is ok." << endl;
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
