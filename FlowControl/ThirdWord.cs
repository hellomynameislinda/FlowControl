using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    internal class ThirdWord
    {
        public string InputString { get; set; }

        public void RunThirdWord()
        {

            /*
                * Ni har tidigare lärt er hur vi omvandlar strängar till integers (tex int.Parse, int.TryParse) men
                * nu ska vi dela upp en sträng. Användaren skall ange en mening, som programmet delar upp
                * i ord via strängens .Split(char)-metod. Ni skall dela strängen på varje mellanslag. För att
                * enkelt lagra detta bör input sparas som en var, då ni kommer få tillbaka mer än en sträng.
                * För att testa det här skall ni skapa case ”4” i er huvudmeny samt skriva en förklaring i
                * texten.
                * Händelseförloppet förklaras nedan:
                * 1. Användaren anger en mening med minst 3 ord
                * 2. Programmet delar upp strängen med split-metoden på varje mellanslag
                * 3. Programmet plockar ut den tredje strängen (ordet) ur input
                * 4. Programmet skriver ut den tredje strängen(ordet)
                */

            //Prepare screen
            Console.Clear();
            Console.WriteLine("Welcome to Third Word!");

            do
            {
                Console.WriteLine("Type a minimum of three words:"); // TODO: Change message on faulty input.
                InputString = Console.ReadLine();
                // TODO: Validate to text only
                if (string.IsNullOrWhiteSpace(InputString))
                {
                    string[] stringAsWords = InputString.Split(' ');
                    if (stringAsWords.Length > 2)
                    {
                        Console.WriteLine($"The third word of the string is: {stringAsWords[2]}");
                        break;      //Break out of the loop only after valid input
                    }
                }
            } while (true);
        }
    }
}
