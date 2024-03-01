using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    internal class CinemaTicket
    {
        private static string InputString { get; set; }

        public static void RunCheckCinemaPrice()
        {
            /*
             * För att använda en annan typ av iteration skall ni här implementera en for-loop. Detta ska
             * ni skapa för att upprepa något en användare skriver in tio gånger. Det ska alltså inte
             * skrivas via tio stycken ”Console.Write(Input);” utan via en loop som gör detta tio
             * gånger. För att komma till den här funktionen skall ni lägga till ett case för ”3” i er
             * huvudmeny samt text som förklarar detta.
             * Händelseförloppet visas nedan:
             * 1. Användaren anger en godtycklig text
             * 2. Programmet sparar texten som en variabel
             * 3. Programmet skriver, via en for-loop ut denna text tio gånger på rad, alltså UTAN
             * radbrott. Exempel på output: 1. Input, 2. Input, 3. Input osv.

             */

            Console.Clear();
            Console.WriteLine("Welcome to Cinema Price Check!");

            uint inputAge;
            string errorMsg = "";

            do
            {
                Console.WriteLine((errorMsg.Length > 0) ? errorMsg : "Please enter your age: "); // On first run, display instructions. On subsequent runs, display error message
                errorMsg = ""; // Reset for each try

                InputString = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(InputString))
                {
                    if (uint.TryParse(InputString, out inputAge))
                    {
                        if (inputAge >= 0 && inputAge <= 120) // Check if inputAge is "reasonable"
                        {
                            GetPriceByAge(inputAge, true);
                        }
                        else
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
                    errorMsg = "Error: This is not a valid input: Please try again:";
                }

            } while (errorMsg.Length > 0);

        }

        private static int GetPriceByAge(uint age, bool print = false)
        {
            if (age < 20) // Kids under 20
            {   
                if (print)
                    Console.WriteLine("Ungdomspris: 80kr");
                return 80;
            }
            else if (age > 64) // Retirees over 64
            {
                if (print)
                    Console.WriteLine("Pensionärspris: 80kr");
                return 90;
            }
            else // Everyone else
            {
                if (print)
                    Console.WriteLine("Standardpris: 120kr");
                return 120;

            }
        }

    }
}
