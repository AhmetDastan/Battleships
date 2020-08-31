using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;

namespace battleships
{
    class ShipPart : IShipPart
    {
        Coordinate coordinate = new Coordinate();

        int health;

        bool shipPartSinked;

        public ShipPart()
        {
            health = 1;
            shipPartSinked = false;
            setShipPartCoordinate();
        }
        public Coordinate Coordinate
        {
            get
            {
                return coordinate;
            }
            set
            {
                coordinate = value;
            }
        }

        public void setShipPartCoordinate()
        {
            Console.WriteLine("Before entry x coordinate and than y coordinate");
            Console.WriteLine("enter x coordinate");
            coordinate.X = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine("enter y coordinate");
            coordinate.Y = Convert.ToInt32(Console.ReadLine()) - 1;
            coordinate.IsEmpty = false;
        }

        public void takeDamage()
        {
            if(health > 0)
            {
                health--;
            }
            if(health == 0)
            {
                shipPartSinked = true;
            }
        }

        public bool ShipPartSinked
        {
            get
            {
                return shipPartSinked;
            }
        }

    }
}
