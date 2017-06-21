using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodeJam._2017
{
    public class QualB : Problem
    {
        
        public QualB(List<string> input) : base(input) {
            //Input = new List<string>
            //{
            //    "4",
            //    "132",
            //    "1000",
            //    "7",
            //    "111111111111111110"
            //};
        }

        public override List<string> Solve()
        {
            var result = new List<string>();
            for(int i=1; i<Input.Count; i++)
            {
                result.Add($"Case #{i}: {solveLine(long.Parse(Input[i]))}");
            }
            return result;
        }

        private long solveLine(long N)
        {
            var nstr = N.ToString();
            for(int i=0; i<nstr.Length-1; i++)
            {
                int a = int.Parse(nstr[i].ToString());
                int b = int.Parse(nstr[i+1].ToString());

                if (a > b)  // non decreasing
                {
                    string solution = "";
                    if(a > 1) // simple case
                    {
                        int index = 0;
                        for(int k=0; k<nstr.Length; k++)
                        {
                            int m = int.Parse(nstr[k].ToString());
                            if (m >= a) index = k;
                            if (m == a) break;
                        }

                        a--;
                        solution = nstr.Substring(0, index);
                        solution += a.ToString();

                        for(int j=index+1; j<nstr.Length; j++)
                        {
                            solution += "9";
                        }
                        return long.Parse(solution);
                    }
                    else if(a == 1)
                    {
                        for(int j=0; j<nstr.Length-1; j++)
                        {
                            solution += "9";
                        }
                        return long.Parse(solution);
                    }
                }
            }
            return N;
        }
    }
}
