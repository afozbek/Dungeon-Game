using System;
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

        private int level = 0;
        public int Level { get { return level; } }

        private Rectangle boundaries;
        public Rectangle Boundaries { get { return boundaries; } }

        public void NewLevel(Random random)
        {
            level++;
            switch (level)
            {
                case 1:

                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this , GetRandomLocation(random) , new Size(30 , 30)));
                    WeaponInRoom = new Sword(this , GetRandomLocation(random));
                    break;
                case 2:
                    Enemies.Clear();
                    Enemies.Add(new Ghost(this , GetRandomLocation(random) , new Size(30 , 30)));
                    WeaponInRoom = new BluePotion(this , GetRandomLocation(random));
                    break;
                case 3:
                    Enemies.Clear();
                    Enemies.Add(new Ghoul(this , GetRandomLocation(random) , new Size(30 , 30)));
                    WeaponInRoom = new Bow(this , GetRandomLocation(random));
                    break;
                case 4:
                    Enemies.Clear();
                    Enemies.Add(new Bat(this , GetRandomLocation(random) , new Size(30 , 30)));
                    Enemies.Add(new Ghost(this , GetRandomLocation(random) , new Size(30 , 30)));
                    WeaponInRoom = null;
                    if (CheckPlayerInventory("Bow"))
                    {
                        if (!CheckPlayerInventory("Blue Potion")
                                || (CheckPlayerInventory("Blue Potion")
                                    && CheckPotionUsed("Blue Potion")))
                        {
                            WeaponInRoom = new BluePotion(this , GetRandomLocation(random));
                        }
                    }
                    else
                    {
                        WeaponInRoom = new Bow(this , GetRandomLocation(random));
                    }
                    break;
                //Bonus level!..
                case 5:
                    Enemies.Clear();
                    WeaponInRoom = new Spear(this , GetRandomLocation(random));
                    break;

                case 6:
                    Enemies.Clear();
                    Enemies.Add(new Bat(this , GetRandomLocation(random) , new Size(30 , 30)));
                    Enemies.Add(new Ghoul(this , GetRandomLocation(random) , new Size(30 , 30)));
                    WeaponInRoom = new RedPotion(this , GetRandomLocation(random));
                    break;
                case 7:
                    Enemies.Clear();
                    Enemies.Add(new Ghost(this , GetRandomLocation(random) , new Size(30 , 30)));
                    Enemies.Add(new Ghoul(this , GetRandomLocation(random) , new Size(30 , 30)));
                    WeaponInRoom = new Mace(this , GetRandomLocation(random));
                    break;
                case 8:
                    Enemies.Clear();
                    Enemies.Add(new Bat(this , GetRandomLocation(random) , new Size(30 , 30)));
                    Enemies.Add(new Ghost(this , GetRandomLocation(random) , new Size(30 , 30)));
                    Enemies.Add(new Ghoul(this , GetRandomLocation(random) , new Size(30 , 30)));
                    WeaponInRoom = null;
                    if (CheckPlayerInventory("Mace"))
                    {
                        if (!CheckPlayerInventory("Red Potion")
                                || (CheckPlayerInventory("Red Potion")
                                    && CheckPotionUsed("Red Potion")))
                        {
                            WeaponInRoom = new RedPotion(this , GetRandomLocation(random));
                        }
                    }
                    else
                    {
                        WeaponInRoom = new Mace(this , GetRandomLocation(random));
                    }
                    break;
                case 9:
                    Application.Exit();
                    break;
            }
        }
        //First let the player move then let the enemies move
        //First we call our Player's Move then foreach loop throug all 
        //existing enemies..

        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            player = new Player(this ,
                new Point(boundaries.Left + 10 , boundaries.Top + 70) ,
                new Size(30 , 30));
        }

        public void Move(Direction direction , Random random)
        {
            player.Move(direction);
            foreach (Enemy enemy in Enemies)
            {
                enemy.Move(random);
            }
        }

        public void Equip(string weaponName)
        {
            player.Equip(weaponName);
        }

        public bool CheckPlayerInventory(string weaponName)
        {
            return player.Weapons.Contains(weaponName);
        }

        public bool CheckPotionUsed(string potionName)
        {
            return player.CheckPotionUsed(potionName);
        }

        public void HitPlayer(int maxDamage , Random random)
        {
            player.Hit(maxDamage , random);
        }

        public void IncreasePlayerHealth(int health , Random random)
        {
            player.IncreaseHealth(health , random);

        }

        public void Attack(Direction direction , Random random)
        {
            player.Attack(direction , random);
            foreach (Enemy enemy in Enemies)
            {
                if (!enemy.Dead)
                {
                    enemy.Move(random);
                }
            }
        }




        public Point GetRandomLocation(Random random)
        {
            // This is just a math trick to get a random
            // location within the rectangle that represents the dungeon area.

            return new Point(
                boundaries.Left
                    + random.Next(boundaries.Right / 10 - boundaries.Left / 10)
                    * 10 ,
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
