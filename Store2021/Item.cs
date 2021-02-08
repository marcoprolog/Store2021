using System;
using System.Collections.Generic;
using System.Text;

namespace Store2021
{
    abstract class Item
    {
        protected string name;
        protected int id;
        //image
        protected bool hasBeenBought;
        protected float price;
        protected string description;
        //release-date

        public Item()
        {

        }
    }
}
