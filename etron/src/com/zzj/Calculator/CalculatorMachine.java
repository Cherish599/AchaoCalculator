package com.zzj.Calculator;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.util.HashSet;
import java.util.Random;
import java.util.Stack;

/**
 * 此为得到计算题目的机器
 * 含有一个方法，传入一个数
 * 利用后续表达式得到结果
 * 即可得到含有题目的subject.txt文件
 */
public class CalculatorMachine {

    /**
     * 用于存储生成的题目，使用Set集合数据结构使得题目不会产生重复
     */
    private  HashSet<String> problem = new HashSet<>();

    /**
     * 用于存储数字的栈
     */
    private Stack<Integer> numbers = new Stack<>();

    /**
     * 用于存储符号的栈
     */
    private Stack<Integer> operators = new Stack<>();


    /**
     * 用与生成随机数
     * random.nextInt(20) :即可得到20以内不包含20的随机数
     */
    private Random random = new Random();

    /**
     * 传入num题目数目
     * 即可将题目写入到subject.txt文件中
     * @param num 代表需要的题目数量
     * @return  没有任何问题，即返回true代表生成成功
     */
    public void getAll(int num){
        // 循环得到式子直到满足数目
        while(problem.size() < num) {
            getOne();
        }
        if(writeToFile()) {
            System.out.println("已经根据你的要求生成" + num + "个式子！");
        }
    }

    /**
     * 用于生成一个符合要求的算式
     * 使用后续表达式得到结果
     */
    public void getOne() {

        // 用来保存生成的当前式子
        String result = "";

        // 运算符的个数为 2 或者 3 个
        int operator_count = random.nextInt(2)+2;

        //数字的个数,根据题意，两个符号，则代表3个计算数，三个符号，则代表4个计算数
        int num_count = operator_count == 2 ? 3: 4;

        // 根据后续表达式就搞定了两个栈的东西 61+47*96=4573
        for(int i = 0; i < operator_count + num_count ; i++) {
            // 如果是偶数，则代表着数数字
            if(i%2==0) {
                // 在数字栈中存入一个范围内的随机数
                numbers.push(random.nextInt(101));
                // 进行符号保存
                result += numbers.peek();
                // 如果是奇数，则代表着符号位
            } else if(i%2!=0) {
                // 1:+ , 2:- , 3:* 4:/
                int opertor = random.nextInt(4) + 1;
                // 如果遇到+ - 准备入栈顶为 * /的话，需要进行计算
                while(!operators.empty() && opertor <=2 && operators.peek() >=3) {
                    result = calculateUtil(result);
                }
                // 这个符号符合当前栈的规则，则入栈
                operators.push(opertor);
                // 记录这个符号
                if(operators.peek()==1) {
                    result += '+';
                } else if(operators.peek() == 2){
                    result += '-';
                } else if(operators.peek() == 3){
                    result += '*';
                } else if(operators.peek() == 4){
                    result += '÷';
                }
            }
        }

        // 根据剩余的栈计算最后的值
        while(!operators.empty()) {
            result = calculateUtil(result);
        }
        // 如果最后的计算结果为负数，直接返回，放弃此次的式子
        if(numbers.peek()<0){
            return;
        }
        // 最后加上等于符号
        result += '=';
        // 走到这一步，说明这个式子没有问题，符合题意
        // 所以放入到set集合中
        problem.add(result+=numbers.pop());
    }

    /**
     * 根据符号计算
     */
    private int calculator(int a, int b, int operator) throws  CantCalculateException {

        if(operator == 1) {
            return a+b;
        } else if(operator == 2) {
            return a-b;
        }  else if(operator == 3) {
            return a*b;
        } else if(operator == 4) {
            // 如果不能整除，则抛出我们自定义的Exception
            if(a<b || a%b != 0 || b == 0) {
                throw new CantCalculateException();
            }
            return a/b;
        }
        return 0;
    }

    /**
     * 进行后续表达式特殊计算
     * + - 入栈顶为 * / 的情况
     * 除法带有分数的情况
     * @param result
     * @return
     */
    private String calculateUtil(String result){

        int a = numbers.pop();
        int b = numbers.pop();

        try {
            int this_operator = operators.pop();
            if(!operators.isEmpty() && this_operator==2 && operators.peek()==2) {
                numbers.push(calculator(b,a,1));
            }else if (!operators.isEmpty() && this_operator==4 && operators.peek()==4) {
                numbers.push(calculator(b,a,3));
            }
            else {
                numbers.push(calculator(b,a,this_operator));
            }
        } catch (CantCalculateException e) {
            int pr_b = b;
            a = random.nextInt(101);
            b = random.nextInt(101);
            // a除数不能为0，满足b能够整除a,满足b>a
            while (a == 0 || b % a != 0 || b < a || b > 100) {
                a = random.nextInt(101);
                b = random.nextInt(101) + a;
            }
            numbers.push(b);
            numbers.push(a);
            operators.push(4);
            result = result.substring(0, result.indexOf(pr_b + ""));
            result += b;
            result += '÷';
            result += a;
        }
        return result;
    }

    /**
     * 将生成的所有式子写入到subject.txt
     * @return
     */
    private boolean writeToFile()  {
        File file = new File("subject.txt");
        try{
            if(!file.exists()) {
                file.createNewFile();
            }
            FileWriter fileWriter = new FileWriter(file.getAbsoluteFile());
            BufferedWriter bufferedWriter = new BufferedWriter(fileWriter);
            for(String s : problem) {
                bufferedWriter.write(s);
                bufferedWriter.newLine();
            }
            bufferedWriter.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
        return true;
    }
}
