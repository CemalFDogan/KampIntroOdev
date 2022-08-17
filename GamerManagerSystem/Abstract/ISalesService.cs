﻿using GamerManagerSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerManagerSystem.Abstract
{
    interface ISalesService
    {
        void AddToCart(Game game, Campaign campaign, Gamer gamer);
    }
}
