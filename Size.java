package 四则运算;

import javax.script.ScriptEngine;
import javax.script.ScriptEngineManager;
import javax.script.ScriptException;
import java.util.Scanner;
import java.io.PrintStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.Random;

public class Size {
	@SuppressWarnings("resource")
	public static void main(String[] args) throws ScriptException, IOException {
		ScriptEngineManager manager = new ScriptEngineManager();
        ScriptEngine engine = manager.getEngineByName("JavaScript");
		String suanshi = "";
		double result=0;
		
		PrintStream p=new PrintStream(new FileOutputStream("subject.txt"),true);//创建文件subject.txt	
		System.out.println("请输入要生成几个式子：");
		Scanner s=new Scanner(System.in);
		int num=s.nextInt();
		for(int j=0;j<num;j++)
		{
			int[] a=new int[4];
			char[] c= {'+','-','*','/'};
			Random r=new Random(System.nanoTime());
			for(int i=0;i<4;i++)//随机生成四个100以内的数
			{
				a[i]=r.nextInt(100);
			}
			
			Random zifu=new Random(System.nanoTime());
			int yunsuanfu=zifu.nextInt(4);
			int yunsuanfu1=zifu.nextInt(4);
			int yunsuanfu2=zifu.nextInt(4);
			int yunsuanfu3=zifu.nextInt(4);
			int yunsuanfu4=zifu.nextInt(4);
			int m=r.nextInt(2);
			switch(m)
			{
			case 0:
				suanshi=String.valueOf(""+a[0]+c[yunsuanfu]+a[1]+c[yunsuanfu1]+a[2]);
				break;
			case 1:
				suanshi=String.valueOf(""+a[0]+c[yunsuanfu2]+a[1]+c[yunsuanfu3]+a[2]+c[yunsuanfu4]+a[3]);
				break;
			
			}
			
			result=Double.parseDouble(String.valueOf(engine.eval(suanshi)));//数字类型的String字符串转换为浮点数
			 
			if(Math.floor(result)==result&&result>0&&result<=1000000)
			{
				System.out.println(suanshi+"="+(int)result);
				p.println(suanshi+"="+(int)result);//写入文件
				
			}
			else //如果结果不在范围内就舍去这个生成的算式
				j--;
			
		}

	}

	

}
