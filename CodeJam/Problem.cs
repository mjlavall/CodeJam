using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJam
{
    public class Problem : IProblem
    {
        List<string> Input { get; set; }

        public Problem(List<string> input)
        {
            Input = input;
        }

        public virtual List<string> Solve()
        {
            return new List<string>();
        }
    }
}
