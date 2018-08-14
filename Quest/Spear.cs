using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest
{
  
        class Spear : Weapon
        {
            //More range but decreased damage..
            public Spear(Game game, Point location) : base(game, location)
            {

            }

            public override string Name { get { return "Spear"; } }

            //Like sword the player can attack in two directions 
            public override void Attack(Direction direction, Random random)
            {
                if (!DamageEnemy(direction, 25, 2, random))
                    if (!DamageEnemy(CounterClockWiseDirection(direction), 25, 2, random))
                        DamageEnemy(ClockwiseDirection(direction), 25, 2, random);


            }
        }
    
}
