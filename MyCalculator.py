#导入随机数模块可以生成随机数
import random
def CreatNew():
    Number=int(random.randint(1,100))
    return Number

def GetAnswer():
#生成三个一百以内的随机数
    num1 = int(random.randint(1, 100))
    num2 = int(random.randint(1, 100))
    num3 = int(random.randint(1, 100))
#在这里面写好符号
    operater1 = ['+', '-']
    operater2 = ['×', '÷']
#设置i来控制加减，j来控制乘除
    i = random.randint(0, 1)
    j = random.randint(0, 1)
#下面来控制 除数为整数的条件
    while j == 1:#做除法的时候
        if num2 % num3 == 0:
            break
        else:
            num3=CreatNew()
    # 打开所希望写入的文件
    f = open("计算题.txt", 'a')
    #先＋后÷的情况下
    if i == 0 and j == 1:
        answer = num1 + num2 / num3
        print("{0}{1}{2}{3}{4}={5}".format(num1, operater1[i], num2, operater2[j], num3, answer), file=f)
        # 关闭文件防止文件数据丢失
        f.close()
    elif i == 0 and j == 0:
        answer = num1 + num2 *num3
        print("{0}{1}{2}{3}{4}={5}".format(num1, operater1[i], num2, operater2[j], num3, answer), file=f)
        # 关闭文件防止文件数据丢失
        f.close()
    elif i == 1 and j == 0:
        answer = num1 - num2 * num3
        print("{0}{1}{2}{3}{4}={5}".format(num1, operater1[i], num2, operater2[j], num3, answer), file=f)
        # 关闭文件防止文件数据丢失
        f.close()
    else:
        answer = num1 - num2 / num3
        print("{0}{1}{2}{3}{4}={5}".format(num1, operater1[i], num2, operater2[j], num3, answer), file=f)
        # 关闭文件防止文件数据丢失
        f.close()

n = int(input("请输入你想生成的题目"))
for i in range(0, n):
    GetAnswer()




