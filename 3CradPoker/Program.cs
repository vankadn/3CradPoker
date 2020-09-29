using System;
using System.Collections.Generic;
using System.Linq;
using _3CradPoker.Enumerations;
using _3CradPoker.Extensions;
using _3CradPoker.ViewModels;

namespace _3CradPoker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lines = new List<string>();
            string line;

            while (!String.IsNullOrWhiteSpace(line = Console.ReadLine()))
            {
                lines.Add(line);
                if (int.TryParse(lines[0], out int result1) && lines.Count-1==result1)
                {
                    break;
                }
            } 

            
            // var input =  Console.ReadLine();
           if (lines.Count>1 && int.TryParse(lines[0], out int result) && result> 0 && result<= 24 && result == lines.Count-1)
           {
               var dealtCards2 = new List<Hand>();

               for (int i = 1; i < lines.Count; i++)
               {
                   var listOfCards = new List<Card>();
                   var array = lines[i].Split(' ');
                   for (int j = 1; j < array.Length; j++)
                   {
                       listOfCards.Add(new Card(array[j]));
                   }

                   dealtCards2.Add(new Hand(listOfCards, Int32.Parse(array[0]))); ;
               }
                //var deck = new Deck();
                //var dealtCards
                //     = deck.Deal(result);
                
                dealtCards2.ForEach(hand =>
               {
                 var what =   HandDeterminator.EvaluatePokerHand(hand.Cards.ToArray());
                 hand.PokerHand = what;
               });

                var orderedEnumerable = dealtCards2.OrderBy(hand=> hand.PokerHand.Id).ToList();
                var enumerable = orderedEnumerable.Where(hand => hand.PokerHand.Id == orderedEnumerable[0].PokerHand.Id);
                var value = enumerable.Select(x => x.Id);
                
                Console.WriteLine(string.Join(" ", value));
           }
           else
           {
               Console.WriteLine("Not a valid input");
           }
      
        }
    }
}
