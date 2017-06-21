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
        public int T { get; set; }
        public QualA(List<string> input) : base(input) {
            //Input = new List<string>
            //{
            //    "3",
            //    "---+-++- 3",
            //    "+++++ 4",
            //    "-+-+- 4"
            //};
            parseInput();
        }

        private void parseInput()
        {
            T = int.Parse(Input[0]);
        }

        public override List<string> Solve()
        {
            var result = new List<string>();
            for(int i=1; i<Input.Count; i++)
            {
                var arr = Input[i].Split(' ');
                var pattern = arr[0];
                var k = int.Parse(arr[1]);
                result.Add($"Case #{i}: {solveLine(pattern, k)?.ToString() ?? "IMPOSSIBLE"}");
            }
            return result;
        }

        private int? solveLine(string pattern, int k)
        {
            int count = 0;
            for(int i=0; i<pattern.Length - k + 1; i++)
            {
                if(pattern[i] == '-')
                {
                    pattern = flip(pattern, k, i);
                    count++;
                }
            }
            if (pattern.Count(c => c == '+') == pattern.Length) return count;
            return null;
        }

        private string flip(string pattern, int k, int i)
        {
            var p = pattern.ToList();
            for(int j=0; j<k; j++)
            {
                p[i + j] = flip(p[i + j]);
            }
            pattern = "";
            foreach (var c in p)
            {
                pattern += c;
            }
            return pattern;
        }

        private char flip(char c)
        {
            return c == '-' ? '+' : '-';
        }
    }
}
