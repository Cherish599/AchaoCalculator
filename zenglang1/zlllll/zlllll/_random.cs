using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zlllll
{
   public class _random
    {
        Random random = new Random(); //随机数对象  
        public _random()//构造函数
        {

        }
        public float return_operand() //返回操作数（0-100）
        {
            return (float)random.Next(0, 101);
        }
        public int return_num() //返回一道题中有几个运算符（2-3）
        {
            return random.Next(2, 4);
        }
        //返回运算符数组对应的下标
        public int return_operator()
        {
            return random.Next(0, 4);
        }
    }
    //四则运算类，栈的运用
}
