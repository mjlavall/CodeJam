using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJam
{
    public class Problem : IProblem
    {
        protected List<string> Input { get; set; }
        public int T { get; set; }

        public Problem(List<string> input)
        {
            Input = input;
            T = int.Parse(Input[0]);
        }

        public virtual List<string> Solve()
        {
            return new List<string>();
        }
    }
}
