using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7AdvDotNet.Data
{
    public class Calculate
    {
        public static string Addition(Tuple<float, float> toCalc)
        {
            float answer = toCalc.Item1 + toCalc.Item2;
            return $"{toCalc.Item1} + {toCalc.Item2} = {answer:n2}";
        }
        public static string Subtraction(Tuple<float, float> toCalc)
        {
            float answer = toCalc.Item1 - toCalc.Item2;
            return $"{toCalc.Item1} - {toCalc.Item2} = {answer:n2}";
        }
        public static string Multiplication(Tuple<float, float> toCalc)
        {
            float answer = toCalc.Item1 * toCalc.Item2;
            return $"{toCalc.Item1} * {toCalc.Item2} = {answer:n2}";
        }
        public static string Division(Tuple<float, float> toCalc)
        {
            float answer = toCalc.Item1 / toCalc.Item2;
            return $"{toCalc.Item1} / {toCalc.Item2} = {answer:n2}";

        }

    }
}
