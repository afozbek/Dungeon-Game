using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest
{
    public abstract class Mover
    {
        private const int MoveInterval = 10;

        protected Point location;
        public Point Location
        {
            get { return location; }
        }//Değişime uğrayacak..
        protected Game game;

        public Mover(Game game, Point location)
        {
            this.game = game;
            this.location = location;
        }
        //The Move() method tries to move one step in a direction. If it can,
        // it returns the new Point.
        // If it hits a boundary, it returns the original Poin
        //public Point Move(Direction direction,Point myLocation, Rectangle boundaries)
        //{
        //    //Content here...
        //    //direction doğrultusunda Benim pointimi değiştirir
        //    //boundaries e de bakıp taşma var mı yok mu kontrol eder.
        //}


        //The Nearby method checks a Point against this object’s current location. 
        //If they’re within distance of each other, then it returns true; otherwise,
        // it returns false.



        //public bool Nearby(Point enemyLocation,Point myLocation, int radius)
        //{
        //    //Content here!..
        //    if (enemyLocation.X - myLocation.X <= radius)
        //        if (enemyLocation.Y - myLocation.Y <= radius)
        //            return true;
        //    return false;
        //}

        //public enum Direction
        //{
        //    Left,Right,Up,Down
        //}
        public Point Move(Direction direction,Rectangle boundaries)
        {

            Point newLocation = location;
            switch (direction)
            {
                case Direction.Up:
                    if (newLocation.Y - MoveInterval >= boundaries.Top)
                    {
                        newLocation.Y -= MoveInterval;
                    }
                    break;
                case Direction.Down:
                    if (newLocation.Y + MoveInterval <= boundaries.Bottom)
                    {
                        newLocation.Y += MoveInterval;
                    }
                    break;
                case Direction.Left:
                    if (newLocation.X - MoveInterval >= boundaries.Left)
                    {
                        newLocation.X -= MoveInterval;
                    }
                    break;
                case Direction.Right:
                    if (newLocation.X + MoveInterval <= boundaries.Right)
                    {
                        newLocation.X += MoveInterval;
                    }
                    break;
                default: break;
            }
            return newLocation;
            //Finally, this new location is returned 
            //(which might still be the same as the starting location!).
        }
        public bool Nearby(Point locationToCheck, int distance)

        {
            if (Math.Abs(location.X - locationToCheck.X) < distance &&
                (Math.Abs(location.Y - locationToCheck.Y) < distance))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        
    }
}

