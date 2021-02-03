using System;
using System.Collections.Generic;
using System.Text;

namespace Store2021
{
    class Store
    {
        //in class someone suggested we have a list of games, I'm changing it to an object of the Showcase class
        //List<Game> steam2;
        Showcase showcase;

        public Store()
        {
            //let's say we have 5 spots
            showcase = new Showcase(5);
            //now we would have to add the initial games
        }

        //Here we could have some methods to buy a game, or seeing what's for sale

    }
}
