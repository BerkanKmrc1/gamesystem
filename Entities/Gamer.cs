using System;
using System.Collections.Generic;
using System.Text;

namespace gamesystem.Entities
{
    public class Gamer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int BirthYear { get; set; }
        public int IdentityNumber { get; set; }
    }
}
