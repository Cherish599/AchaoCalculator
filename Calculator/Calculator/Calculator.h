
#ifndef CALCULATOR_H_
#define CALCULATOR_H_
#include "pch.h"
class Calculator {
public:
	Calculator() {};
	void calculator();//设置输入题目数量
	void showQuestions();//将题目内容显示在屏幕中
	void showResult();//将题目结果显示在屏幕上
	bool Is_int(float a);//判断结果是否为整数
private:
	int Quenumbers;
	float answers[100];
};
#endif

#pragma once
