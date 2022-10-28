using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake
    {


        public int initialPosition = 0;

        public int DiceRoll()
        {
            Random random = new Random();
            int Dicecount = random.Next(1, 7);
            return Dicecount;

        }


    }
}
