﻿using System;


namespace FlowControl
{
    internal class Program
    {
        /*
         * Note: I needed to practice static vs non-static functions, hence the difference
         * between the first two parts of the application and the last two. 
         * */

        private static RepeatTen repeatTen = new RepeatTen();
        private static ThirdWord thirdWord = new ThirdWord();

        static void Main(string[] args)
        {
            string errorMsg = "";

            do
            {
                if (errorMsg.Length > 0) // Upon a faulty selection - Display error message instead of reloading menu
                {
                    Console.WriteLine(errorMsg);
                    errorMsg = "";
                }
                else {
                    UIHelpers.DisplayMainMenu();
                }

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CinemaTicket.RunCheckCinemaPrice();
                        break;
                    case "2":
                        CinemaGroup.RunCheckCinemaGroupPrice();
                        break;
                    case "3":
                        repeatTen.RunRepeatTen();
                        break;
                    case "4":
                        thirdWord.RunThirdWord();
                        break;
                    case "0":
                        Console.WriteLine("Good bye!");
                        Environment.Exit(0);
                        break;
                    default:
                        errorMsg = "Please make a valid selection.";
                        break;
                }
                // VISA UT MENY


                // VAL 1 + 2
                /*
                 * För att exemplifiera if-satser skall ni implementera, på uppdrag av en teoretisk lokal bio,
                 * ett program som kollar om en person är pensionär eller ungdom vid angiven ålder. För att
                 * komma till denna funktion skall ett case i huvudmenyn skapas för ”1”, detta skall även
                 * framgå i texten som förklarar menyn.
                 * För att göra detta skall ni använda er av en nästlad if-sats. Det skall ske enligt följande
                 * förlopp:
                 * 1. Användaren anger en ålder i siffror
                 * 2. Programmet konverterar detta från en sträng till en int
                 * 3. Programmet ser om personen är ungdom (under 20 år)
                 * 4. Om det ovanstående är sant skall programmet skriva ut: Ungdomspris: 80kr
                 * 5. Annars kollar programmet om personen är en pensionär (över 64 år)
                 * 6. Om ovanstående är sant skall programmet skruva ut: Pensionärspris: 90kr
                 * 7. Annars skall programmet skriva ut: Standardpris: 120kr
                 * Vi vill även få möjlighet att kunna räkna ut priset för ett helt sällskap. Lägg till det
                 * alternativet i huvudmenyn (ett case “2”). Det är även ok att ha alternativet i en undermeny.
                 * Vi anger då först hur många vi är som ska gå på bio. Frågar sedan efter ålder på var och en
                 * och skriver sedan ut en sammanfattning i konsolen som ska innehålla följande:
                 * ● Antal personer
                 * ● Samt totalkostnad för hela sällskapet
                 */

            } while (true);
        }
    }
}
