using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //member variables(Has A)
        public Player playerOne;
        public Player playerTwo;
        public string desicion = "";
        public int playerOneScore = 0;
        public int playerTwoScore = 0;
        public int numberOfPlayers;
        public string choice;
        
        //constructor(Spawner)
        public Game()
        {


        }

        //member methods(Can Do)
        public void RunGame()
        {
            DisplayRules();
            int numberOfPlayers = GetNumberOfPlayers();
            CreatePlayers(numberOfPlayers);
            playerOne.ChooseName();
            playerTwo.ChooseName();
            PlayUntilWinner();       

        }
        
        public void DisplayRules()
        {
            Console.WriteLine("Each player chooses between Rock, Paper, Scissor, Lizard, or Spock \n \n" +
                " Rock crushes Scissors \n Scissors cuts Paper \n Paper covers Rock \n Rock crushes Lizard \n Lizard poisons Spock " +
                "\n Spock smashes Scissors \n Scissors decapitates Lizard \n Lizard eats Paper \n Paper disproves Spock  \n Spock vaporizes rock" +
                " \n \n This game is best of 3. \n \n ");
        }
        public int GetNumberOfPlayers()
        {
            Console.WriteLine("Are 1 or 2 players playing?");
            try
            {
            numberOfPlayers = int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Error: Must enter an integer");
            }
            switch (numberOfPlayers)
            {
                case 1:
                    numberOfPlayers = 1;
                    break;
                case 2:
                    numberOfPlayers = 2;
                    break;
                default:
                    GetNumberOfPlayers();
                    break;
            }
            return numberOfPlayers;
        }
        public void CreatePlayers(int numberOfPlayers)
        {
            
            if(numberOfPlayers == 1)
            {
                playerOne = new Human();
                playerTwo = new Computer();
            }
            else if(numberOfPlayers == 2)
            {
                playerOne = new Human();
                playerTwo = new Human();
            }
            else
            {
                Console.WriteLine("Error: Please enter '1' or '2'.");

            }

        }
        public void GameLogic()
        {
            
            if(playerOne.move == playerTwo.move)
            {
                desicion = "tie";
                Console.WriteLine("We have a " + desicion);
            }
            else if(playerOne.move == "Rock" && playerTwo.move == "Paper")
            {
                desicion = "Paper";
                Console.WriteLine(playerTwo.name + " covers " + playerOne.name + "'s " + playerOne.move + " with " + desicion);
            }
            else if (playerOne.move == "Rock" && playerTwo.move == "Spock")
            {
                desicion = "Spock";
                Console.WriteLine(playerTwo.name + " vaporizes " + playerOne.name + "'s " + playerOne.move + " with " + desicion);
            }
            else if (playerOne.move == "Rock" && playerTwo.move == "Scissors")
            {
                desicion = "Rock";
                Console.WriteLine(playerOne.name + " crushes " + playerTwo.name + "'s " + playerTwo.move + " with " + desicion);
            }
            else if (playerOne.move == "Rock" && playerTwo.move == "Lizard")
            {
                desicion = "Rock";
                Console.WriteLine(playerOne.name + " crushes " + playerTwo.name + "'s " + playerTwo.move + " with " + desicion);
            }
            //-------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------
            else if (playerOne.move == "Scissors" && playerTwo.move == "Rock")
            {
                desicion = "Paper";
                Console.WriteLine(playerTwo.name + " crushes " + playerOne.name + "'s " + playerOne.move + " with " + desicion);
            }
            else if (playerOne.move == "Scissors" && playerTwo.move == "Spock")
            {
                desicion = "Spock";
                Console.WriteLine(playerTwo.name + " smashes " + playerOne.name + "'s " + playerOne.move + " with " + desicion);
            }
            else if (playerOne.move == "Scissors" && playerTwo.move == "Paper")
            {
                desicion = "Scissors";
                Console.WriteLine(playerOne.name + " cuts " + playerTwo.name + "'s " + playerTwo.move + " with " + desicion);
            }
            else if (playerOne.move == "Scissors" && playerTwo.move == "Lizard")
            {
                desicion = "Scissors";
                Console.WriteLine(playerOne.name + " decapitates " + playerTwo.name + "'s " + playerTwo.move + " with " + desicion);
            }
            //-------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------
            else if (playerOne.move == "Paper" && playerTwo.move == "Scissors")
            {
                desicion = "Scissors";
                Console.WriteLine(playerTwo.name + " cuts " + playerOne.name + "'s " + playerOne.move + " with " + desicion);
            }
            else if (playerOne.move == "Paper" && playerTwo.move == "Lizard")
            {
                desicion = "Lizard";
                Console.WriteLine(playerTwo.name + " eats " + playerOne.name + "'s " + playerOne.move + " with " + desicion);
            }
            else if (playerOne.move == "Paper" && playerTwo.move == "Rock")
            {
                desicion = "Paper";
                Console.WriteLine(playerOne.name + " covers " + playerTwo.name + "'s " + playerTwo.move + " with " + desicion);
            }
            else if (playerOne.move == "Paper" && playerTwo.move == "Spock")
            {
                desicion = "Paper";
                Console.WriteLine(playerOne.name + " disproves " + playerTwo.name + "'s " + playerTwo.move + " with " + desicion);
            }
            //-------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------
            else if (playerOne.move == "Lizard" && playerTwo.move == "Rock")
            {
                desicion = "Rock";
                Console.WriteLine(playerTwo.name + " crushes " + playerOne.name + "'s " + playerOne.move + " with " + desicion);
            }
            else if (playerOne.move == "Lizard" && playerTwo.move == "Scissors")
            {
                desicion = "Scissors";
                Console.WriteLine(playerTwo.name + " decapitates " + playerOne.name + "'s " + playerOne.move + " with " + desicion);
            }
            else if (playerOne.move == "Lizard" && playerTwo.move == "Paper")
            {
                desicion = "Lizard";
                Console.WriteLine(playerOne.name + " eats " + playerTwo.name + "'s " + playerTwo.move + " with " + desicion);
            }
            else if (playerOne.move == "Lizard" && playerTwo.move == "Spock")
            {
                desicion = "Lizard";
                Console.WriteLine(playerOne.name + " poisons " + playerTwo.name + "'s " + playerTwo.move + " with " + desicion);
            }
            //-------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------
            else if (playerOne.move == "Spock" && playerTwo.move == "Lizard")
            {
                desicion = "Lizard";
                Console.WriteLine(playerTwo.name + " poisons " + playerOne.name + "'s " + playerOne.move + " with " + desicion);
            }
            else if (playerOne.move == "Spock" && playerTwo.move == "Paper")
            {
                desicion = "Scissors";
                Console.WriteLine(playerTwo.name + " disporves " + playerOne.name + "'s " + playerOne.move + " with " + desicion);
            }
            else if (playerOne.move == "Spock" && playerTwo.move == "Rock")
            {
                desicion = "Spock";
                Console.WriteLine(playerOne.name + " vaporizes " + playerTwo.name + "'s " + playerTwo.move + " with " + desicion);
            }
            else if (playerOne.move == "Spock" && playerTwo.move == "Scissors")
            {
                desicion = "Spock";
                Console.WriteLine(playerOne.name + " smashes " + playerTwo.name + "'s " + playerTwo.move + " with " + desicion);
            }
            //-------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------




        }
        public void PlayUntilWinner()
        {
            do
            {
                playerOne.ChooseMove();
                playerTwo.ChooseMove();
                GameLogic();
                CheckForWinner();
                
            }
            while (playerOneScore < 3 && playerTwoScore < 3);

        }
        
        public void CheckForWinner()
        {
            if(playerOne.move == playerTwo.move)
            {
                playerOneScore = playerOneScore;
                playerTwoScore = playerTwoScore;
            }                      
            else if (playerOne.move == desicion)
            {
                playerOneScore++;
                Console.WriteLine(playerOne.name + " has a score of " + playerOneScore);
                if (playerOneScore == 3)
                    Console.WriteLine(playerOne.name + " WINS!");
            }
            else
            {
                playerTwoScore++;
                Console.WriteLine(playerTwo.name + " has a score of " + playerTwoScore);
                if (playerTwoScore == 3)
                    Console.WriteLine(playerTwo.name + " WINS!");
            }
        }
    }
}
