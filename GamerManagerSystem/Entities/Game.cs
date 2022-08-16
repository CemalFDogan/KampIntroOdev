using GamerManagerSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerManagerSystem.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameCategory { get; set; }
        public string GamePrice { get; set; }

    }
}
