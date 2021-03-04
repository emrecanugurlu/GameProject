using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameSaleManager : IGameSaleManager
    {
        public void Buy(Game game, Gamer gamer,Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " " + game.Name + " oyununu" + " %" + campaign.Discount + " indirimle aldı");
        }

        public void Retrocede(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + game.Name + " iyade etti");
        }

        public void Sell(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " " + game.Name + " oyununu" + " %" + campaign.Discount + " indirimle sattı.");
        }
    }
}
