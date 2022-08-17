using GamerManagerSystem.Abstract;
using GamerManagerSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerManagerSystem.Concrete
{
    public class GamerManager : BaseGamerManager
    {
        IPersonCheckService _personCheckService;

        public GamerManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }

        public override void Add(Gamer gamer)
        {
            if (_personCheckService.CheckIfRealPerson(gamer))
            {
                base.Add(gamer);
            }
            else
            {
                throw new Exception("Not a valid person.");
            }
            
        }
    }
}
