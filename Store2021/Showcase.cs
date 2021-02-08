using System;
using System.Collections.Generic;
using System.Text;

namespace Store2021
{
    class Showcase
    {
        //since the showcase only has a max amount of spots, we can use an array
        Item[] games;

        public Showcase(int size)
        {
            games = new Item[size];
            Game game = new Game("Night in the woods", 20f, "weird adventure game with cats");
            DLC dlc1 = new DLC("something", "a description", 5f);
            games[0] = game;
            games[1] = dlc1;
            //polymorphism - poly-many morphos-shapes
        }

        //incomplete methods that the showcase could have
        public void AddGame()
        {

        }

        public void RemoveGame()
        {

        }
        public void Show()
        {

        }
    }
}
