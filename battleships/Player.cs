using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;

namespace battleships
{
    class Player : IPlayer
    {
        List<Ship> ships = new List<Ship>();

        Map myMap = new Map();

        int shipCount;
        string userName;
        public Player()
        {
            shipCount = 1;
        }

        public List<Ship> Ships 
        {
            get
            {
                return ships;
            }
            set
            {
                ships = value;
            }
        }
        public Map MyMap 
        {
            get
            {
                return myMap;
            }
            set
            {
                myMap = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }
        public Coordinate Attack() 
        {
            Coordinate coordinate = new Coordinate();
            Console.WriteLine("x ve y eksenlerini gir");
            int tempX = Convert.ToInt32(Console.ReadLine());
            int tempY = Convert.ToInt32(Console.ReadLine());
            coordinate.X = tempX-1;
            coordinate.Y = tempY-1;
            return coordinate;
        }

        public void Attacked(Coordinate coordinate)
        {
            myMap.switchHitState(coordinate);  //mape sik
            if (myMap.isShipPartTakeDamage(coordinate)) //siktigin yerde gemi var mi
            {
                for (int i = 0; i < ships.Count; i++)//mecbur cift for hangi geminin parts
                {
                    for(int j = 0; j < ships[i].ShipSize; j++)
                    {
                        if (ships[i].ShipParts[j].Coordinate.X == coordinate.X)
                        {
                            if(ships[i].ShipParts[j].Coordinate.Y == coordinate.Y)
                            {
                                ships[i].ShipParts[j].takeDamage();

                            }
                        }   
                    }
                }
            }
        }
    
        public void shipsCreate()
        {
            for (int i = 0; i < shipCount; i++)
            {
                Console.WriteLine((i+1) + ". ship coordinate enter");
                ships.Add(new Ship());
                implantationShip(ships[i]);
            }
        }
        
        void implantationShip(Ship ship)
        {
            for (int i = 0; i < ship.ShipParts.Count; i++)
            {
                myMap.switchEmptyState(ship.ShipParts[i].Coordinate);
            }
        }

        public bool isLose()
        {
            int tempShipCount = shipCount;
            foreach (Ship ships1 in ships)
            {
                ships1.shipSinked();
                if (ships1.Sinked)
                {
                    tempShipCount--;
                }
                if (tempShipCount <= 0)
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}
