using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaign
    {
        void ICampaign.CampaignEntry(Game game)
        {
            Console.WriteLine(game.GameName + " has %25 saled.");
            Console.WriteLine("New Price :" + game.GamePrice / 4);
        }


        void ICampaign.DeleteCampaign(Game game)
        {
            Console.WriteLine(game.GameName + " sale is over.");
        }



        void ICampaign.UpdateCampaign(Game game)
        {
            Console.WriteLine(game.GameName + " has a new sale.");
        }
    }
}
