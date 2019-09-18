using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace cee
{
    class PrintCalcuate
    {

        public PrintCalcuate(int n)
        {
            
            char[] o = { '+', '-', '*', '/' };
            Random rd = new Random();
            int i = 0;
            while (i < n)
            {
                int h = rd.Next(2, 4);
                int a = rd.Next(0, 100);
                string result = null;
                result = result + a;
                for (int j = 0; j < h; j++)
                {
                    int m = rd.Next(0, 4);
                    int b = rd.Next(0, 100);
                    if (o[m] == '/')
                    {
                        if (b != 0)
                        {

                            result = result + o[m] + b;


                        }

                        else
                            break;
                    }
                    else
                    {
                        result = result + o[m] + b;


                    }


                }
                if (Com(result) % 1 == 0 && Com(result) >= 0)
                {
                    i++;
                    Console.WriteLine(result + "=" + Com(result));
                    CreatFile cf = new CreatFile(result + "=" + Com(result));
                }


            }

        }
        public double Com(string result)
        {

            DataTable da = new DataTable();
            double end = double.Parse(da.Compute(result, "").ToString());
            return end;
        }

    }
}
