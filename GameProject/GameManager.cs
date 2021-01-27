using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager
    {
        public void GameSale(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.Name + " has " + game.GameName + " proceeded the checkout.");
        }
    }
}
