using System;
using System.Collections.Generic;
using System.Text;

namespace Store2021
{
    class Game : Item
    {
        //what makes a game a game? What information do we need to reprent a game in our store?
        string url;
        //release-date
        //supported platforms
        string genre;
        bool multiplayer;

        //list of DLCs
        List<DLC> dlcs;

        //what constructor? what do we need to make a new game?
        public Game(string name, float price, string description)
        {
            this.name = name;
            this.price = price;
            this.description = description;
        }


        //what functionality does the game have?
        public float DiscountedPrice()
        {
            //take the current price and apply some discount
            return 1;
        }

        public void SetGenre(string g)
        {
            genre = g;
        }
    }
}
