using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaign
    {
        void CampaignEntry(Game game);
        void DeleteCampaign(Game game);
        void UpdateCampaign(Game game);
    }
}
