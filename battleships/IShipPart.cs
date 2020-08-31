using System;
using System.Collections.Generic;
using System.Text;

namespace battleships
{
    interface IShipPart
    {
        Coordinate Coordinate { get; set; }

        bool ShipPartSinked { get;}
    }
}
