using GameProjectOdev.Abstract;
using GameProjectOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOdev.Concrete
{
   public  class CampaignManager:ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Yeni Kampanya eklendi :" + campaign.CampaignID + " " + campaign.Name + " " +campaign.Discount);
        }
        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampaya güncellendi:" + campaign.Name);
        }
        public void Delete(Campaign campaign)
        {
           Console.WriteLine("Kampanya silindi :" +campaign.Name );
        }

    }
}
