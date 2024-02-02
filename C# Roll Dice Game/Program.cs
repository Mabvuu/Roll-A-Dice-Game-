using System;


namespace Dice_Game
{
    internal class Program
        
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();


            for (int i  = 0; i < 10; i++)
            {

                Console.WriteLine("Press any key to roll the dice");

                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine(" You rolled a " + playerRandomNum);

                Console.WriteLine("....");
                System.Threading.Thread.Sleep(1000); //It  poses for 1000ms also 1second before generating the Opponent's number

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Opponent  rolled a " + enemyRandomNum);

                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoints++; //++ means player will score a point
                    Console.WriteLine("Player wins this round!");
                }
                else if(playerRandomNum < enemyRandomNum)
                {
                    enemyPoints++; //meaning enemy will score a point
                    Console.WriteLine("Opponent wins this round");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }

                Console.WriteLine("The score is now - Player : " + playerPoints + ". Opponent : " + enemyPoints + " . ");
                    Console.WriteLine("");
            }

            if(playerPoints > enemyPoints)
            {
                Console.WriteLine("You Win!");
            }
            else if(playerPoints < enemyPoints)
            {
                Console.WriteLine("Opponent wins! You Loser!");
            }
            else { Console.WriteLine("It's a Draw"); }

            Console.ReadKey();

           


        }

    }
}
