#include <iostream>
#include <string>
#include <ctime>
#include <stack>
#include <fstream>
#include <cstdlib>
#include "Calculator.h"

#define random(a,b) (rand()%(b-a+1)+a)
using namespace std;
//设置优先级
int Prec(char op) {
	if (op == '+' || op == '-')
		return 1;
	else if (op == '*' || op == '/')
		return 2;
	else if (op == '=')
		return 0;
	else
		return -1;
}
//默认构造函数
Calculator::Calculator() {}
//生成题目
string Calculator::MakeQuestion() {
	string question = "";
	int number1 = random(1, 100);
	int op_num = random(1, 3);    //随机产生操作符个数
	question += to_string(number1);
	for (int i = 0; i < op_num; i++) {
		int op_index = random(0, 3);    //操作符下标
		int number2 = random(1, 100);
		if (op_index == 3) {
			while (number1 < number2 || number1 % number2 != 0) {
				number2 = random(1, 50);    //不能整除则重新生成随机数
			}
		}
		number1 = number2;
		question += op[op_index] + to_string(number1);
	}
	question += "=";
	return question;
}
//计算结果
int Calculator::Solve(string question) {
	stack<int> num_stack;    //保存运算数据的栈
	stack<char> op_stack;    //保存操作符的栈
	int i = 0;
	while (i < question.length()) {
		char temp = question[i];
		if (temp != '+'&&temp != '-'&&temp != '*'&&temp != '/'&&temp != '=') {
			int number = stoi(question.substr(i));    //取出完整运算数据
			num_stack.push(number);                   //运算数据直接入栈
			i += to_string(number).length();
		}
		else {
			if (op_stack.empty())
				op_stack.push(temp);
			else if (Prec(temp) > Prec(op_stack.top()))
				op_stack.push(temp);    //栈外操作符优先级大于栈顶
			else {                      //栈外操作符优先级小于或等于栈顶
				while (!op_stack.empty()) {
					char op = op_stack.top();
					int num2 = num_stack.top();
					num_stack.pop();
					int num1 = num_stack.top();
					num_stack.pop();
					if (op == '+')
						num_stack.push(num1 + num2);
					else if (op == '-')
						num_stack.push(num1 - num2);
					else if (op == '*')
						num_stack.push(num1 * num2);
					else if (op == '/')
						num_stack.push(num1 / num2);
					op_stack.pop();
				}
				op_stack.push(temp);
			}
			i++;
		}
	}
	return num_stack.top();
}

int main() {
	srand((unsigned)time(NULL));
	ofstream ofile;
	ofile.open("Calculator.txt");
	if (!ofile.is_open()) {
		cout << "文件打开失败！" << endl;
		exit(1);
	}
	Calculator Calculator;
	string question;
	int question_num;
	cout << "请输入题目数量:";
	cin >> question_num;
	for (int i = 0; i < question_num; i++) {
		do {
			question = Calculator.MakeQuestion();
		} while (Calculator.Solve(question) < 0);
		cout << question << endl;
		ofile << question << Calculator.Solve(question) << endl;
	}
	ofile.close();
	return 0;
}