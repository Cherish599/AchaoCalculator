#include<iostream>
#include<time.h>
#include<windows.h>
#include <fstream>
using namespace std;
void Tot(int n);
void Toto(int n);
typedef int Status;
typedef int QElemType;//�������Ԫ����������
typedef int QElemType; //����Ԫ�ص���������
#define TRUE 1
#define FALSE 0
#define OK 1
#define ERROR 0
#define MAXQSIZE 100 //ѭ�������������
//ѭ����������
typedef struct QNode{
	QElemType *base; //����Ԫ�ش洢����
	int front;       //��ͷָ�룬�����в��գ���ָ�����ͷԪ��
	int rear;        //��βָ�룬�����в��գ���ָ�����βԪ�ص���һ���հ�λ��
}SqQueue;

//��ʼ��ѭ������
Status InitQueue(SqQueue &q) {
	q.base = (QElemType *)malloc(MAXQSIZE * sizeof(QElemType));  //����ռ�
	if (!q.base) return ERROR;
	//��ʼ����ͷ����β
	q.front = 0;
	q.rear = 0;
	return OK;
}
//��ӣ�Ԫ��ֵe��ӣ�������������޷���Ӿͷ���ERROR��ִ�гɹ�����OK��
Status EnQueue(SqQueue &q, QElemType e){
	if ((q.rear + 1) % MAXQSIZE == q.front)
		return ERROR;
	q.base[q.rear] = e;
	q.rear = (q.rear + 1) % MAXQSIZE;
	return OK;

}
//���δ�ӡ�������Ԫ�أ�ִ�гɹ�����OK�����򷵻�ERROR��
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
	cout << "��������Ҫ�������������������:" << endl;
	cin >> n;
	srand((unsigned)time(NULL));
	do
	{
		cout << "2��ʽ���������롰2����3��ʽ���������롰3��" << endl;
		cin >> m;
		cout << "........���������Ŀ��........" << endl;
		Sleep(1000);
		cout << "..........Loading.............." << endl;
		Sleep(1000);
		switch (m)
		{
		case 2: Tot(n);
		case 3: cout << "��ż�����������!�˼�����Ա��δ�������˰��...\n..........��ȴ�����.........\n";
			break;
		default:
			cout << "\n\n�����������������������ַ���\n" << endl;
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
			cout << x << "��" << y << "=\n";
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
					cout << x << "��" << y << "=\n";
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
					cout << y << "��" << x << "=\n";
				}
				else
				{
					i--;
				}
			}
		}

	}
	cout << "��ʾ�������롰1��" << endl;
	do{
		cin >> m;
		switch (m)
		{
		case 1:
			PrintQueue(Q);
			break;
		default:
			cout << "\n��������д���";
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
cout << x << "��" << y << "=\n";
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
cout << x << "��" << y << "=\n";
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
cout << y << "��" << x << "=\n";
}
else
{
i--;
}
}
}

}
cout << "��ʾ�������롰1��" << endl;
do{
cin >> m;
switch (m)
{
case 1:
PrintQueue(Q);
break;
default:
cout << "\n��������д���";
}
} while (m);
system("pause");
}
*/