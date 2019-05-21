using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

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

        //constructor that starts the game
        public Game()
        {
           
            playGame();
        }

        public void playGame()
        {
            
            createPlayers();

            
            countTotal = getCountLimit();

            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak($"Hello and welcome to the fizz buzz game. The players we have are");

            Console.WriteLine($"We have {PlayerList.Count} players. Their names are:");
            for (int i = 0; i < PlayerList.Count; i++)
            {
      
                Console.Write($"{PlayerList[i].playerName} ");
                synth.Speak($"{PlayerList[i].playerName}");

            }

            Console.WriteLine($"The game will end at the number {countTotal}");

            //Loop until end of game reached
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

        //function to allow user to specify at which value the game will end
        private int getCountLimit()
        {
            int gameCountLimit;

            Console.Write("Please enter the total to count up to: ");

            string input = Console.ReadLine();

            while (!Int32.TryParse(input, out gameCountLimit))

            {
                Console.Write
                    ("Invalid input. Please enter a number: ");
                input = Console.ReadLine();
            }

            return gameCountLimit;

           
                }


        //function to create player objects and add to list
        public void createPlayers()
        {
            Console.Write("Enter the number of players: ");


            
            int numberOfPlayers;
            string input = Console.ReadLine();

            //Loop until valid input entered
            while (!Int32.TryParse(input, out numberOfPlayers))
                   
            {
                Console.WriteLine("Invalid input. Please enter a number");
                input = Console.ReadLine();
            }
            
            

            for (int i = 0; i < numberOfPlayers; i++)
            {
                PlayerList.Add(new Player());
            }

        }
    }
}
