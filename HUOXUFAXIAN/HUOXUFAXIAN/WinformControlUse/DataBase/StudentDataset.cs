﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Collections;
using Entity;

namespace DataBase
{
    public class StudentDataset
    {
        //模拟数据库中的学生集合

        private static List<Student> studengList;


        public static List<Student> getAll()
        {
            studengList=new List<Student>();

            Student stu1 = new Student("1132", "王川");
            studengList.Add(stu1);
            Student stu2 = new Student("1227", "于丁");
            studengList.Add(stu2);

            Student stu3 = new Student("2104", "张莹");
            studengList.Add(stu3);
            Student stu4 = new Student("4101", "李楠");
            studengList.Add(stu4);

            Student stu5 = new Student("4102", "陈欣");
            studengList.Add(stu5);
            Student stu6 = new Student("4104", "马芸慧");
            studengList.Add(stu6);

            Student stu7 = new Student("4105", "汪小萍");
            studengList.Add(stu7);
            Student stu8 = new Student("4106", "母丹");
            studengList.Add(stu8);


            Student stu9 = new Student("4144", "许博");
            studengList.Add(stu9);
            Student stu10 = new Student("4146", "芦文钰");
            studengList.Add(stu10);

            Student stu11 = new Student("4107", "马昊妍");
            studengList.Add(stu11);
            Student stu12 = new Student("4108", "李宣晓");
            studengList.Add(stu12);

            Student stu13 = new Student("4109", "李清兰");
            studengList.Add(stu13);
            Student stu14 = new Student("4110", "成湘");
            studengList.Add(stu14);

            Student stu15 = new Student("4111", "罗涵");
            studengList.Add(stu15);
            Student stu16 = new Student("4112", "肖逸菲");
            studengList.Add(stu16);

            Student stu17 = new Student("4113", "冯士坤");
            studengList.Add(stu17);
            Student stu18 = new Student("4114", "杨汶桐");
            studengList.Add(stu18);

            Student stu19 = new Student("4114", "张焱菁");
            studengList.Add(stu19);
            Student stu20 = new Student("4116", "雷槟源");
            studengList.Add(stu20);

            Student stu21 = new Student("4117", "李志");
            studengList.Add(stu21);
            Student stu22 = new Student("4118", "黄涛");
            studengList.Add(stu22);

            Student stu23 = new Student("4119", "宋杰");
            studengList.Add(stu23);
            Student stu24 = new Student("4120", "赵俊安");
            studengList.Add(stu24);


            Student stu25 = new Student("4121", "张新明");
            studengList.Add(stu25);
            Student stu26 = new Student("4122", "张旭");
            studengList.Add(stu26);

            Student stu27 = new Student("4123", "王旭");
            studengList.Add(stu27);
            Student stu28 = new Student("4124", "李朋珂");
            studengList.Add(stu28);

            Student stu29 = new Student("4125", "张微玖");
            studengList.Add(stu29);
            Student stu30 = new Student("4126", "何明钦");
            studengList.Add(stu30);

            Student stu31 = new Student("4127", "姜玖林");
            studengList.Add(stu31);
            Student stu32 = new Student("4128", "涂才森");
            studengList.Add(stu32);



            Student stu33 = new Student("4129", "陈林");
            studengList.Add(stu33);
            Student stu34 = new Student("4130", "曾正男");
            studengList.Add(stu34);

            Student stu35 = new Student("4131", "江天宇");
            studengList.Add(stu35);
            Student stu36 = new Student("4132", "魏恩博");
            studengList.Add(stu36);

            Student stu37 = new Student("4133", "邹扬锋");
            studengList.Add(stu37);
            Student stu38 = new Student("4134", "曾琅");
            studengList.Add(stu38);

            Student stu39 = new Student("4135", "周成杰");
            studengList.Add(stu39);

            Student stu40 = new Student("4136", "马驰");
            studengList.Add(stu40);

            Student stu41 = new Student("4137", "宋树钱");
            studengList.Add(stu41);
            Student stu42 = new Student("4138", "马驰");
            studengList.Add(stu42);
            Student stu43 = new Student("4142", "任星辰");
            studengList.Add(stu43);

            Student stu44 = new Student("3225", "严一笑");
            studengList.Add(stu44);
            Student stu45 = new Student("4201", "孙颖");
            studengList.Add(stu45);
            Student stu46 = new Student("4202", "吴明益");
            studengList.Add(stu46);
            Student stu47 = new Student("4203", "黄耀萱");
            studengList.Add(stu47);
            Student stu48 = new Student("4204", "王静宜");
            studengList.Add(stu48);
            Student stu49 = new Student("4205", "蔡玉蓝");
            studengList.Add(stu49);

            Student stu50 = new Student("4206", "姜仪");
            studengList.Add(stu50);

            Student stu51 = new Student("4207", "郑雪");
            studengList.Add(stu51);
            Student stu52 = new Student("4208", "刘俊");
            studengList.Add(stu52);
            Student stu53 = new Student("4209", "何玉姣");
            studengList.Add(stu53);
            Student stu54 = new Student("4210", "匡小娟");
            studengList.Add(stu54);
            Student stu55 = new Student("4211", "王春兰");
            studengList.Add(stu55);
            Student stu56 = new Student("4212", "顾毓");
            studengList.Add(stu56);
            Student stu57 = new Student("4213", "师志杰");
            studengList.Add(stu57);
            Student stu58 = new Student("4214", "许佳文");
            studengList.Add(stu58);
            Student stu59 = new Student("4215", "雷安勇");
            studengList.Add(stu59);

            Student stu60 = new Student("4216", "张伟");
            studengList.Add(stu60);


            Student stu61 = new Student("4217", "袁志杰");
            studengList.Add(stu61);
            Student stu62 = new Student("4218", "何全江");
            studengList.Add(stu62);
            Student stu63 = new Student("4219", "舒鹏飞");
            studengList.Add(stu63);
            Student stu64 = new Student("4220", "何辉");
            studengList.Add(stu64);
            Student stu65 = new Student("4221", "李全喜");
            studengList.Add(stu65);
            Student stu66 = new Student("4222", "谢凯宇");
            studengList.Add(stu66);
            Student stu67 = new Student("4225", "黄本巍");
            studengList.Add(stu67);
            Student stu68 = new Student("4226", "罗俊杰");
            studengList.Add(stu68);
            Student stu69 = new Student("4227", "何宸锐");
            studengList.Add(stu69);
            Student stu70 = new Student("4228", "付昶宇");
            studengList.Add(stu70);
            Student stu71 = new Student("4229", "傅伟鑫");
            studengList.Add(stu71);

            Student stu72 = new Student("4231", "王云飞");
            studengList.Add(stu72);

            Student stu73 = new Student("4232", "李元港");
            studengList.Add(stu73);

            Student stu74 = new Student("4233", "赵荣泽");
            studengList.Add(stu74);

            Student stu75 = new Student("4234", "吴郑浩");
            studengList.Add(stu75);

            Student stu76 = new Student("4235", "何继武");
            studengList.Add(stu76);

            Student stu77 = new Student("4236", "郑博");
            studengList.Add(stu77);

            Student stu78 = new Student("4237", "王万成");
            studengList.Add(stu78);

            Student stu79 = new Student("4238", "陈杰");
            studengList.Add(stu79);

            Student stu80 = new Student("4240", "胡志伟");
            studengList.Add(stu80);

            Student stu81 = new Student("4241", "涂林");
            studengList.Add(stu81);
            Student stu82 = new Student("4242", "孟诚成");
            studengList.Add(stu82);
            Student stu83 = new Student("2125", "廖志丹");
            studengList.Add(stu83);
            Student stu84 = new Student("1317", "杨也");
            studengList.Add(stu84);


            return studengList;
        }
    }
}
