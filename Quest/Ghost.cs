using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest
{
    class Ghost:Enemy
    {
        public Ghost(Game game, Point location,Size size) : 
            base(game, location, 8, size) { }
        public override void Move(Random random)
        {
            //Chance 1/3 -->Towards the player
            if (random.Next(1, 3) == 1)
            {
                location = Move(FindPlayerDirection
    (game.PlayerLocation), game.Boundaries);
            }
          
             
            if (NearPlayer())
                game.HitPlayer(2, random);

        }


    }
}
