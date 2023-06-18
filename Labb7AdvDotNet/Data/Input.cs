using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7AdvDotNet.Data
{
    public class Input
    {
        public static Tuple<float, float> CalcInput()
        {
            Console.Write("Please enter the first number: ");
            float.TryParse(Console.ReadLine(), out float x);
            Console.Write("Please enter the second number: ");
            float.TryParse(Console.ReadLine(), out float y);
            Tuple<float, float> toCalc = new(x, y);

            return toCalc;
        }
        public static int MenuInput()
        {
            int.TryParse(Console.ReadLine(), out int choice);
            return choice;
        }
    }
}
