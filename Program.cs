using gamesystem.Concrete;
using gamesystem.Abstract;
using gamesystem.Entities;
using System;

namespace gamesystem
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1985,
                Name = "Berkan",
                Surname = "Kömürcü",
                IdentityNumber = 12345
            });
      


        }
    }
}
