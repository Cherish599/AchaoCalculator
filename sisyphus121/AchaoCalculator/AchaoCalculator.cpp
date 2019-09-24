#include <iostream>
#include <ctime>
#include <fstream>

using namespace std;

int getrandnum();//获取1-100的随机数字
char getrandsignal();//随机获取四个运算符
bool judgeint(int, int[], char[]);//判断结果是否为整数
void filein(int, int[], char[]);//将算式写入到文本文档中
void display(int, int[], char[]);//屏幕输出算式
int main()
{
	int n;
	int m, i, j;
	int num[5];
	char sign[5];
	fstream file("subject.txt", ios::out);//清空subject文档
	cout << "请输入要产生的题目数量： ";
	cin >> n;
	cout << "题目：" << endl;
	srand(time(0));//获取随机数

	while (n != 0) {//算式生成
		m = rand() % 4 + 2;
		for (i = 0; i < m; i++) {
			num[i] = getrandnum();
		}
		for (i = 0; i < m - 1; i++) {
			sign[i] = getrandsignal();
		}
		if (judgeint(m, num, sign))
		{
			n--;
			display(m, num, sign);
			filein(m, num, sign);
		}
	}
}

//获取1-100的随机数字
int getrandnum() {
	return rand() % 100 + 1;
}

//随机获取四个运算符
char getrandsignal() {
	char signal[4] = { '+','-','*','/' };
	int q;
	q = rand() % 4;
	return signal[q];
}

//判断结果是否为整数
bool judgeint(int k, int num[5], char sign[5]) {
	int c1 = 0;
	for (int j = 0; j < k - 1; j++) {
		if (sign[j] == '/')
			c1 = num[j] % num[j + 1];
	}
	if (c1 != 0)
		return false;
	else
		return true;
}

//将算式写入到文本文档中
void filein(int k, int num[5], char sign[5]) {
	ofstream questions("subject.txt", ios::app);
	if (questions.is_open()) {
		for (int i = 0; i < k - 1; i++) {
			questions << num[i] << sign[i];
		}
		questions << num[k - 1];
		questions << " =\n";
		questions.close();
	}
}

//屏幕输出算式
void display(int k, int num[5], char sign[5]) {

	for (int i = 0; i < k - 1; i++) {
		cout << num[i] << sign[i];
	}
	cout << num[k - 1];
	cout << '=' << endl;
}
