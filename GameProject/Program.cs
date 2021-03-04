using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer
            {
                Id = 1,
                FirstName = "Emre Can",
                LastName = "UĞURLU",
                DateOfBirth = new DateTime(1999, 10, 11),
                TcNo = "12345678901"
            };
            Game game = new Game
            {
                Id =1,
                Name = "GTA 5",
                Price = 100
            };
            Campaign campaign = new Campaign
            {
                Id = 1,
                Name = "Büyük Mayıs",
                Discount = 10,
            };

            IGamerManager gamerManager = new GamerManager(new GamerCheck());
            gamerManager.Add(gamer);
            IGameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Retrocede(game,gamer);
            ICampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            IGameSaleManager gameSaleManager1 = new GameSaleManager();
            gameSaleManager1.Buy(game, gamer, campaign);

        }
    }
}
