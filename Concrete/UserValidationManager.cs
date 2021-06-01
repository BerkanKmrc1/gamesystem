using gamesystem.Abstract;
using gamesystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace gamesystem.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1985 && gamer.Name == "Berkan" && gamer.Surname == "Kömürcü" && gamer.IdentityNumber == 12345)
            {
                return true;
            }
            else
                return false;
        }
    }
}
