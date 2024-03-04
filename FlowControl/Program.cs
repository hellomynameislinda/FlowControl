using System;


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
            } while (true);
        }
    }
}
