using System;
using System.Linq;

namespace Calculator.Domain
{
    public class CalculatorLib
    {
        public static int Add(int[] inputs)
        {
            return inputs.Sum();
        }

        public static int Substract(int[] inputs)
        {
            return inputs.Aggregate((last, next) => last - next);
        }

        public static int Multiply(int[] inputs)
        {
            return inputs.Aggregate((last, next) => last * next);
        }

        public static double Divide(double[] inputs)
        {
            return inputs[0] / inputs[1];
        }

        public static double[] SplitEq(int value, int divider)
        {
            return Enumerable.Range(1, divider).Select(i => Math.Round((double)value / (double)divider, 2)).ToArray();
        }
        public static int SplitNum(int[] inputs)
        {
            return default;
        }
    }
}
