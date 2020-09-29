using System.Collections.Generic;
using System.Linq;
using _3CradPoker.Enumerations;
using _3CradPoker.ExtensionMethods;

namespace _3CradPoker.ViewModels
{
    public class Deck
    {
        public List<Card> CardSet;
        public Deck()
        {
            var suits = Enumeration.GetAll<Suit>().Select(x => x.Name).ToList();
            var ranks = Enumeration.GetAll<Rank>().Select(x => x.Name).ToList();
            CardSet = new List<Card>();
            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    CardSet.Add(new Card(suit, rank, suit+rank));
                }
            }
        }

        public  List<Card> Shuffle()
        {
            CardSet.Shuffle();
            return CardSet;
        }

        public List<List<Card>> Deal(int howMany)
        {
            List<List<Card>> dealtCards = new List<List<Card>>();
            CardSet.Shuffle();
            for (int i1 = 0; i1 < howMany; i1++)
            {
                List<Card> userHand = new List<Card>();
                for (int i = 0; i < 3; i++)
                {
                    userHand.Add(CardSet[0]);
                    CardSet.RemoveAt(0);
                }
                dealtCards.Add(userHand);
            }
            
            return dealtCards;
        }

    }
}
