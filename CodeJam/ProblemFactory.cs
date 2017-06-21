using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJam
{
    public static class ProblemFactory
    {

        public enum ProblemRound { QualB_2017, QualA_2017 };

        public static Problem CreateProblem(ProblemRound round, List<string> input)
        {
            switch (round)
            {
                case ProblemRound.QualB_2017:
                    return new _2017.QualB(input);
                    break;
                case ProblemRound.QualA_2017:
                    return new _2017.QualA(input);
                    break;
                default:
                    return new Problem(input);
                    break;
            }
        }
    }
}
