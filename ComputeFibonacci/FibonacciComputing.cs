using CommonLibrary;
using System.Collections.Generic;

namespace ComputeFibonacci
{
    public class FibonacciComputing : IExecutable
    {
        public string Execute(string value)
        {
            var number = int.Parse(value);
            var n1 = 0;
            var n2 = 1;
            var n3 = 0;
            var fibonacciSequence = new List<long>();
            fibonacciSequence.Add(n1);
            fibonacciSequence.Add(n2); 
            for (var i = 2; i < number; ++i)
            {
                n3 = n1 + n2;
                fibonacciSequence.Add(n3);
                n1 = n2;
                n2 = n3;
            }
            return $"[{string.Join(',', fibonacciSequence)}]";
        }
    }
}
