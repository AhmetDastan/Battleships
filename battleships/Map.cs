using System;
using System.Collections.Generic;
using System.Text;

namespace battleships
{
    class Map
    {
        List<List<Coordinate>> map = new List<List<Coordinate>>();
        int rowSize = 10;
        int columnSize = 10;
        public Map()
        {
            rowSize = 8;
            columnSize = 10;
            createMap();
        }
        void createMap()
        {
            for (int i = 0; i < rowSize; i++) 
            {
                map.Add(new List<Coordinate>());
                for(int j = 0; j < columnSize; j++)
                {
                    map[i].Add(new Coordinate());
                    map[i][j].Y = 0;
                    map[i][j].X = 0;
                }
            }
        }


        public void switchEmptyState(Coordinate coordinate) => map[coordinate.X][coordinate.Y].IsEmpty = false;

        public void switchHitState(Coordinate coordinate) => map[coordinate.X][coordinate.Y].IsHit = true;

        public bool isShipPartTakeDamage(Coordinate coordinate)
        {
            if (!map[coordinate.X][coordinate.Y].IsEmpty)
            {
                return true;
            }
            return false;
        }

       public void drawSecretMap()
        {
            for (int i = 0; i < rowSize; i++)
            {
                if (i == 0)
                {
                    Console.Write("x" + "  ");
                    for (int k = 1; k <= columnSize; k++)
                    {
                        Console.Write(k + " ");
                    }
                    Console.WriteLine();
                }
                Console.Write(i + 1 + "  ");

                for (int j = 0; j < columnSize; j++)
                {
                    
                    if (!map[i][j].IsEmpty)
                    {
                        if (map[i][j].IsHit)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("B ");
                            Console.ForegroundColor = ConsoleColor.White;
                            continue;
                        }
                    }
                    else 
                    {
                        if (map[i][j].IsHit)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("E ");
                            Console.ForegroundColor = ConsoleColor.White;
                            continue;
                        }
                        Console.Write("E ");
                    }

                }
                Console.WriteLine();
            }
        }
        public void drawOpenMap()
        {
            for (int i = 0; i < rowSize; i++)
            {
                if (i == 0)
                {
                    Console.Write("x" + "  ");
                    for (int k = 1; k <= columnSize; k++)
                    {
                        Console.Write(k + " ");
                    }
                    Console.WriteLine();
                }
                Console.Write(i + 1 + "  ");

                for (int j = 0; j < columnSize; j++)
                {
                    if (map[i][j].IsEmpty)
                    {
                        if (map[i][j].IsHit)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("E ");
                            Console.ForegroundColor = ConsoleColor.White;
                            continue;
                        }
                        Console.Write("E ");
                    }
                    else if (!map[i][j].IsEmpty)
                    {
                        if (map[i][j].IsHit)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("S ");
                            Console.ForegroundColor = ConsoleColor.White;
                            continue;
                        }
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("S ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
