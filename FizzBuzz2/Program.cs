using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz2
{
    class Program
    {
        static void Main(string[] args)
        {
         /*   Console.Write("Enter the number of players: ");
            int numberOfPlayers = Convert.ToInt16(Console.ReadLine());

            //Create empty list of player objects
            List<Player> PlayerList = new List<Player>();

            for (int i = 0; i < numberOfPlayers; i++)
            {
                PlayerList.Add(new Player());
            }

            Console.WriteLine($"There are {PlayerList.Count} players. {PlayerList[0].playerName} and {PlayerList[1].playerName}");

    */

            Game newGame = new Game();

            Console.ReadLine();
        }
    }
}
