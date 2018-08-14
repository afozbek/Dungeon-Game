<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Quest
{
    public class Game
    {
        
        public List<Enemy> Enemies;
        public Weapon WeaponInRoom;

        private Player player;
        public Size PlayerSpriteSize { get { return player.SpriteSize; } }
        public Point PlayerLocation { get { return player.Location; } }
        public int PlayerHitPoints { get { return player.HitPoints; } }
        public List<string> PlayerWeapons { get { return player.Weapons; } }

        private int level =0 ;
        public int Level { get { return level; } }

        private Rectangle boundaries;
        public Rectangle Boundaries { get { return boundaries; } }

        public void NewLevel(Random random)
        {
            level++;
            switch (level)
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Quest
{
    public class Game
    {
        
        public List<Enemy> Enemies;
        public Weapon WeaponInRoom;

        private Player player;
        public Size PlayerSpriteSize { get { return player.SpriteSize; } }
        public Point PlayerLocation { get { return player.Location; } }
        public int PlayerHitPoints { get { return player.HitPoints; } }
        public List<string> PlayerWeapons { get { return player.Weapons; } }

        private int level =0 ;
        public int Level { get { return level; } }

        private Rectangle boundaries;
        public Rectangle Boundaries { get { return boundaries; } }

        public void NewLevel(Random random)
        {
            level++;
            switch (level)
>>>>>>> Adding Spear
            {
                case 1:

                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random), new Size(30, 30)));
                    WeaponInRoom = new Sword(this, GetRandomLocation(random));
                    break;
                case 2:
                    Enemies.Clear();
                    Enemies.Add(new Ghost(this, GetRandomLocation(random), new Size(30, 30)));
                    WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    break;
                case 3:
                    Enemies.Clear();
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random), new Size(30, 30)));
                    WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    break;
                case 4:
                    Enemies.Clear();
                    Enemies.Add(new Bat(this, GetRandomLocation(random), new Size(30, 30)));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random), new Size(30, 30)));
                    WeaponInRoom = null;
<<<<<<< HEAD
                    if (CheckPlayerInventory("Bow"))
                    {
                        if (!CheckPlayerInventory("Blue Potion")
                                || (CheckPlayerInventory("Blue Potion")
                                    && CheckPotionUsed("Blue Potion")))
                        {
                            WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                        }
                    }
                    else
=======
                    if (CheckPlayerInventory("Bow"))
                    {
                        if (!CheckPlayerInventory("Blue Potion")
                                || (CheckPlayerInventory("Blue Potion")
                                    && CheckPotionUsed("Blue Potion")))
                        {
                            WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                        }
                    }
                    else
>>>>>>> Adding Spear
                    {
                        WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    }
                    break;
<<<<<<< HEAD
                case 5:
                    Enemies.Clear();
=======
                //Bonus level!..
                case 5:
                    Enemies.Clear();
                    WeaponInRoom = new Spear(this, GetRandomLocation(random));
                    break;

                case 6:
                    Enemies.Clear();
>>>>>>> Adding Spear
                    Enemies.Add(new Bat(this, GetRandomLocation(random), new Size(30, 30)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random), new Size(30, 30)));
                    WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    break;
<<<<<<< HEAD
                case 6:
=======
                case 7:
>>>>>>> Adding Spear
                    Enemies.Clear();
                    Enemies.Add(new Ghost(this, GetRandomLocation(random), new Size(30, 30)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random), new Size(30, 30)));
                    WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    break;
<<<<<<< HEAD
                case 7:
=======
                case 8:
>>>>>>> Adding Spear
                    Enemies.Clear();
                    Enemies.Add(new Bat(this, GetRandomLocation(random), new Size(30, 30)));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random), new Size(30, 30)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random), new Size(30, 30)));
                    WeaponInRoom = null;
<<<<<<< HEAD
                    if (CheckPlayerInventory("Mace"))
                    {
                        if (!CheckPlayerInventory("Red Potion")
                                || (CheckPlayerInventory("Red Potion")
                                    && CheckPotionUsed("Red Potion")))
                        {
                            WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                        }
                    }
                    else
=======
                    if (CheckPlayerInventory("Mace"))
                    {
                        if (!CheckPlayerInventory("Red Potion")
                                || (CheckPlayerInventory("Red Potion")
                                    && CheckPotionUsed("Red Potion")))
                        {
                            WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                        }
                    }
                    else
>>>>>>> Adding Spear
                    {
                        WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    }
                    break;
<<<<<<< HEAD
                case 8:
                    Application.Exit();
                    break;
            }
        }

        //First let the player move then let the enemies move
        //First we call our Player's Move then foreach loop throug all 
        //existing enemies..


        public Game(Rectangle boundaries)
=======
                case 9:
                    Application.Exit();
                    break;
            }
        }

        //First let the player move then let the enemies move
        //First we call our Player's Move then foreach loop throug all 
        //existing enemies..


        public Game(Rectangle boundaries)
>>>>>>> Adding Spear
        {
            this.boundaries = boundaries;
            player = new Player(this,
                new Point(boundaries.Left + 10, boundaries.Top + 70),
                new Size(30, 30));
        }

<<<<<<< HEAD
        public void Move(Direction direction, Random random)
        {
            player.Move(direction);
            foreach (Enemy enemy in Enemies)
=======
        public void Move(Direction direction, Random random)
        {
            player.Move(direction);
            foreach (Enemy enemy in Enemies)
>>>>>>> Adding Spear
            {
                enemy.Move(random);
            }
        }

<<<<<<< HEAD
        public void Equip(string weaponName)
=======
        public void Equip(string weaponName)
>>>>>>> Adding Spear
        {
            player.Equip(weaponName);
        }

<<<<<<< HEAD
        public bool CheckPlayerInventory(string weaponName)
=======
        public bool CheckPlayerInventory(string weaponName)
>>>>>>> Adding Spear
        {
            return player.Weapons.Contains(weaponName);
        }

<<<<<<< HEAD
        public bool CheckPotionUsed(string potionName)
=======
        public bool CheckPotionUsed(string potionName)
>>>>>>> Adding Spear
        {
            return player.CheckPotionUsed(potionName);
        }

<<<<<<< HEAD
        public void HitPlayer(int maxDamage, Random random)
=======
        public void HitPlayer(int maxDamage, Random random)
>>>>>>> Adding Spear
        {
            player.Hit(maxDamage, random);
        }

<<<<<<< HEAD
        public void IncreasePlayerHealth(int health, Random random)
=======
        public void IncreasePlayerHealth(int health, Random random)
>>>>>>> Adding Spear
        {
            player.IncreaseHealth(health, random);
           
        }

<<<<<<< HEAD
        public void Attack(Direction direction, Random random)
        {
            player.Attack(direction, random);
            foreach (Enemy enemy in Enemies)
            {
                if (!enemy.Dead)
=======
        public void Attack(Direction direction, Random random)
        {
            player.Attack(direction, random);
            foreach (Enemy enemy in Enemies)
            {
                if (!enemy.Dead)
>>>>>>> Adding Spear
                {
                    enemy.Move(random);
                }
            }
        }

<<<<<<< HEAD
        


        public Point GetRandomLocation(Random random)
        {
            // This is just a math trick to get a random
            // location within the rectangle that represents the dungeon area.

            return new Point(
                boundaries.Left
                    + random.Next(boundaries.Right / 10 - boundaries.Left / 10)
                    * 10,
                boundaries.Top
                    + random.Next(boundaries.Bottom / 10 - boundaries.Top / 10)
                    * 10)
                    ;
        }

    }
    public enum Direction
    {
        Left, Right, Up, Down
    }
}
=======
        


        public Point GetRandomLocation(Random random)
        {
            // This is just a math trick to get a random
            // location within the rectangle that represents the dungeon area.

            return new Point(
                boundaries.Left
                    + random.Next(boundaries.Right / 10 - boundaries.Left / 10)
                    * 10,
                boundaries.Top
                    + random.Next(boundaries.Bottom / 10 - boundaries.Top / 10)
                    * 10)
                    ;
        }

    }
    public enum Direction
    {
        Left, Right, Up, Down
    }
}
>>>>>>> Adding Spear
