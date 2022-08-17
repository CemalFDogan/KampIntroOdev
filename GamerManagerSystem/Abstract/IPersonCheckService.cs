using GamerManagerSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerManagerSystem.Abstract
{
    public interface IPersonCheckService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
