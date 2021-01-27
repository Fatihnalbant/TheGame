using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class PlayerManager
    {
        public void Add(Player player)
        {
            Console.WriteLine("Player Eklendi");
        }
        public void Delete(Player player)
        {
            Console.WriteLine("Player Silindi");
        }
        public void Update(Player player)
        {
            Console.WriteLine("Player Yenilendi");
        }
    }
}