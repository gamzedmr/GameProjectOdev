using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOdev
{
    public class UserValidationManager : IUserValidatıonService
    {
        public bool Validate(Gamer gamer)
        {
          if(gamer.ID==4 && gamer.BirthYear== 1970  &&  gamer.FirstName=="Gamze" && gamer.LastName=="Demir" && gamer.IdentityNumber==147852)
                
            {
                return true;
            }
            else if(gamer.ID == 2 && gamer.BirthYear == 1990 && gamer.FirstName == "Gizem" && gamer.LastName == "Kaya" && gamer.IdentityNumber == 789456)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
