package ��������;

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
		
		PrintStream p=new PrintStream(new FileOutputStream("subject.txt"),true);//�����ļ�subject.txt	
		System.out.println("������Ҫ���ɼ���ʽ�ӣ�");
		Scanner s=new Scanner(System.in);
		int num=s.nextInt();
		for(int j=0;j<num;j++)
		{
			int[] a=new int[4];
			char[] c= {'+','-','*','/'};
			Random r=new Random(System.nanoTime());
			for(int i=0;i<4;i++)//��������ĸ�100���ڵ���
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
			
			result=Double.parseDouble(String.valueOf(engine.eval(suanshi)));//�������͵�String�ַ���ת��Ϊ������
			 
			if(Math.floor(result)==result&&result>0&&result<=1000000)
			{
				System.out.println(suanshi+"="+(int)result);
				p.println(suanshi+"="+(int)result);//д���ļ�
				
			}
			else //���������ڷ�Χ�ھ���ȥ������ɵ���ʽ
				j--;
			
		}

	}

	

}
