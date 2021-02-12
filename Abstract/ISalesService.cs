using GameProjectOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOdev.Abstract
{
     public interface ISalesService
    {
        void Sales(Game game, Gamer gamer);
        void CampaignSales(Game game, Gamer gamer, Campaign campaign);

    }
}
