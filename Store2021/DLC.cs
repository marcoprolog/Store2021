﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Store2021
{
    class DLC : Item
    {
        Game parentGame;

        public DLC(string name, string description, float price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
        }
    }
}
