package com;

import java.util.Random;

public class randomNum {
    int num;
    public int createNum(){
        this.num=(int)(Math.random()*100)+1;
        return num;
    }
    public String createRuler(){
        this.num=(int) (Math.random()*4)+1;
        if(num==1){
            return "+";
        }else if(num==2){
            return "-";
        }else if(num==3){
            return "*";
        }else {
            return "/";
        }
    }
    public int createLen(){
        Random random=new Random();
        this.num=random.nextInt(2)+2;
        return num;
    }
}
