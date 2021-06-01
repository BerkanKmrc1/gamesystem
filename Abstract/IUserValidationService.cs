using gamesystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace gamesystem.Abstract
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
