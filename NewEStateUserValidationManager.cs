using gamesystem.Abstract;
using gamesystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace gamesystem
{
    class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true; 
        }
    }
}
