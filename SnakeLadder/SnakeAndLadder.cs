using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    class SnakeAndLadder
    {

        // Declaring and initializing the global constants
        public const int NO_PLAY = 0;
        public const int LADDER = 1;
        public const int SNAKE = 2;
        static void Main(string[] args)
        {
            // UC-1 Snake and Ladder game plated with a single player at start position 0
            int diceResult = 0;
            int count = 0;
            int diceCheckRequired = 0;

            // UC-4 Repeating the task till the player reaches a winning value of 100
            while (diceResult < 100)
            {

                // UC-2 Using a Random function to get a number between 1 and 6
                Random random = new Random();
                int diceCheck = random.Next(1, 7);
                Console.WriteLine("The dice value = " + diceCheck);
                Random random1 = new Random();
                int option = random1.Next(0, 3);

                // UC-3 To check for an option for a No Play, Ladder or a Snake and then change the value of diceResult accordingly.
                switch (option)
                {
                    case LADDER:

                        // UC-5 To ensure that the player reaches an exact winning value of 100
                        diceResult = diceResult + diceCheck;
                        if (diceResult > 100)
                        {
                            diceCheckRequired = 100 - (diceResult - diceCheck);
                            diceResult = diceResult - diceCheck;
                        }
                        if (diceResult < 100)
                        {
                            diceResult = diceResult + diceCheckRequired;
                        }
                        break;
                    case SNAKE:
                        diceResult = diceResult - diceCheck;
                        break;
                    default:
                        break;
                }
                if (diceResult < 0)
                {
                    diceResult = 0;
                }

                // UC-6 Printing the new position of the player after every iteration
                Console.WriteLine("The player is now at position " + diceResult);
                count++;
            }

            // UC-6 Printing the final count of the number of times the dice was thrown
            Console.WriteLine("The number of times the dice was thrown: " + count);
            Console.ReadLine();
            //}
        }
    }
}
