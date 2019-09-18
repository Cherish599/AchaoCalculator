using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator {
    public class Compute {
        private Stack<char> opStack;
        private Stack<double> num;
        private StringBuilder input;
        private char[] post;//后缀表达式
        private int z = 0;

        public Compute(StringBuilder sb) {
            opStack = new Stack<char>();
            post = new char[200];
            input = sb;
        }

        public Compute() {

        }

        //中缀表达式转后缀表达式
        public void DoTrans() {
            for (int i = 0; i < input.Length; i++) {
                if(input[i] >= '0' && input[i] <= '9') {
                    while(input[i] >= '0' && input[i] <= '9') {
                        post[z++] = input[i++];
                        if (i == input.Length) {
                            break;
                        }
                    }
                    post[z++] = '#';
                    i--;
                }else if (input[i]=='+' || input[i]=='-') {
                    OperationOpStack(input[i], 1);
                } else if (input[i] == '*' || input[i] == '/') {
                    OperationOpStack(input[i], 2);
                }
            }
            while (opStack.Count != 0) {
                post[z++] = opStack.Pop();
            }
        }

        //运算符栈操作
        public void OperationOpStack(char opThis, int prec1) {
            while (opStack.Count != 0) {
                char opTop = opStack.Pop();
                int prec2;
                if (opTop == '+' || opTop == '-') {
                    prec2 = 1;
                } else {
                    prec2 = 2;
                }
                //比较优先级
                if (prec2 < prec1) {
                    opStack.Push(opTop);
                    break;
                } else {
                    post[z++] = opTop;
                }
            }
            opStack.Push(opThis);
        }

        //后缀表达式求值
        public double Calculate() {
            num=new Stack<double>();//操作数堆栈
            double a = 0, b = 0;
            for(int i = 0;i<z;i++) {
                if (post[i] >= '0' && post[i] <= '9') {
                    int tmp = 0;
                    while (post[i] >= '0' && post[i] <= '9') {
                        tmp = tmp * 10 + Convert.ToInt32(post[i] - '0');
                        i++;
                    }
                    num.Push(tmp);
                }else if (post[i] == '#') {
                    continue;
                } else {
                    a = num.Pop();
                    b = num.Pop();
                    num.Push(Operate(b, a, post[i]));
                }
            }
            return num.Pop();//最后的结果为栈顶元素
        }

        //计算结果
        public double Operate(double first, double second, char op) {
            double res = 0;
            switch (op) {
                case '+':
                    res = first + second;
                    break;
                case '-':
                    res = first - second;
                    break;
                case '*':
                    res = first * second;
                    break;
                case '/':
                    res = first / second;
                    break;
                default:
                    break;
            }
            return res;
        }

    }
}
