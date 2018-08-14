<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest
{

   
    class Player:Mover,ISprite
    {

=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest
{

   
    class Player:Mover,ISprite
    {

>>>>>>> Adding Spear
        private Weapon equippedWeapon;
        private int hitPoints;

        public int HitPoints { get { return hitPoints; } }
        public Size SpriteSize { get; private set; }

        private List<Weapon> inventory = new List<Weapon>();
<<<<<<< HEAD
        public List<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
=======
        public List<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
>>>>>>> Adding Spear
                {
                    names.Add(weapon.Name);
                }
                return names;
            }
<<<<<<< HEAD
        }


        //The player’s constructor sets its hitPoints to 10 and 
        //then calls the base class constructor
        public Player(Game game, Point location,Size spriteSize) :base(game, location)
        {
            this.SpriteSize = spriteSize;
            this.hitPoints = 10;
        }
        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Boundaries);
            //PickedUp bool property

            //To see if any weapons nearby
            if (!game.WeaponInRoom.PickedUp)
            {
                if (Nearby(game.WeaponInRoom.Location,1))
                {
                    //If weapon is the only weapon player has equip immediately.
                    game.WeaponInRoom.PickUpWeapon();
                    inventory.Add(game.WeaponInRoom);
                }
                //Contents coming here!..
            }
        }

        public void Attack(Direction direction,Random random)
        {
            if (equippedWeapon != null)
                equippedWeapon.Attack(direction, random);
        }

        //A Player object can only have one Weapon object equipped at a time.
        public bool CheckPotionUsed(string potionName)
        {
            IPotion potion;
            bool potionUsed = true;

            foreach (Weapon weapon in inventory)
            {
                if (weapon.Name == potionName && weapon is IPotion)
=======
        }


        //The player’s constructor sets its hitPoints to 10 and 
        //then calls the base class constructor
        public Player(Game game, Point location,Size spriteSize) :base(game, location)
        {
            this.SpriteSize = spriteSize;
            this.hitPoints = 10;
        }
        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Boundaries);
            //PickedUp bool property

            //To see if any weapons nearby
            if (!game.WeaponInRoom.PickedUp)
            {
                if (Nearby(game.WeaponInRoom.Location,1))
                {
                    //If weapon is the only weapon player has equip immediately.
                    game.WeaponInRoom.PickUpWeapon();
                    inventory.Add(game.WeaponInRoom);
                }
                //Contents coming here!..
            }
        }

        public void Attack(Direction direction,Random random)
        {
            if (equippedWeapon != null)
                equippedWeapon.Attack(direction, random);
        }

        //A Player object can only have one Weapon object equipped at a time.
        public bool CheckPotionUsed(string potionName)
        {
            IPotion potion;
            bool potionUsed = true;

            foreach (Weapon weapon in inventory)
            {
                if (weapon.Name == potionName && weapon is IPotion)
>>>>>>> Adding Spear
                {
                    potion = weapon as IPotion;
                    potionUsed = potion.Used;
                }
            }

            return potionUsed;
<<<<<<< HEAD
        }
        public void Equip(string weaponName)
        {
            foreach(Weapon weapon in inventory)
            {
                if (weapon.Name == weaponName)
                    equippedWeapon = weapon;
            }
        }


        public void Hit(int maxDamage, Random random)
        {
            hitPoints -= random.Next(1, maxDamage);
        }
        public void IncreaseHealth(int health, Random random)
        {
            hitPoints += random.Next(1, health);
            inventory.Remove(equippedWeapon);
        }
       


    }
}
=======
        }
        public void Equip(string weaponName)
        {
            foreach(Weapon weapon in inventory)
            {
                if (weapon.Name == weaponName)
                    equippedWeapon = weapon;
            }
        }


        public void Hit(int maxDamage, Random random)
        {
            hitPoints -= random.Next(1, maxDamage);
        }
        public void IncreaseHealth(int health, Random random)
        {
            hitPoints += random.Next(1, health);
            inventory.Remove(equippedWeapon);
        }
       


    }
}
>>>>>>> Adding Spear
