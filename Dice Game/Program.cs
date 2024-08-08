using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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

            string res;

            Random random = new Random();
            while (true)
            {
                Console.WriteLine("Press any key to roll the dice or x for exits");
                var key = Console.ReadKey().KeyChar;
                if (key == 'x' || key == 'X')
                {
                    Console.ReadKey();
                    Console.WriteLine("Thanks for using our app.");
                    break;
                }


                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a: " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy rolled a: " + enemyRandomNum);

                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player win this round !");
                }
                else if (enemyRandomNum > enemyPoints)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins this round!");
                }
                else Console.WriteLine("Draw");
                Console.WriteLine("The score is now - Player :" +playerPoints+ ". Enemy: "+enemyPoints +".");
                Console.WriteLine();
                if (playerPoints > enemyPoints)
                {
                    Console.WriteLine("You win!!!");
                }
                else if (playerPoints < enemyPoints)
                {
                    Console.WriteLine("You lose:(");
                }
                else Console.WriteLine("Draw-.-");
            }
            
            Console.ReadKey();
        }
    }
}
