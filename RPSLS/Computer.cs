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
        Random rng;


        //constructor(Spawner)
        public Computer()
        {
            rng =  new  Random();
        }

        //member methods(Can Do)
        public override void ChooseName()
        {
            Console.WriteLine("Please enter a name for the computer to have.");
            name = Console.ReadLine();
        }
        public override void ChooseMove()
        {
            int move = rng.Next(0, moves.Count);
            this.move = moves[move];


            
        }
    }
}
