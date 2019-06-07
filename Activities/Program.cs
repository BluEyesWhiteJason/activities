using System;

namespace Activities
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greet and take activity input
            Console.WriteLine("Hello user, what are you in the mood for?");
            Console.WriteLine("Here are you options: ");
            Console.WriteLine("1) Action");
            Console.WriteLine("2) Chill Times");
            Console.WriteLine("3) Danger");
            Console.WriteLine("4) Good Food");
            Console.Write("Please enter the number of your selection: ");


            int activity = Convert.ToInt32(Console.ReadLine());

            // If input isn't one of the ones shown, ask again
            while (activity > 4 || activity < 1)
            {
                Console.Write("Please enter one of the listed numbers: ");
                activity = Convert.ToInt32(Console.ReadLine());
            }

            // How many people
            Console.WriteLine("How many people are you bringing with you?");

            int friends = Convert.ToInt32(Console.ReadLine());

            // Check input
            while (friends < 0)
            {
                Console.Write("You can't have negative friends! Please try again: ");
                friends = Convert.ToInt32(Console.ReadLine());
            }

            // Pick the activity
            string strAct = "placeholder";  // Don't know why the switch doesn't affect empty string the same way if/else does
            string sayAct = "placeholder";  // But I wanted to use it so I'm sticking to it
            string transport;
            switch (activity)
            {
                case 1:
                    sayAct = "stock car racing";
                    strAct = "action";
                    break;
                case 2:
                    sayAct = "hiking";
                    strAct = "chill times";
                    break;
                case 3:
                    sayAct = "skydiving";
                    strAct = "danger";
                    break;
                case 4:
                    sayAct = "to Taco Bell";
                    strAct = "good food";
                    break;
            }

            // Pick the transportation
            if (friends == 0)
            {
                transport = "sneakers";
            }
            else if (friends > 0 && friends < 5)
            {
                transport = "a sedan";
            }
            else if (friends > 4 && friends < 11)
            {
                transport = "a Volkswagon Bus";
            }
            else
            {
                transport = "an airplane";
            }

            // The big ol payoff
            Console.WriteLine("Okay, if you’re in the mood for {0}, then you should go {1} \n and travel in {2}!",
                strAct,
                sayAct,
                transport);

            Console.WriteLine("Thank you, Goodbye.");



        }
    }
}
