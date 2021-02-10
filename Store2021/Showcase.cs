using System;
using System.Collections.Generic;
using System.Text;

namespace Store2021
{
    class Showcase
    {
        //since the showcase only has a max amount of spots, we can use an array
        List<Game> games;
        int max;

        public Showcase(int size)
        {
            games = new List<Game>();
            max = size;
        }

        //incomplete methods that the showcase could have
        public void AddGame(Game game)
        {
            if (games.Count < max)
                games.Add(game);
        }

        public void RemoveGame(int index)
        {
            if (index < 0) //what if we get an index that makes no sense?
                return;
            if(games.Count > index)
                games.RemoveAt(index);
        }
        public void Show()
        {
            for(int i = 0; i<games.Count; i++)
            {
                // 5: MineCraft
                Console.WriteLine(i + ": " + games[i].name);
            }
        }
    }
}
