using System;
using System.Collections.Generic;
using System.Text;

namespace battleships
{
    interface IPlayer
    {
        public List<Ship> Ships { get; set; }

        public Map MyMap { get; set; }

        public Coordinate Attack();

        public void Attacked(Coordinate coordinate);
    }
}
