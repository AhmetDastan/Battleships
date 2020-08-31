using System;
using System.Collections.Generic;
using System.Text;

namespace battleships
{
    interface IGamePlay
    {
        public Player Player1 { get; set; }

        public Player Player2 { get; set; }

        public void InitialSetup();

        public void DrawMaps();

        public void EndTurn();

        public bool GameOver { get; set; }
    }
}
