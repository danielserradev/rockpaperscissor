using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        //member variables(Has A)

        //constructor(Spawner)

        //member methods(Can Do)
        public override void ChooseName()
        {
            Console.WriteLine("Please enter a name for the computer to have.");
            name = Console.ReadLine();
        }
        public override void ChooseMove()
        {
            moves = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            Random compMove = new Random();
            string index = compMove.Next(compMove.Count);
            Console.WriteLine(moves[index]);
        }
    }
}
