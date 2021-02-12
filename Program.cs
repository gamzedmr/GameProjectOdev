using GameProjectOdev.Concrete;
using GameProjectOdev.Entities;
using System;

namespace GameProjectOdev
{
     public class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager1 = new GamerManager(new UserValidationManager());
            Gamer gamer1 = new Gamer() { ID = 1, BirthYear = 1998, FirstName = "Gamze", LastName = "DEMİR", IdentityNumber = 12345 };
            GamerManager gamerManager2 = new GamerManager(new UserValidationManager());
            Gamer gamer2 = new Gamer() { ID = 2, BirthYear = 1996, FirstName = "Fatma", LastName = "DEMİR", IdentityNumber = 67890};

            Game game1 = new Game() { GameID = 1, Name = "PUBG", Price = 250 };
            Game game2 = new Game() {GameID= 2, Name = "GTA ", Price =200 };
            Game game3 = new Game() { GameID = 3, Name = "CS-GO",Price = 150 };


            Campaign campaign1 = new Campaign() { CampaignID = 1,Name = "Yeni Üyelere Özel Kampanya", Discount = 25, };
            Campaign campaign2 = new Campaign() { CampaignID = 2, Name = "Tatil Kampanyası", Discount= 30,  };


            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign2);
           

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(game1, gamer2);
            salesManager.CampaignSales(game1,gamer2,campaign2);

        }

    }
}
