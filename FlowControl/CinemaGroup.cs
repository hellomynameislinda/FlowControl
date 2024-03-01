namespace FlowControl
{
    internal class CinemaGroup
    {
        private static List<CinemaVisitor> cinemaGroupMembers { get; set; }

        public CinemaGroup()
        {
        }

        internal static void RunCheckCinemaGroupPrice()
        {

            cinemaGroupMembers = new List<CinemaVisitor>(); // Adding this to the function starting this part of the program, as the constructor is never run.

            // Ask how many tickets
            // Iterate that number of times, ask for age
            // Count and display total
            //


            //Prepare screen
            Console.Clear();
            Console.WriteLine("Welcome to Cinema Group Price Check!");
            do
            {
                UIHelpers.DisplayCinemaSubMenu();

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CinemaGroup.AddGroupMembers();
                        break;
                    case "2":
                        // TODO
                        CinemaGroup.DisplayCinemaGroupTotal();
                        break;
                    case "0":
                        return; // No break needed as return goes back one step further (exiting the whole function) instead. Removed to avoid warnings.
                    default:
                        // TODO: Add message to correct
                        break;
                }

                //Console.WriteLine("Type a minimum of three words:"); // TODO: Change message on faulty input.
                //InputString = Console.ReadLine();
                //// TODO: Validate to text only
                //if (!string.IsNullOrWhiteSpace(InputString)) // Make sure we 
                //{
                //    string[] stringAsWords = InputString.Split(' ');
                //    if (stringAsWords.Length > 2)
                //    {
                //        Console.WriteLine($"The third word of the string is: {stringAsWords[2]}");
                //        break;      //Break out of the loop only after valid input
                //    }
                //}
            } while (true);
        }

        internal static void AddGroupMembers()
        {
            string inputString;
            uint numberOfGroupMembers;
            uint age;
            string errorMsg = "";

            do
            {
                Console.WriteLine((errorMsg.Length > 0) ? errorMsg : "Enter the number of group members you want to add: "); // On first run, display instructions. On subsequent runs, display error message
                errorMsg = ""; // Reset for each try

                inputString = Console.ReadLine();
                errorMsg = "Error: Number of groupmember must be written in digits. Please try again."; // Will only ever be displayed if the test in while does not return true

            } while (!uint.TryParse(inputString, out numberOfGroupMembers));
            errorMsg = ""; // Reset error message. TODO: make a class/functions to handle error messages for cleaner and more readable code.

            Console.WriteLine($"You are adding {numberOfGroupMembers} group members.");

            for (int i = 1; i <= numberOfGroupMembers; i++)
            { // Starting i at 1 to name the group members aptly
                do
                {
                    Console.WriteLine((errorMsg.Length > 0) ? errorMsg : $"Enter the age of visitor {i}:"); // On first run, display instructions. On subsequent runs, display error message
                    errorMsg = ""; // Reset for each try
                    inputString = Console.ReadLine();
                    errorMsg = "Error: Age must be written in digits. Please try again."; // Will only ever be displayed if the test in while does not return true
                } while (!uint.TryParse(inputString, out age));

                // TODO: Add checks for age interval - use the same as in CinemaTicket.
                errorMsg = "";

                AddCinemaVisitor("Visitor " + i, age);
            }

        }

        internal static void AddCinemaVisitor(string name, uint age)
        {
            //CinemaVisitor myVisitor = new CinemaVisitor(name, age);

            //cinemaGroupMembers.Add(myVisitor);
            //Console.WriteLine("A visitor is added with the age " + myVisitor.Age);

            cinemaGroupMembers.Add(new CinemaVisitor(name, age));
        }

        internal static void DisplayCinemaGroupTotal()
        {
            Console.WriteLine("This function will show all the group members and a total price");
            foreach (CinemaVisitor groupMember in cinemaGroupMembers)
            {
                Console.WriteLine($"{groupMember.Name} Age: {groupMember.Age}");
            }
            //    // cinemaGroup.ToArray();
        }
    }
}

