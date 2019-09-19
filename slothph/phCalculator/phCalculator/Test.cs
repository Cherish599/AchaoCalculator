using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using phCalculator;
using System.Data;

namespace phCalculator
{
   public class Test
    {
        public static string test_timu;
        //测试题目是否合格，将合格题目加入列表
        public static Boolean test(string timu)
        {
            //有除以0时，直接否决
            if (timu.Contains("/0"))
                return false;
            DataTable dt = new DataTable();
            object res = dt.Compute(timu, "");
            //结果为小数或者负数的，也被否决
            if (Convert.ToInt32(res) < 0 || res.ToString().Contains("."))
                return false;
            else
            {
                Program.ans.Add(timu + "=" + res.ToString());
                test_timu = timu + "=" + res.ToString();
                return true;
            }

        }
    }
}
