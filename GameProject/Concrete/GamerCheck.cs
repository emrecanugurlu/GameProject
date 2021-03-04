using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GamerCheck : IGamerCheckManager
    {
        bool IGamerCheckManager.GamerCheck()
        {
            return true;
        }
    }
}
