using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " kampanyası eklendi...");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " kampanyası silidi...");
        }

        public void Upgrate(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " kampanyası güncellendi...");
        }
    }
}
