using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FlowControl
{
    internal class CinemaVisitor
    {
        internal string Name { get; set; } // Only used to save a fake "name"
        internal uint Age { get; set; }

        public CinemaVisitor(string name, uint age)
        {
            Name = name;
            Age = age;
        }

        internal static uint ReadVisitorAge(string leadingText)
        {
            string inputString;
            uint inputAge = 0;  // Must be set to something or it looks unsigne at return, even though we should never get there without a value
            string errorMsg = "";

            do
            {
                Console.WriteLine((errorMsg.Length > 0) ? errorMsg : leadingText); // On first run, display instructions. On subsequent runs, display error message
                errorMsg = ""; // Reset for each try

                inputString = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(inputString))
                {
                    if (uint.TryParse(inputString, out inputAge))
                    {
                        if (inputAge < 0 || inputAge > 120) // Check if inputAge is "reasonable"
                        {
                            errorMsg = "Error: This is not a valid age. Please try again:";
                        }
                    }
                    else
                    {
                        errorMsg = "Error: Age has to be written in digits. Please try again:";
                    }
                }
                else
                {
                    errorMsg = "Error: This is not a valid input. Please try again:";
                }

            } while (errorMsg.Length > 0);

            // If there were no erros
            return inputAge;
        }
    }
}
