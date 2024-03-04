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
            Console.Clear();
            Console.WriteLine("Welcome to Cinema Price Check!");

            uint visitorAge = CinemaVisitor.ReadVisitorAge("Please enter your age: ");
            GetPriceByAge(visitorAge, true);

            UIHelpers.PauseAfterTask();

        }

        internal static uint GetPriceByAge(uint age, bool print = false)
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
