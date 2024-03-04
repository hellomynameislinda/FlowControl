using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    internal class ThirdWord
    {
        internal string InputString { get; set; }

        public void RunThirdWord()
        {
            string errorMsg = "";

            //Prepare screen
            Console.Clear();
            Console.WriteLine("Welcome to Third Word!");
            do
            {
                Console.WriteLine((errorMsg.Length > 0) ? errorMsg : "Type a minimum of three words: "); // On first run, display instructions. On subsequent runs, display error message
                InputString = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(InputString)) // Make sure we don't have an empty string, or display an error
                {
                    string[] stringAsWords = InputString.Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).ToArray(); // Remove empty elements due to double (and triple+) spaces.
                    if (stringAsWords.Length > 2)
                    {
                        Console.WriteLine($"The third word of the string is: {stringAsWords[2]}");
                        break;      //Break out of the loop only after valid input
                    }
                    else
                    {
                        errorMsg = "Error: Your sentence must be three words or more. Please try again:";
                    }

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
