using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6.Solution.Tests.Helpers
{
    public static class Algoritnms
    {
        public static int GenerateFirstSequence(int previousNumber, int currentNumber)
        => previousNumber + currentNumber;

        public static int GenerateSeconfSequence(int previousNumber, int currentNumber)
            => -8 * previousNumber + 6 * currentNumber;

        public static double GenerateThirdSequence(double previousNumber, double currentNumber)
            => currentNumber + previousNumber / currentNumber;
    }
}
