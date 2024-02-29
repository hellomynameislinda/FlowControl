using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    internal class UIHelpers
    {
        public const string Cinema1 = "1";
        public const string Cinema2 = "2";
        public const string RepeatTen = "3";
        public const string ThirdWord = "4";
        public const string Quit = "0";

        internal static void DisplayMenu() {
            Console.Clear();
            Console.WriteLine("WELCOME TO FLOW CONTOL");
            Console.WriteLine($"{Cinema1}. Cinema1\n" +
                $"{Cinema2}. Cinema2\n" +
                $"{RepeatTen}. Repeat Ten\n" +
                $"{ThirdWord}. Third Word\n" +
                $"{Quit}. Quit");
        }
    }
}
