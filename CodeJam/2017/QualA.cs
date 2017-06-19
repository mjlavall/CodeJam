using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodeJam._2017
{
    public class QualA : Problem
    {
        public QualA(List<string> input) : base(input) { }

        public override List<string> Solve()
        {
            Thread.Sleep(5000);
            return new List<string> { "From QualA " };
        }
    }
}
