#include "pch.h"
#include <iostream>
#include<stdlib.h>


using namespace std;


//定义记录每道算术题字符串形式及参与运算的数值的结构体
typedef struct question
{
	
	int a[5];
	char b[2];//用于记录运算符
	char c[4];//运算符库
	int d;//d为结果
	
}sums;


//随机生成5个数值,3个用于参与运算，2个用于生成运算符，均存于数组a中
int product(sums &L)
{
	int i;
	for (i = 0; i < 3; i++)
	{
		L.a[i] = rand() % 100 + 1;
	}
	for (; i < 5; i++)
	{
		L.a[i] = rand() % 3 + 0;
	}
	
	
	return 0;
}
//利用L.a数组最后两个数值生成运算符
int Operator(sums &L)
{
	
	L.b[0] = L.c[L.a[3]];//随机生成运算符并存储于L.b
	L.b[1] = L.c[L.a[4]];
	return 0;

}
//初始化结构体SUMS

int initList(sums &L)
{
	int i;
	
	for (i = 0; i < 6; i++)
	{
		L.a[i] = 0;
	}
	for (i = 0; i < 2; i++)
	{
		L.b[i] = 0;
	}
	L.d = 0;
	L.c[0]= '+';
	L.c[1]= '-';
	L.c[2]='*';
	L.c[3]= '/';
	return 1;
}


//判别运算式子是否符合要求，并运算
int Tell(sums &rl,int sum)
{
	int e;
	float g, h, f;
	
		if (rl.b[0] == '/' || rl.b[1] == '/')
		{
			if (rl.b[0] == '/')
			{
				e = rl.a[0] / rl.a[1];
				g = rl.a[0];
				h = rl.a[1];
				f = g / h;
				if (e != f)
				{
					return 0;

				}
			}
			else
			{
				e = rl.a[1] / rl.a[2];
				g = rl.a[1];
				h = rl.a[2];
				f = g / h;
				if (e != f)
				{
					return 0;

				}
			}
		}
		else
		{
			if (rl.a[3] == 0 && rl.a[4] == 0)
				rl.d = rl.a[0] + rl.a[1] + rl.a[2];
			else
				if (rl.a[3] == 0 && rl.a[4] == 1)
					rl.d = rl.a[0] + rl.a[1] - rl.a[2];
				else
					if (rl.a[3] == 0 && rl.a[4] == 2)
						rl.d = rl.a[0] + rl.a[1] * rl.a[2];
					else
						if (rl.a[3] == 0 && rl.a[4] == 3)
							rl.d = rl.a[0] + rl.a[1] / rl.a[2];
						else
							if (rl.a[3] == 1 && rl.a[4] == 0)
								rl.d = rl.a[0] - rl.a[1] + rl.a[2];
							else
								if (rl.a[3] == 1 && rl.a[4] == 1)
									rl.d = rl.a[0] - rl.a[1] - rl.a[2];
								else
									if (rl.a[3] == 1 && rl.a[4] == 2)
										rl.d = rl.a[0] - rl.a[1] * rl.a[2];
									else
										if (rl.a[3] == 1 && rl.a[4] == 3)
											rl.d = rl.a[0] - rl.a[1] / rl.a[2];
										else
											if (rl.a[3] == 2 && rl.a[4] == 0)
												rl.d = rl.a[0] * rl.a[1] + rl.a[2];
											else
												if (rl.a[3] == 2 && rl.a[4] == 1)
													rl.d = rl.a[0] * rl.a[1] - rl.a[2];
												else
													if (rl.a[3] == 2 && rl.a[4] == 2)
														rl.d = rl.a[0] * rl.a[1] * rl.a[2];
													else
														if (rl.a[3] == 2 && rl.a[4] == 3)
															rl.d = rl.a[0] * rl.a[1] / rl.a[2];
														else
															if (rl.a[3] == 3 && rl.a[4] == 0)
																rl.d = rl.a[0] / rl.a[1] + rl.a[2];
															else
																if (rl.a[3] == 3 && rl.a[4] == 1)
																	rl.d = rl.a[0] / rl.a[1] - rl.a[2];
																else
																	if (rl.a[3] == 3 && rl.a[4] == 2)
																		rl.d = rl.a[0] / rl.a[1] * rl.a[2];
																	else
																		if (rl.a[3] == 3 && rl.a[4] == 3)
																			rl.d = rl.a[0] / rl.a[1] / rl.a[2];
			return 1;

		}
		return 0;
		
}




int main()
{
	sums rl;

	FILE *wf;
	errno_t w;
	int i;
	int sum;

	w = fopen_s(&wf, "subject.txt", "w");
	
	if (initList(rl) == 1)
		cout << "请稍等" << endl;

	cout << "请输入需要的算术题总数：" << endl;
	cin >> sum;

	cout << "*此程序用于算术题的自动生成*" << endl;
	for (i = 0; i < sum; i++)
	{
		product(rl);
			cout << "正在生成第" << i+1 << "个运算式" << endl;
		Operator(rl);//生成运算符并存储于rl.b
		if (Tell(rl, sum) == 0)//调用函数Tell对整体式子进行判断是否符合要求，符合则进一步运算出结果
		{
			i--;
		}
		else
		{
			

			

			
			
			fprintf(wf, "%d ", rl.a[0]);
			fprintf(wf, "%c ", rl.b[0]);
			fprintf(wf, "%d ", rl.a[1]);
			fprintf(wf, "%c ", rl.b[1]);
			fprintf(wf, "%d", rl.a[2]);
			fprintf(wf, "=");
			fprintf(wf, "%d", rl.d);
			fprintf(wf, "\n");


			cout << "写入完毕" << endl;
			initList(rl);
			
		}

	}
	fclose(wf);
	
}


