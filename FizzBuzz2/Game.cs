using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz2
{
    class Game
    {
        public Boolean gameWon = false;
        public Boolean wrongAnswer = false;
        int countTotal = 0;
        //Create empty list of player objects
        List<Player> PlayerList = new List<Player>();
        public int currentPlayerIndex = 0;

        public Game()
        {
           
            playGame();
        }

        public void playGame()
        {

            createPlayers();

            countTotal = getCountLimit();

            

            Console.WriteLine($"There are {PlayerList.Count} players. {PlayerList[0].playerName} and {PlayerList[1].playerName}");
            Console.WriteLine($"The game will end at the number {countTotal}");

            for (int i = 1; i <= countTotal; i++)
            {
                Console.WriteLine("Choose F for Fizz, B for Buzz, A for Both and N for none.");

                currentPlayerIndex = i % PlayerList.Count;
                

                string rightChoice = "";
                Console.WriteLine($"The number is {i} : {PlayerList[currentPlayerIndex].playerName} make your choice");
                string userInput = Console.ReadLine();

                if (i % 3 == 0 && i % 5 == 0)
                {
                    rightChoice = "a";
                }
                else if (i % 3 == 0)
                {
                    rightChoice = "f";
                }
                else if (i % 5 == 0)
                {
                    rightChoice = "b";
                }
                else
                {
                    rightChoice = "n";
                }

                if (userInput == rightChoice)
                {
                    Console.WriteLine("Correct!");
                    PlayerList[currentPlayerIndex].playerScore++;
                }
                else
                {
                    Console.WriteLine("Wrong!");
                   // wrongAnswer = true;
                   // break;
                }

            }

            
            
                Console.WriteLine("Game over!");

            getFinalScores();
            
        }

        public void getFinalScores()
        {
            for (int i = 0; i < PlayerList.Count; i++)
            {
                Console.WriteLine($"{PlayerList[i].playerName} has scored {PlayerList[i].playerScore} points");
            }
        }

        private int getCountLimit()
        {
            Console.WriteLine("Please enter the total to count up to: ");
            return Convert.ToInt16(Console.ReadLine());
                }

        public void createPlayers()
        {
            Console.Write("Enter the number of players: ");
            int numberOfPlayers = Convert.ToInt16(Console.ReadLine());

            

            for (int i = 0; i < numberOfPlayers; i++)
            {
                PlayerList.Add(new Player());
            }

            //return PlayerList;
        }
    }
}
