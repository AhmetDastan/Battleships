using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace battleships
{
    class Ship : IShip
    {
        bool sinked;
        int shipSize;

        public Ship()
        {
            shipSize = 1;
            sinked = false;
            createShip();
        }
        List<ShipPart> shipParts = new List<ShipPart>();

        public int ShipSize
        {
            get
            {
                return shipSize;
            }
            set
            {
                shipSize = value;
            }
        }

        public List<ShipPart> ShipParts 
        {
            get
            {
                return shipParts;
            }
            set
            {
                shipParts = value;
            }
        }

        public bool Sinked 
        {
            get
            {
                return sinked;
            }
            set
            {
                sinked = value;
            }
        }

        public void createShip()
        {
            for (int i = 1; i <= shipSize; i++)
            {
                Console.WriteLine(i + ".part of ship coordinate enter");
                shipParts.Add(new ShipPart());
            }
        }

        public void shipSinked()
        {
            int tempShipSize = shipSize;
            foreach(ShipPart shipParts1 in shipParts)
            {
                if (shipParts1.ShipPartSinked)
                {
                    tempShipSize--;
                }
                if(tempShipSize <= 0)
                {
                    sinked = true;
                }
            }
        }

    }
}
