<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest
{
   public  abstract class Weapon:Mover
    {
        
        private bool pickedUp;
        public bool PickedUp
        {
            get { return pickedUp; }
        }
       
        public Weapon(Game game, Point location):
            base(game,location)
        {
            this.game = game;
            this.location = location;
            pickedUp = false;
        }
        public void PickUpWeapon() { pickedUp = true; }

        public abstract string Name { get; }

        public abstract void Attack(Direction direction, Random random);

        //Damage Nearby enemy..
                
        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            Point playerLocation = game.PlayerLocation;
            foreach (Enemy enemy in game.Enemies)
            {
                if (!enemy.Dead && Nearby(playerLocation,enemy, direction, radius))
=======
﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest
{
   public  abstract class Weapon:Mover
    {
        
        private bool pickedUp;
        public bool PickedUp
        {
            get { return pickedUp; }
        }
       
        public Weapon(Game game, Point location):
            base(game,location)
        {
            this.game = game;
            this.location = location;
            pickedUp = false;
        }
        public void PickUpWeapon() { pickedUp = true; }

        public abstract string Name { get; }

        public abstract void Attack(Direction direction, Random random);

        //Damage Nearby enemy..
                
        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            Point playerLocation = game.PlayerLocation;
            foreach (Enemy enemy in game.Enemies)
            {
                if (!enemy.Dead && Nearby(playerLocation,enemy, direction, radius))
>>>>>>> Adding Spear
                {
                    enemy.Hit(damage, random);
                    return true;
                }
<<<<<<< HEAD
            }
            return false;
        }
       protected bool DamageWithBow(Direction direction, int radius, int damage, Random random)
        {
            Point playerLocation = game.PlayerLocation;
            foreach (Enemy enemy in game.Enemies)
            {
                if (!enemy.Dead && Nearby(playerLocation, enemy.Location,direction, radius))
=======
            }
            return false;
        }
       protected bool DamageWithBow(Direction direction, int radius, int damage, Random random)
        {
            Point playerLocation = game.PlayerLocation;
            foreach (Enemy enemy in game.Enemies)
            {
                if (!enemy.Dead && Nearby(playerLocation, enemy.Location,direction, radius))
>>>>>>> Adding Spear
                {
                    enemy.Hit(damage, random);
                    return true;
                }
<<<<<<< HEAD
            }
            return false;
        }
        public bool Nearby(Point playerLocation, Point enemyLocation,Direction direction, int distance)
        {
            bool isNearby = false;
          

            switch (direction)
            {
                case Direction.Up:
                   if(playerLocation.X==enemyLocation.X
                        && enemyLocation.Y- playerLocation.Y <=distance)
                    {
                        isNearby = true;
=======
            }
            return false;
        }
        public bool Nearby(Point playerLocation, Point enemyLocation,Direction direction, int distance)
        {
            bool isNearby = false;
          

            switch (direction)
            {
                case Direction.Up:
                   if(playerLocation.X==enemyLocation.X
                        && enemyLocation.Y- playerLocation.Y <=distance)
                    {
                        isNearby = true;
>>>>>>> Adding Spear
                    }
                    

                    break;

<<<<<<< HEAD
                case Direction.Right:
                    if (playerLocation.Y == enemyLocation.Y
                         && enemyLocation.X - playerLocation.X <= distance)
                    {
                        isNearby = true;
                    }
                    break;

                case Direction.Down:
                    if (playerLocation.X == enemyLocation.X
                         && playerLocation.Y - enemyLocation.Y <= distance)
                    {
                        isNearby = true;
                    }
                    break;

                case Direction.Left:
                    if (playerLocation.Y == enemyLocation.Y
                          && playerLocation.X - enemyLocation.X <= distance)
                    {
                        isNearby = true;
=======
                case Direction.Right:
                    if (playerLocation.Y == enemyLocation.Y
                         && enemyLocation.X - playerLocation.X <= distance)
                    {
                        isNearby = true;
                    }
                    break;

                case Direction.Down:
                    if (playerLocation.X == enemyLocation.X
                         && playerLocation.Y - enemyLocation.Y <= distance)
                    {
                        isNearby = true;
                    }
                    break;

                case Direction.Left:
                    if (playerLocation.Y == enemyLocation.Y
                          && playerLocation.X - enemyLocation.X <= distance)
                    {
                        isNearby = true;
>>>>>>> Adding Spear
                    }
                    break;

            }

          

<<<<<<< HEAD
            return isNearby;


        }


        //To check if any enemy is nearby ->>true if nearby..
        private bool Nearby(Point playerLocation, Enemy enemy,Direction direction,int distance)
        {
=======
            return isNearby;


        }


        //To check if any enemy is nearby ->>true if nearby..
        private bool Nearby(Point playerLocation, Enemy enemy,Direction direction,int distance)
        {
>>>>>>> Adding Spear
            bool isNearby = false;
            Rectangle enemySpriteBoundary = new Rectangle(enemy.Location, enemy.SpriteSize);
            Rectangle playerAttackArea = new Rectangle();

<<<<<<< HEAD
            switch (direction)
            {
                case Direction.Up:
                    playerAttackArea.Location = new Point(playerLocation.X,
                                                          playerLocation.Y
=======
            switch (direction)
            {
                case Direction.Up:
                    playerAttackArea.Location = new Point(playerLocation.X,
                                                          playerLocation.Y
>>>>>>> Adding Spear
                                                            - distance);
                    playerAttackArea.Width = game.PlayerSpriteSize.Width;
                    playerAttackArea.Height = distance;
                    break;

                case Direction.Right:
<<<<<<< HEAD
                    playerAttackArea.Location = new Point(playerLocation.X
=======
                    playerAttackArea.Location = new Point(playerLocation.X
>>>>>>> Adding Spear
                                                            + game.PlayerSpriteSize.Width,
                                                          playerLocation.Y);
                    playerAttackArea.Width = distance;
                    playerAttackArea.Height = game.PlayerSpriteSize.Height;
                    break;

                case Direction.Down:
                    playerAttackArea.Location = new Point(playerLocation.X,
<<<<<<< HEAD
                                                          playerLocation.Y
=======
                                                          playerLocation.Y
>>>>>>> Adding Spear
                                                            + game.PlayerSpriteSize.Height);
                    playerAttackArea.Width = game.PlayerSpriteSize.Width;
                    playerAttackArea.Height = distance;
                    break;

                case Direction.Left:
<<<<<<< HEAD
                    playerAttackArea.Location = new Point(playerLocation.X
=======
                    playerAttackArea.Location = new Point(playerLocation.X
>>>>>>> Adding Spear
                                                            + distance,
                                                          playerLocation.Y);
                    playerAttackArea.Width = distance;
                    playerAttackArea.Height = game.PlayerSpriteSize.Height;
                    break;

            }

<<<<<<< HEAD
            if (playerAttackArea.IntersectsWith(enemySpriteBoundary))
=======
            if (playerAttackArea.IntersectsWith(enemySpriteBoundary))
>>>>>>> Adding Spear
            {
                isNearby = true;
            }

<<<<<<< HEAD
            return isNearby;
        }
      


        //Maybe some Direction methods..
        //Saat yönünde.
        protected Direction ClockwiseDirection(Direction direction)
        {
            Direction clockWiseDirection = direction;

            switch (direction)
=======
            return isNearby;
        }
      


        //Maybe some Direction methods..
        //Saat yönünde.
        protected Direction ClockwiseDirection(Direction direction)
        {
            Direction clockWiseDirection = direction;

            switch (direction)
>>>>>>> Adding Spear
            {
                
                case Direction.Up:
                    clockWiseDirection = Direction.Right;
                    break;
                case Direction.Right:
                    clockWiseDirection = Direction.Down;
                    break;
                case Direction.Down:
                    clockWiseDirection = Direction.Left;
                    break;
                case Direction.Left:
                    clockWiseDirection = Direction.Up;
                    break;
            }

            return clockWiseDirection;
        }

        //Saat tersi yönünde 
<<<<<<< HEAD
        protected Direction CounterClockWiseDirection(Direction direction)
        {
            Direction counterClockWiseDirection = direction;

            switch (direction)
=======
        protected Direction CounterClockWiseDirection(Direction direction)
        {
            Direction counterClockWiseDirection = direction;

            switch (direction)
>>>>>>> Adding Spear
            {
                case Direction.Up:
                    counterClockWiseDirection = Direction.Left;
                    break;
                case Direction.Right:
                    counterClockWiseDirection = Direction.Up;
                    break;
                case Direction.Down:
                    counterClockWiseDirection = Direction.Right;
                    break;
                case Direction.Left:
                    counterClockWiseDirection = Direction.Down;
                    break;
            }

            return counterClockWiseDirection;
<<<<<<< HEAD
        }
    }
}
=======
        }
    }
}
>>>>>>> Adding Spear
