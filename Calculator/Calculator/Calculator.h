
#ifndef CALCULATOR_H_
#define CALCULATOR_H_
#include "pch.h"
class Calculator {
public:
	Calculator() {};
	void calculator();//����������Ŀ����
	void showQuestions();//����Ŀ������ʾ����Ļ��
	void showResult();//����Ŀ�����ʾ����Ļ��
	bool Is_int(float a);//�жϽ���Ƿ�Ϊ����
private:
	int Quenumbers;
	float answers[100];
};
#endif

#pragma once
