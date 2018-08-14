<<<<<<< HEAD
﻿using System;
using System.Drawing;

namespace Quest
{
    internal class RedPotion : Weapon,IPotion
    {
        public RedPotion(Game game,Point location) : base(game, location)
        {
            Used = false;
        }

        public override string Name { get { return "Red Potion"; } }

        public bool Used { get; private set; }


        //Increase the health (Override method) up to 10 health..
        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(10, random);
            Used = true;
        }
    }
=======
﻿using System;
using System.Drawing;

namespace Quest
{
    internal class RedPotion : Weapon,IPotion
    {
        public RedPotion(Game game,Point location) : base(game, location)
        {
            Used = false;
        }

        public override string Name { get { return "Red Potion"; } }

        public bool Used { get; private set; }


        //Increase the health (Override method) up to 10 health..
        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(10, random);
            Used = true;
        }
    }
>>>>>>> Adding Spear
}