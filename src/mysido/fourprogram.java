package src.mysido;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.util.HashSet;
import java.util.Scanner;
import java.util.Set;

public class fourprogram {
    private static String[] op = { "+", "-", "*", "/" };
    public static void main(String[] args) {
        int n;
        Scanner sc=new Scanner(System.in);
        n=sc.nextInt();

        BufferedWriter bw=null;
        File f=new File("E:\\result.txt");
        if(!f.exists()) {
            try {
                f.createNewFile();
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
        try {
            bw = new BufferedWriter(new FileWriter(f));
        }  catch (IOException e) {
            e.printStackTrace();
        }
        for(int i=0;i<n;i++){
            String myneed=MakeFormula();
            int p= solve.Calcula(myneed);
            myneed+=p;
            System.out.println(myneed);
            try {
                bw.write(myneed);
                bw.flush();
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
        try {
            bw.close();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
    /*public  static int grt(String p,int i,boolean fg){
        StringBuffer bf=new StringBuffer();
        if(fg) {
            for (int j = i - 1; j >= 0; j--) {
                int m = p.charAt(j);
                if (m > '9') break;
                bf.append(p.charAt(j));
            }
            return Integer.valueOf(bf.reverse().toString());
        }
        else{
            for (int j = i + 1; j <p.length(); j++) {
                int m = p.charAt(j);
                if (m > '9') break;
                bf.append(p.charAt(j));
            }
            return Integer.valueOf(bf.toString());
        }
    }
    public static boolean pd(String x){
        for(int i=0;i<x.length();i++){
            if(x.charAt(i)=='/'){
                int a=grt(x,i,true)
                int b=grt(x,i,false);
                if(b=='0'||a%b!=0)return false;
            }
        }
        return true;
    }*/
    public static int getset(int last){
        Set<Integer> set=new HashSet<>();
        for(int i=1;i<=last;i++){
            if(last%i==0)
                set.add(i);
        }
        int m= (int) (Math.random() * set.size())+1;
        for(int q:set){
           m--;
           if(m==0)return q;
        }
        return 1;
    }
    public static String MakeFormula(){

        StringBuilder build = new StringBuilder();

        int count = (int) (Math.random() * 2) + 1;// generate random count

        int start = 0;

        int number1 = (int) (Math.random() * 99) + 1;

        build.append(number1);
        int last=number1;
        while (start <= count){

            int operation = (int) (Math.random() * 4); // generate operator
            int number2 = (int) (Math.random() * 99) + 1;
            if(operation==3){
                if (last%number2!=0){
                    number2 = getset(last);
                }
            }
            last=number2;
            build.append(op[operation]).append(number2);
            start ++;
        }
        build.append('=');
        return build.toString();
    }
}
