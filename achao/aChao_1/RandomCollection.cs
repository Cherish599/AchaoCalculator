using System;
using System.Collections.Generic;
using System.Text;

namespace aChao_1
{
    public class RandomCollection
    {
        private Random random = new Random();
        private string[] symbol = { "+", "-", "*", "÷" };
        /// <summary>
        /// 产生整数
        /// </summary>
        /// <returns>返回一个0-100的整数</returns>
        public int randomInt(int n,int m)
        {
            return this.random.Next(n,m);
        }
        /// <summary>
        /// 产生符号
        /// </summary>
        /// <returns>返回一个随机符号</returns>
        public string randomSymbol()
        {
            return this.symbol[this.random.Next(4)];
        }
    }
}
