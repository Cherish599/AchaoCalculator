package src.mysido;
import java.util.HashMap;
import java.util.Map;
import java.util.Stack;

public class solve {
    static Map<String, Integer> OPT_PRIORITY_MAP = new HashMap<String, Integer>() {
        private static final long serialVersionUID = 6968472606692771458L;
        {
            put("+", 2);
            put("-", 2);
            put("*", 3);
            put("/", 3);
            put("=", -1);
        }
    };
    public static int getPriority(String opt1, String opt2) {
        int priority = OPT_PRIORITY_MAP.get(opt2) - OPT_PRIORITY_MAP.get(opt1);
        return priority;
    }
    public static void compareAndCalc(Stack<String> optStack, Stack<Integer> numStack,
                                      String curOpt) {
        // 比较当前运算符和栈顶运算符的优先级
        String peekOpt = optStack.peek();
        int priority = getPriority(peekOpt, curOpt);
        if (priority == -1 || priority == 0) {
        // 栈顶运算符优先级大或同级，触发一次二元运算
            String opt = optStack.pop(); // 当前参与计算运算符
            int num2 = numStack.pop(); // 当前参与计算数值2
            int num1 = numStack.pop(); // 当前参与计算数值1
            int res = frealCalc(opt, num1, num2);
            numStack.push(res);
            // 运算完栈顶还有运算符，则还需要再次触发一次比较判断是否需要再次二元计算
            if (optStack.empty()) {
                optStack.push(curOpt);
            } else {
                compareAndCalc(optStack, numStack, curOpt);
            }
        } else {
            optStack.push(curOpt);
        }
    }


    static int Calcula(String exp) {

        StringBuilder curNumBuilder = new StringBuilder(16);
        Stack<String> optStack = new Stack<>(); // 运算符栈
        Stack<Integer> numStack = new Stack<>();
        for (int i = 0; i < exp.length(); i++) {
            char c = exp.charAt(i);
            if (c >= '0' && c <= '9') curNumBuilder.append(c);
            else {
                if (curNumBuilder.length() > 0) {// 如果追加器有值，说明之前读取的字符是数值，而且此时已经完整读取完一个数值
                    numStack.push(Integer.valueOf(curNumBuilder.toString()));
                    curNumBuilder.delete(0, curNumBuilder.length());
                }
                String curOpt = String.valueOf(c);
                if (optStack.empty()) {// 运算符栈栈顶为空则直接入栈
                    optStack.push(curOpt);
                } else {
                    if (curOpt.equals("=")) {
                        if(numStack.size()==1)return numStack.pop();
                        while (!optStack.empty()){
                            int s1=numStack.pop();
                            int s2=numStack.pop();
                            String p=optStack.pop();
                            int res=frealCalc(p,s2,s1);
                            numStack.push(res);
                        }
                        return numStack.pop();

                    } else {
                        compareAndCalc(optStack,numStack,curOpt);
                    }

                }


            }
        }
        return 0;
    }
    private static int frealCalc(String curOpt, int a, int b) {
        if(curOpt.equals("+"))return a+b;
        if(curOpt.equals("-"))return a-b;
        if(curOpt.equals("*"))return a*b;
        if(curOpt.equals("/"))return a/b;
        return 0;
    }
}
