using System;
using System.Collections.Generic;
using System.Text;

namespace battleships
{
    class GamePlay : IGamePlay 
    {
        Player player1 = new Player();

        Player player2 = new Player();

        bool gameOver;

        int turnCount;

        public GamePlay()
        {
            gameOver = false;
            turnCount = 0;
        }

        public Player Player1
        {
            get
            {
                return player1;
            }
            set
            {
                player1 = value;
            }
        }
        public Player Player2
        {
            get
            {
                return player2;
            }
            set
            {
                player2 = value;
            }
        }
        public bool GameOver 
        {
            get
            {
                return gameOver;
            }
            set
            {
                gameOver = value;
            }
        }

        public void DrawMaps()
        {
            Console.Clear();
            if (turnCount % 2 == 0)  //turn player1
            {
                Console.WriteLine(player1.UserName);
                player1.MyMap.drawOpenMap();
                Console.WriteLine();
                Console.WriteLine(player2.UserName);
                player2.MyMap.drawSecretMap();
            }
            else  //turn player2
            {
                Console.WriteLine(player1.UserName);
                player1.MyMap.drawSecretMap();
                Console.WriteLine();
                Console.WriteLine(player2.UserName);
                player2.MyMap.drawOpenMap();
            }
        }

        public void EndTurn()
        {
            if (turnCount % 2 == 0) //turn player1
            {
                Console.WriteLine(player1.UserName + " choose coordinate and attack");
                Player2.Attacked(Player1.Attack());
                DrawMaps();
            }
            else  //turn player2
            {
                DrawMaps();
                Console.WriteLine(player2.UserName + " choose coordinate and attack");
                Player1.Attacked(Player2.Attack());
                DrawMaps();
            }
            Console.WriteLine("press enter for other turn");
            Console.ReadLine();
            turnCount++;
        }

        public void InitialSetup()
        {
            string tempName;
            Console.WriteLine("player1 please enter user name");
            tempName = Console.ReadLine();
            player1.UserName = tempName;
            player1.shipsCreate();
            Console.Clear();

            Console.WriteLine("player2 please enter user name");
            tempName = Console.ReadLine();
            player2.UserName = tempName;
            player2.shipsCreate();

            DrawMaps();
        }

        public void gameOverControl()
        {
            if (player1.isLose() && player2.isLose())
            {
                gameOver = true;
                Console.Clear();
                Console.WriteLine("No win - Draw");
            }
            else if (player1.isLose() || player2.isLose())
            {
                gameOver = true;
                Console.Clear();
                if (player1.isLose())
                {
                    Console.WriteLine("Congrulutions " + player2.UserName + " you win");
                }
                else
                {
                    Console.WriteLine("Congrulutions " + player1.UserName + " you win");
                }
            }
            
        }
    }
}
