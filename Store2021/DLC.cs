using System;
using System.Collections.Generic;
using System.Text;

namespace Store2021
{
    class DLC
    {
        float price;
        string name;
        Game parentGame;
        string description;

        public DLC(string name, string description, float price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
        }
    }
}
