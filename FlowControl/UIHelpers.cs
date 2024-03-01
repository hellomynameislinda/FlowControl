﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    internal class UIHelpers
    {
        public const string CinemaTicket = "1";
        public const string CinemaGroup = "2";
        public const string RepeatTen = "3";
        public const string ThirdWord = "4";
        public const string Quit = "0";

        internal static void DisplayMenu() {
            Console.Clear();
            Console.WriteLine("WELCOME TO FLOW CONTOL");
            Console.WriteLine("Select an activity by entering a number from the menu:");
            Console.WriteLine($"{CinemaTicket}. Check cinema ticket price\n" +
                $"{CinemaGroup}. Check cinema ticket price for group\n" +
                $"{RepeatTen}. Repeat Ten\n" +
                $"{ThirdWord}. Third Word\n" +
                $"{Quit}. Quit");
        }
    }
}
