using GameProjectOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOdev.Concrete
{
    public class GameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine("oyun eklendi: " + game.Name);
        }
        public void Delete(Game game)
        {
            Console.WriteLine("oyun silindi: " + game.Name);
        }
         public void Update(Game game)
        {
            Console.WriteLine("oyun güncellendi :" + game.Name);
        }
    }
}
