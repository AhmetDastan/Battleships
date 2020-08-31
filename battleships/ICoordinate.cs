using System;
using System.Collections.Generic;
using System.Text;

namespace battleships
{
    interface ICoordinate
    {
        public int X { get; set; }

        public int Y { get; set; }

        public bool IsHit { get; set; }

        public bool IsEmpty { get; set; }
    }
}
