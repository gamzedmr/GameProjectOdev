using GameProjectOdev.Abstract;
using GameProjectOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOdev.Concrete
{
    public class SalesManager:ISalesService
     {
     public void Sales(Game game, Gamer gamer)
     {
       Console.WriteLine(gamer.FirstName +" " + game.Name +" " +" oyununu aldı.");
      }
     public void CampaignSales(Game game, Gamer gamer, Campaign campaign)
       {
       Console.WriteLine(gamer.FirstName +" " + campaign.Name + " ile " + game.Name +" " + " oyununu aldı.");
        }
     }
}
