using System.Collections.Generic;

namespace aChao_1
{
    public class Joint
    {
        private RandomCollection RandomCollection = new RandomCollection();
        /// <summary>
        /// 创建等式，还未算和
        /// </summary>
        /// <param name="m">运算符个数</param>
        /// <returns>一条运算式</returns>
        public List<string> craeteEqual(int m)
        {
            List<string> equalString = new List<string>();
            for(int i = 0; i < m; i++)
            {
                equalString.Add(this.RandomCollection.randomInt(1,100).ToString());
                equalString .Add (this.RandomCollection.randomSymbol());
            }
            equalString .Add (this.RandomCollection.randomInt(1,100).ToString());
            return equalString;
        }
    }
}
