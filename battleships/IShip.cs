using System;
using System.Collections.Generic;
using System.Text;

namespace battleships
{
    interface IShip
    {
        List<ShipPart> ShipParts { get; set; }
        bool Sinked { get; set; }
    }
}
