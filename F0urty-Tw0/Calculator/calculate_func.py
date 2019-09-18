# -*- coding: UTF-8 -*-
nums = "0123456789"
optrs = "+-*/="


def isoperator(expression, index):
    if nums.find(expression[index - 1]) != -1 and optrs.find(expression[index]) != -1:
        return True
    return False


def gen_list(expression):  # 将输入的字符串表达式转换为列表
    units = []  # 保存包含操作符和操作数的列表
    start = 0  # 标记数字起点
    expression = (expression if expression[len(expression) - 1] == "=" else expression + "=")
    for i in range(len(expression)):
        if isoperator(expression, i):
            units.append(float(expression[start:i]))
            units.append(expression[i])
            start = i + 1
    return units


def calculate(expression, isFirst=True):
    i = 0
    while i < len(expression) - 3:
        a = expression[i]  # 获取操作数1
        b = expression[i + 2]  # 获取操作数2
        op1 = expression[i + 1]  # 获取运算符
        result = None

        if op1 == "*":
            result = a * b
        elif op1 == "/":
            result = a / b
        elif not isFirst and op1 == "+":
            result = a + b
        elif not isFirst and op1 == "-":
            result = a - b

        if result is not None:
            expression[i] = result  # 将第一个操作数替换问运算结果
            del (expression[i + 1: i + 3])  # 删除运算符号和后一个操作数
        else:
            i += 2  # 下标偏移

    if isFirst:
        return calculate(expression, False)
    elif int(expression[0]) == expression[0]:
        return int(expression[0])  # 返回结果
