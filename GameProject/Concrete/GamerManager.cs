using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GamerManager : IGamerManager
    {
        IGamerCheckManager _gamerCheckManager;

        public GamerManager(IGamerCheckManager gamerCheckManager)
        {
            _gamerCheckManager = gamerCheckManager;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckManager.GamerCheck())
            {
                Console.WriteLine(gamer.FirstName + " Eklendi");
            }
            else
            {
                throw new Exception("Kullanıcı Doğrulanamadı");
            }

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Güncellendi");
        }
    }
}
