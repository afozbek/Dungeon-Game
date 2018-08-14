<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest
{
    class BluePotion:Weapon,IPotion
    {
        public BluePotion(Game game, Point location) : base(game, location)
        {
            Used = false;
        }

        public override string Name { get { return "Blue Potion"; } }

        public bool Used { get; private set; }


        //Increase the health (Override method) up to 10 health..
        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(5, random);
            Used = true;
            
          //Increase people health...
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest
{
    class BluePotion:Weapon,IPotion
    {
        public BluePotion(Game game, Point location) : base(game, location)
        {
            Used = false;
        }

        public override string Name { get { return "Blue Potion"; } }

        public bool Used { get; private set; }


        //Increase the health (Override method) up to 10 health..
        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(5, random);
            Used = true;
            
          //Increase people health...
        }
    }
}
>>>>>>> Adding Spear
