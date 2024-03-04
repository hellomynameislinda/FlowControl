using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

        internal static void DisplayMainMenu(bool clear = true)
        {
            /*
             * Displays the main meny, with or without clearing the screen. Not clearing 
             * the screen can be used in case of error messages.
             */
            if (clear)
                Console.Clear();
            Console.WriteLine("WELCOME TO FLOW CONTOL");
            Console.WriteLine("Select an activity by entering a number from the menu:");
            Console.WriteLine($"{CinemaTicket}. Check cinema singel ticket price\n" +
                $"{CinemaGroup}. Check cinema ticket price for group\n" +
                $"{RepeatTen}. Repeat Ten\n" +
                $"{ThirdWord}. Third Word\n" +
                $"{Quit}. Quit");
        }

        internal static void DisplayCinemaSubMenu()
        {
            /*
             * Displays sub menu for the Cinema group ticket part of the application
             * I chose to separate adding users and showing the total, to make it
             */
            Console.WriteLine("\nSelect an activity by entering a number from the menu:");
            Console.WriteLine($"{CinemaTicket}. Add cinema visitors\n" +
                $"{CinemaGroup}. Check cinema ticket total\n" +
                $"{Quit}. Back to main menu");
        }

        internal static void PauseAfterTask()
        {
            /*
             * Used after finishing each part of the application, to give the user time to 
             * review the rults before going back to the main menu.
             */
            Console.WriteLine("\n\nPress enter to select a new activity...");
            Console.ReadLine();
        }
    }
}
