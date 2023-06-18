using Labb7AdvDotNet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7AdvDotNet.UI
{
    public class Menu
    {
        public static List<string> Results = new List<string>();
        public static void MenuStart()
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Calculator\n\nPlease select a menu choice from below\n" +
                    "1. Addition\n2. Subtraction\n3. Multiplication\n4. Show previous calculations" +
                    "\n5. Clear Window\n6. Exit");
                switch (Input.MenuInput())
                {
                    case 1:
                        SaveAndDisplay(Calculate.Addition(Input.CalcInput()));
                        break;
                    case 2:
                        SaveAndDisplay(Calculate.Subtraction(Input.CalcInput()));
                        break;
                    case 3:
                        SaveAndDisplay(Calculate.Multiplication(Input.CalcInput()));
                        break;
                    case 4:
                        DisplayAll();
                        break;
                    case 5:
                        Console.Clear();
                        break;
                    case 6:
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

            }

        }
        public static void SaveAndDisplay(string result)
        {
            Console.WriteLine(result);
            Results.Add(result);
        }
        public static void DisplayAll()
        {
            foreach (var item in Results) Console.WriteLine(item);
        }
    }
}
