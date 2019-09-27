using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        //member variables(Has A)

        //constructor(Spawner)

        //member methods(Can Do)
        public override void ChooseName()
        {
            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();
        }
        public override void ChooseMove()
        {
            Console.WriteLine("Please enter the number that corrisponds with move you would like to choose.");
            Console.WriteLine(" 1. Rock \n 2. Paper \n 3. Scissors \n 4. Lizard \n 5. Spock");
            move = Console.ReadLine();

            switch (move)
            {
                case "1":
                    move = "Rock";
                    //Console.WriteLine(name + "'s move is " + move);
                    break;
                case "2":
                    move = "Paper";
                    //Console.WriteLine(name + "'s move is " + move);
                    break;
                case "3":
                    move = "Scissors";
                    //Console.WriteLine(name + "'s move is " + move);
                    break;
                case "4":
                    move = "Lizard";
                    //Console.WriteLine(name + "'s move is " + move);
                    break;
                case "5":
                    move = "Spock";
                    //Console.WriteLine(name + "'s move is " + move);
                    break;
                default:
                    ChooseMove();
                    break;

            }
        }
    }
}
