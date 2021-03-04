using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IGameSaleManager
    {
        void Buy(Game game, Gamer gamer, Campaign campaign);
        void Retrocede(Game game, Gamer gamer);
        void Sell(Game game, Gamer gamer, Campaign campaign);
    }
}
