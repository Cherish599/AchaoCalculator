# -*- coding: UTF-8 -*-
import random
from calculate_func import gen_list, calculate


def random_num(num_n):  # 生成并返回num_n个随机的数值列表
    num_list = []
    for i in range(0, num_n):
        num = random.randint(1, 100)
        num_list.append(num)
    return num_list


def new_form():  # 生成新的表达式
    op = ["+", "-", "*", "/"]
    r = random.randint(2, 3)
    if r == 2:  # 通过判断随机生成的r来确定表达式中运算符数量
        num = random_num(10)
        formula_list = []
        for i in range(0, 3):
            tmp = random.choice(num)
            formula_list.append(tmp)
        for i in [1, 3]:
            tmp = random.choice(op)
            formula_list.insert(i, tmp)
    elif r == 3:
        num1 = random_num(10)
        formula_list = []
        for i in range(0, 4):
            tmp = random.choice(num1)
            formula_list.append(tmp)
        for i in [1, 3, 5]:
            tmp = random.choice(op)
            formula_list.insert(i, tmp)
    return formula_list


def save_to_file(file_name, contents):  # 将表达式保存在一个txt文件中
    txt_file = open(file_name, 'a')
    txt_file.write(contents)
    txt_file.write('\n')
    txt_file.close()


def form_display(form_list):  # 将生成的表达式打印
    expression = "".join(str(i) for i in form_list)
    expression1 = gen_list(expression)
    result = calculate(expression1, isFirst=True)
    if result:  # 若通过calculate()函数计算表达式结果为整数，则进行后续的打印输出
        op_dict = {"+": "+", "-": "-", "*": "×", "/": "÷"}
        op = ["+", "-", "*", "/"]
        length = len(form_list)
        for i in range(length):
            if form_list[i] in op:
                form_list[i] = op_dict[form_list[i]]  # 通过op_dict字典将原有表达式中的乘除运算符替换为"X"与"÷"
        form_list.append("=")
        form_list = "".join(str(i) for i in form_list)  # 将form_list列表中的元素拼接为字符串输出
        print (form_list)
        #form_list.append(result)
        #form_list = "".join(str(i) for i in form_list)  # 将form_list列表中的元素拼接为字符串输出
        save_to_file('subject.txt', form_list+str(result))

    else:  # 若表达式计算结果不为整数则不打印任何数据
        form_list = new_form()
        form_display(form_list)


def main():
    n = input("请输入要出的计算题数量：")
    for i in range(0, n):
        form_list = new_form()
        form_display(form_list)


main()