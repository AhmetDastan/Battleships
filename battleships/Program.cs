using System;

namespace battleships
{
    class Program
    {
        static void Main(string[] args)
        {
            //kafalar karisik aga tam oturmuyo sanki yanlis bir seyler var
            //coordinate sinifi problemli
            Console.WriteLine("Hello World!");

            

            GamePlay gamePlay = new GamePlay();
            gamePlay.InitialSetup();

            while (!gamePlay.GameOver)
            {
                gamePlay.EndTurn();
                gamePlay.gameOverControl();
            }

        }
    }
}
