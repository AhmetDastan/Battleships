using System;
using System.Collections.Generic;
using System.Text;

namespace battleships
{
    class Coordinate : ICoordinate
    {
        int x = 0;
        int y = 0;
        bool isHit = false;
        bool isEmpty = true;

        public int X {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public bool IsHit
        {
            get
            {
                return isHit;
            }
            set
            {
                isHit = value;
            }
        }
        public bool IsEmpty
        {
            get
            {
                return isEmpty;
            }
            set
            {
                isEmpty = value;
            }
        }
    }
}
