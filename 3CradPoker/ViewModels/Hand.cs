using System;
using System.Collections.Generic;
using System.Text;
using _3CradPoker.Enumerations;

namespace _3CradPoker.ViewModels
{
    class Hand
    {
        public Hand(List<Card> cards, int id)
        {
            Cards = cards;
            Id = id;
        }
        public List<Card> Cards { get; set; }
        public int Id { get; set; }

        public PokerHand PokerHand { get; set; }
    }
}
