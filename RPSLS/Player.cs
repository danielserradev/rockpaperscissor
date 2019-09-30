using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        //member variables(Has A)
        public string name;        
        public string move;
        public int score;
        public List<string> moves;
        //constructor(Spawner)
        public Player()
        {
            moves = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

        }

        //member methods(Can Do)
        public abstract void ChooseMove();

        public abstract void ChooseName();

        
    }
}
