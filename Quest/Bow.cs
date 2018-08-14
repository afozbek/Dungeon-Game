<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest
{
    class Bow:Weapon
    {
        public Bow(Game game, Point point) : base(game, point)
        {

        }

        public override string Name { get { return "Bow"; } }

        public override void Attack(Direction direction, Random random)
        {
            DamageWithBow(direction, 200, 1, random);
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
    class Bow:Weapon
    {
        public Bow(Game game, Point point) : base(game, point)
        {

        }

        public override string Name { get { return "Bow"; } }

        public override void Attack(Direction direction, Random random)
        {
            DamageWithBow(direction, 200, 1, random);
        }


    }
}
>>>>>>> Adding Spear
