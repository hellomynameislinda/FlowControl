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
            Console.WriteLine("Welcome to Repeat Ten!");

            do
            {
                Console.WriteLine("Type a word or a short message: "); // TODO: Change message on faulty input.
                InputString = Console.ReadLine();
                // TODO: Validate to text only
                if (!string.IsNullOrWhiteSpace(InputString))
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.Write($"{i}. {InputString} ");
                    }
                    break;      //Break out of the loop only after valid input
                }
            } while (true);

        }
    }
}
