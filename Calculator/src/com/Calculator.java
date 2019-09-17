package com;

import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.Stack;


public class Calculator {
    public  List createFormula(){
        randomNum a=new randomNum();
        List<Object> formula=new ArrayList<>();
        for(int i=0;i<a.createLen();i++){
            int num=a.createNum();
            String op=a.createRuler();
            formula.add(num);
            formula.add(op);
        }
        formula.add(a.createNum());
        return formula;
    }
    public  int solve(List formula){
        Stack<Object> stack=new Stack<>();
        int l=formula.size();
        for(int i=0;i<l;i++){
            if(formula.get(i).equals("*")||formula.get(i).equals("/")){
                int num=(int)stack.pop();
                if(formula.get(i).equals("*")){
                     int sum=num*(int)formula.get(i+1);
                     i+=1;
                     stack.push(sum);
                }else if(formula.get(i).equals("/")){
                    try {
                        int sum=num/(int)formula.get(i+1);
                        i+=1;
                        stack.push(sum);
                    }catch (Exception e) {
                        e.printStackTrace();
                    }
                }
            }else {
                stack.push(formula.get(i));
            }
        }
        int res=0;
        Object num;
        while(true){
            num=stack.pop();
            if(!stack.isEmpty()){
                if(stack.pop().equals("-"))
                    num=0-(int)num;
            }
            res=res+(int)num;
            if (stack.isEmpty()){
                break;
            }
        }
        return res;
    }
    public static void main(String[] args){
        Scanner scanner=new Scanner(System.in);
        int times;
        times=scanner.nextInt();
        String filePath = "subject.txt";
        FileWriter fwriter = null;
        for(int i=0;i<times;i++){
            Calculator calculator=new Calculator();
            List<Object> a;
            a=calculator.createFormula();
            a.toString();
            StringBuffer str=new StringBuffer();
            for(Object x:a ){
                str.append(x);
            }
            try {
                fwriter = new FileWriter(filePath, true);
                fwriter.write(str.toString()+"="+calculator.solve(a)+"\r\n");
            } catch (IOException ex) {
                ex.printStackTrace();
            }finally {
                try {
                    fwriter.flush();
                    fwriter.close();
                } catch (IOException ex) {
                    ex.printStackTrace();
                }
            }
            System.out.println(str.toString());
            System.out.println(a.toString());
        }


    }
}