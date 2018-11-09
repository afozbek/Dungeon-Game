using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Quest
{
    class Sword:Weapon
    {
        public Sword(Game game, Point point):base(game,point)
        {

        }

        public override string Name { get { return "Sword"; } }

        public override void Attack(Direction direction, Random random)
        {
            //Hepsi bool döner vurabilene kadar döngüye devam eder true almayı bekler..
            if (!DamageEnemy(direction, 15, 3, random))
                if (!DamageEnemy(ClockwiseDirection(direction), 10, 3, random))
                    DamageEnemy(CounterClockWiseDirection(direction), 10, 3, random);
        }
    }
}
