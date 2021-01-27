using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamer
    {
        public void DeletePlayer(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " has successfully deleted.");
        }

        public void NewPlayer(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " has successfully added.");
        }

        public void UpdatePlayer(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " named players informations are updated. ");
        }
    }
}

