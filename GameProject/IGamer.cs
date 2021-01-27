using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{ 
    interface IGamer
    {
        void NewPlayer(Gamer gamer);
        void DeletePlayer(Gamer gamer);
        void UpdatePlayer(Gamer gamer);
    }
}
