using System;
using System.Collections.Generic;
using System.Text;

namespace Store2021
{
    class Store
    {
        //in class someone suggested we have a list of games, I'm changing it to an object of the Showcase class
        //List<Game> steam2;
        public Showcase showcase;

        public Store()
        {
            //let's say we have 5 spots
            showcase = new Showcase(5);
            //now we would have to add the initial games
            showcase.AddGame(new Game("Tomb Raider", 5, "raid tombs!"));
            showcase.AddGame(new Game("Minecraft", 30, "craft and mine!"));
            showcase.AddGame(new Game("Fortnight", 30000, "something, I don't know"));
            showcase.AddGame(new Game("DeltaRune", 14, "We Rune, and we also deltaTime"));
        }

        //Here we could have some methods to buy a game, or seeing what's for sale

    }
}
