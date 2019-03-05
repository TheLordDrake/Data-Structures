using System;

namespace Stack_of_Cards
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var deck = new Deck();
            var choice = 0;
            
            do
            {
                Console.Write("What would you like to do?:\n"
                                  + "1: Draw\n"
                                  + "2: Shuffle\n"
                                  + "0: Exit\n"
                                  + "->: ");
                
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    continue;
                }
                
                choice = int.Parse(input);

                switch (choice)
                {
                    case 0:
                        break;
                    case 1:
                        deck.Draw();
                        break;
                    case 2:
                        deck.Shuffle();
                        break;
                    default:
                        continue;
                }

            } while (choice != 0);
        }
    }
}