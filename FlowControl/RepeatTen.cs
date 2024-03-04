using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    internal class RepeatTen
    {
        private string InputString { get; set; }

        public void RunRepeatTen()
        {
            string errorMsg = "";

            // Prepare screen
            Console.Clear();
            Console.WriteLine("Welcome to Repeat Ten!");

            do
            {
                Console.WriteLine((errorMsg.Length > 0) ? errorMsg : "Type a word or a short message: "); // On first run, display instructions. On subsequent runs, display error message
                InputString = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(InputString))
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.Write($"{i}. {InputString} ");
                    }
                    break;      //Break out of the loop only after valid input
                }
                else
                {
                    errorMsg = "Error: Your input can not be empty. Please try again:";
                }
            } while (true);

            UIHelpers.PauseAfterTask();

        }
    }
}
