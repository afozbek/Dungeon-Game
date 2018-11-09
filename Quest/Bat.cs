using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest
{
    class Bat:Enemy
    {
        //We dont need to add anything in constuctor base class handles it
        //Bat's hit points 6
        public Bat(Game game, Point location,Size spriteSize) :
            base(game, location, 6, spriteSize) { }

        public override void Move(Random random)
        {
            //Chance 1/2 -->Towards the player
            if (random.Next(1, 4) ==1 )

                location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            else
                location = Move((Direction)random.Next(1, 4), game.Boundaries);

            //If it is near player it will hit player.
            if (NearPlayer())
                game.HitPlayer(1, random);

        }

    }
}
