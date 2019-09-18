import random


def answer1():
    # 在先加后除的情况中来得出答案
    num1 = random.randint(1, 100)
    num2 = random.randint(1, 100)
    num3 = random.randint(1, 100)
    answer = num1 + num2 // num3
    return answer


def answer2():
    # 在先加后乘的情况中来得出答案
    num1 = random.randint(1, 100)
    num2 = random.randint(1, 100)
    num3 = random.randint(1, 100)
    answer = num1 + num2 * num3
    return answer


def answer3():
    # 在先减后乘的情况中来得出答案
    num1 = random.randint(1, 100)
    num2 = random.randint(1, 100)
    num3 = random.randint(1, 100)
    answer = num1 - num2 * num3
    return answer


def answer4():
    # 在先减后除的情况中来得出答案
    num1 = random.randint(1, 100)
    num2 = random.randint(1, 100)
    num3 = random.randint(1, 100)
    answer = num1 - num2 // num3
    return answer


def GetAnswer():
    num1 = random.randint(1, 100)
    num2 = random.randint(1, 100)
    num3 = random.randint(1, 100)

    operater1 = ['+', '-']
    operater2 = ['×', '÷']
    i = random.randint(0, 1)
    j = random.randint(0, 1)
    n = 21
    m = 1

    while j == 1:
        if num2 % n == 0:
            num3 = n
            break
        else:
            n -= 1
        m += 1
        if m >= 97:
            num3 = num2
            break

    # 打开所希望写入的文件
    f = open("计算题.txt", 'a')
    if i == 0 and j == 1:
        answer = num1 + num2 // num3
        while answer <= 0:
            answer = answer1()
        print("{0}{1}{2}{3}{4}={5}".format(num1, operater1[i], num2, operater2[j], num3, answer), file=f)
        # 关闭文件防止文件数据丢失
        f.close()
    elif i == 0 and j == 0:
        answer = num1 - num2 // num3
        while answer <= 0:
            answer = answer2()
        print("{0}{1}{2}{3}{4}={5}".format(num1, operater1[i], num2, operater2[j], num3, answer), file=f)
        # 关闭文件防止文件数据丢失
        f.close()
    elif i == 1 and j == 0:
        answer = num1 - num2 * num3
        while answer <= 0:
            answer = answer3()
        print("{0}{1}{2}{3}{4}={5}".format(num1, operater1[i], num2, operater2[j], num3, answer), file=f)
        # 关闭文件防止文件数据丢失
        f.close()
    else:
        answer = num1 - num2 // num3
        while answer <= 0:
            answer = answer4()
        print("{0}{1}{2}{3}{4}={5}".format(num1, operater1[i], num2, operater2[j], num3, answer), file=f)
        # 关闭文件防止文件数据丢失
        f.close()


# 主函数
n = int(input("请输入你想生成的题目"))
for i in range(0, n):
    GetAnswer()




