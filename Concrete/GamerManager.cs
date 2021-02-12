using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOdev
{
   public  class GamerManager : IGamerService
      {
        IUserValidatıonService _userValidatıonService;

        public GamerManager(IUserValidatıonService userValidatıonService)
        {
            _userValidatıonService = userValidatıonService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidatıonService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt olundu");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız");
            }
           
        }

        public void Delete(Gamer gamer)
        {   
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");


        }
    }
}
