using GamerManagerSystem.Abstract;
using GamerManagerSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerManagerSystem.Concrete
{
    public class PersonCheckManager : IPersonCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
