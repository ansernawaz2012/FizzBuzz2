using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz2
{
    class Player
    {
        public string  playerName = "";
        public int playerScore = 0;
        public Player()
        {
            Console.Write("Please enter your name: ");
            playerName = Console.ReadLine();
        }
    }
}
