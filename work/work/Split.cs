using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work
{
    public class Split
    {
        Newrandow newr = new Newrandow();
        public List<string> Splits()
        {
            int m = newr.Randm();
            List<string> list = new List<string>();
            for (int i = 0; i < m; i++)
            {
                list.Add(newr.RandInt().ToString());
                list.Add(newr.RandSymbol());
            }
            list.Add(newr.RandInt().ToString());
            return list;
        }
    }
}
