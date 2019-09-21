#include<iostream>
#include<time.h>
#include<windows.h>
#include <fstream>
using namespace std;
void Tot(int n);
void Toto(int n);
typedef int Status;
typedef int QElemType;//定义队列元素数据类型
typedef int QElemType; //队列元素的数据类型
#define TRUE 1
#define FALSE 0
#define OK 1
#define ERROR 0
#define MAXQSIZE 100 //循环队列最大容量
//循环队列类型
typedef struct QNode{
	QElemType *base; //队列元素存储数组
	int front;       //队头指针，若队列不空，则指向队列头元素
	int rear;        //队尾指针，若队列不空，则指向队列尾元素的下一个空白位置
}SqQueue;

//初始化循环队列
Status InitQueue(SqQueue &q) {
	q.base = (QElemType *)malloc(MAXQSIZE * sizeof(QElemType));  //分配空间
	if (!q.base) return ERROR;
	//初始化队头、队尾
	q.front = 0;
	q.rear = 0;
	return OK;
}
//入队（元素值e入队，如果队列已满无法入队就返回ERROR，执行成功返回OK）
Status EnQueue(SqQueue &q, QElemType e){
	if ((q.rear + 1) % MAXQSIZE == q.front)
		return ERROR;
	q.base[q.rear] = e;
	q.rear = (q.rear + 1) % MAXQSIZE;
	return OK;

}
//依次打印输出队列元素（执行成功返回OK，否则返回ERROR）
Status PrintQueue(SqQueue q) {
	int i = q.front;
	while ((i + q.front) != q.rear)
	{
		printf("%d  ", q.base[i]);
		i = (i + 1) % MAXQSIZE;
	}
	return OK;
}

int main()
{
	int m, n;
	cout << "请输入需要产生的四则运算题个数:" << endl;
	cin >> n;
	srand((unsigned)time(NULL));
	do
	{
		cout << "2项式运算请输入“2”，3项式运算请输入“3”" << endl;
		cin >> m;
		cout << "........随机生成题目中........" << endl;
		Sleep(1000);
		cout << "..........Loading.............." << endl;
		Sleep(1000);
		switch (m)
		{
		case 2: Tot(n);
		case 3: cout << "阿偶！程序出错了!菜鸡程序员还未开发出此版块...\n..........请等待后续.........\n";
			break;
		default:
			cout << "\n\n您的输入有误，请重新输入字符：\n" << endl;
		}
	} while (m);

	//Tot(n);
	system("pause");
	return 0;
}
void Tot(int n)
{

	SqQueue Q;
	QElemType e;
	InitQueue(Q);
	int i, x, y, s, m;
	for (i = 0; i < n; i++)
	{
		s = rand() % 4 + 1;
		if (s == 1)
		{
			x = rand() % 100 + 1;
			y = rand() % 100 + 1;
			e = x + y;
			EnQueue(Q, e);
			cout << x << "+" << y << "=\n";
		}
		else	if (s == 2)
		{
			x = rand() % 100 + 1;
			y = rand() % 100 + 1;
			e = x - y;
			EnQueue(Q, e);
			cout << x << "-" << y << "=\n";
		}
		else	if (s == 3)
		{
			x = rand() % 100 + 1;
			y = rand() % 100 + 1;
			e = x*y;
			EnQueue(Q, e);
			cout << x << "×" << y << "=\n";
		}
		else	if (s == 4)
		{
			x = rand() % 100 + 1;
			y = rand() % 100 + 1;
			if (x > y)
			{
				if (x%y == 0)
				{
					e = x / y;
					EnQueue(Q, e);
					cout << x << "÷" << y << "=\n";
				}
				else
				{
					i--;
				}
			}
			else if (x <= y)
			{
				if (y%x == 0)
				{
					e = x / y;
					EnQueue(Q, e);
					cout << y << "÷" << x << "=\n";
				}
				else
				{
					i--;
				}
			}
		}

	}
	cout << "显示答案请输入“1”" << endl;
	do{
		cin >> m;
		switch (m)
		{
		case 1:
			PrintQueue(Q);
			break;
		default:
			cout << "\n你的输入有错误";
		}
	} while (m);
	ofstream outfile;
	outfile.open("subject.txt");
	cout << PrintQueue(Q) << endl;
	outfile.close();


}
/*void Toto(int n)
{

SqQueue Q;
QElemType e;
InitQueue(Q);
int i, x, y, s, m, z,u;
for (i = 0; i < n; i++)
{
s = rand() % 4 + 1;
if (s == 1)
{
x = rand() % 100 + 1;
y = rand() % 100 + 1;
u = rand() % 100 + 1;
e = x + y;
EnQueue(Q, e);
cout << x << "+" << y << "=\n";
}
else	if (s == 2)
{
x = rand() % 100 + 1;
y = rand() % 100 + 1;
u = rand() % 100 + 1;
e = x - y;
EnQueue(Q, e);
cout << x << "-" << y << "=\n";
}
else	if (s == 3)
{
x = rand() % 100 + 1;
y = rand() % 100 + 1;
u = rand() % 100 + 1;
e = x*y;
EnQueue(Q, e);
cout << x << "×" << y << "=\n";
}
else	if (s == 4)
{
x = rand() % 100 + 1;
y = rand() % 100 + 1;
u = rand() % 100 + 1;
if (x > y)
{
if (x%y == 0)
{
e = x / y;
EnQueue(Q, e);
cout << x << "÷" << y << "=\n";
}
else
{
i--;
}
}
else if (x <= y)
{
if (y%x == 0)
{
e = x / y;
EnQueue(Q, e);
cout << y << "÷" << x << "=\n";
}
else
{
i--;
}
}
}

}
cout << "显示答案请输入“1”" << endl;
do{
cin >> m;
switch (m)
{
case 1:
PrintQueue(Q);
break;
default:
cout << "\n你的输入有错误";
}
} while (m);
system("pause");
}
*/