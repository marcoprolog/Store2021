using System;

namespace Store2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our Steam* store");
            Store store = new Store();
            bool exit = false;
            do
            {
                Console.WriteLine("Please input command [Possible commands: list, buy, quit]");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "list":
                        //do something
                        Console.WriteLine("Here's the games on sale");
                        store.showcase.Show();
                        break;
                    case "buy":
                        // do somehting else
                        Console.WriteLine("Which game would you like to buy?");
                        string answer = Console.ReadLine();
                        int index = int.Parse(answer);
                        store.showcase.RemoveGame(index);
                        break;
                    case "quit":
                        exit = true;
                        break;
                    default:
                        // nothing matched and I do something
                        Console.WriteLine("I don't understand that command :(");
                        break;
                }
            } while (exit == false); //!exit      !(true) -> false      !(false) -> true
            /*
            if (input == "list")
            {

            }
            else if (input == "buy")
            {

            }
            */
            //....
        }
    }
}
