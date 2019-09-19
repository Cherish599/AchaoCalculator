#include"pch.h"
#include<vector>
#include<string>
#include<iostream>
#include<cstdlib>
#include<stack> //栈
#include<ctime>
#include"Calculator.h"

#define random(a, b) (rand()%(b-a+1)+a)
using namespace std;

string Calculator::FH(char formulaChar)
{
	char a[4] = { '+', '-', '*', '/' };
	int i = 0;
	for (i = 0; i < 4; i++)
		if (a[i] == formulaChar)
			break;
	return op[i];
}

string Calculator::MakeFormula() {//创建公式
	string formula = ""; //表面出现的公式

	int count = random(1, 3); //公式长度添加  1or2 ;
	int start = 0;//开始计数
	int number1 = random(1, 100);//第一个数字
	formula += to_string(number1);
	int temp = number1;//保存被除数
	while (start <= count) {
		int operation = random(0, 3);//符号
		int number2 = random(1, 100);//第二个数字
		if (op[operation] == "/") { 	//排除小数
			float f = static_cast<float>(temp) / static_cast<float>(number2);
			int a = (temp / number2);
			if (f != (temp / number2))
				return MakeFormula();
		}
		formula += op[operation] + to_string(number2);//符号+数字
		temp = number2;
		start++;
	}
	return formula;
}

string Calculator::Solve(string formula) { // 解决公式：方法：将公式转换为后缀式再求解
	vector<string> *hz = new vector<string>(); //存放后缀表达式
	stack<string> *fh = new stack<string>(); //存放符号
	int start = 0, len = 0;//start 开始， len当前下标
	for (auto formulaChar : formula) {
		if (formulaChar == '+' || formulaChar == '-' || formulaChar == '*' || formulaChar == '/')
		{
			hz->push_back(formula.substr(start, len - start));//处理数字
			start = len + 1;
			if (fh->empty())//处理符号
				fh->push(FH(formulaChar));
			else {
				if ((fh->top() == "+" || fh->top() == "-") && (formulaChar == '*' || formulaChar == '/'))
					fh->push(FH(formulaChar)); //ok
				else
				{
					if (formulaChar == '+' || formulaChar == '-') {
						while (!fh->empty())
						{
							hz->push_back(fh->top());
							fh->pop();
						}
						fh->push(FH(formulaChar));
					}
					else {
						hz->push_back(FH(formulaChar));
					}
				}
			}
		}
		len++;
	}
	hz->push_back(formula.substr(start));//处理最后的数字
	while (!fh->empty())//处理最后的符号
	{
		hz->push_back(fh->top());
		fh->pop();
	}
	//将后缀表达式求解
	stack<int> result;
	int a1, a2;
	for (auto j : *hz)
	{
		if (j == "+" || j == "-" || j == "*" || j == "/")
		{
			if (j == "+")
			{
				a1 = result.top();
				result.pop();
				a2 = result.top();
				result.pop();
				result.push((a1 + a2));
			}
			if (j == "-")
			{
				a1 = result.top();
				result.pop();
				a2 = result.top();
				result.pop();
				result.push((a2 - a1));
			}
			if (j == "*")
			{
				a1 = result.top();
				result.pop();
				a2 = result.top();
				result.pop();
				result.push((a1 * a2));
			}
			if (j == "/")
			{
				a1 = result.top();
				result.pop();
				a2 = result.top();
				result.pop();
				result.push((a2 / a1));
			}
		}
		else
			result.push(atoi(j.c_str()));
	}
	return formula + "=" + to_string(result.top());
}

int main() {
	int n;
	Calculator *calc = new Calculator();
	string Problem;
	srand((unsigned int)time(0));
	cout << "请输入你想要几道题？" << endl;
	cin >> n;
	for (int i = 0; i < n; i++) {
		Problem = calc->MakeFormula();
		cout << Problem << endl;
		cout << calc->Solve(Problem) << endl;
	}
	return 0;
}