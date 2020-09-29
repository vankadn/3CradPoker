using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _3CradPoker.Enumerations;
using _3CradPoker.ViewModels;

namespace _3CradPoker.Extensions
{
    class HandDeterminator
    {
        public static bool IsFlush(Card[] hand)
        {
            hand = hand.OrderBy(item => Enumeration.FindByName<Rank>(item.Suit).Id).ToArray();

            int maxCardIndex = hand.Length - 1;

            return hand[0].Suit.Equals(hand[maxCardIndex].Suit);

        }


        public static bool IsStraight(Card[] hand)
        {
            // Sort hand by rank.
            hand = hand.OrderBy(item => Enumeration.FindByName<Rank>(item.Rank).Id).ToArray();

            // Increments the rank of the current position by 1, beginning the sequence.
            int sequentialRank = Enumeration.FindByName<Rank>(hand[0].Rank).Id  + 1;

            // If the next card does not match the sequence, the loop breaks. Otherwise, it succeeds.
            for (int i = 1; i < hand.Length; i++)
            {
                if (hand[i].Rank != Enumeration.FindById<Rank>(sequentialRank++).Name)
                    return false;
            }

            return true;

        }

        public static bool IsStraightFlush(Card[] hand)
        {
            // If the hand is a straight and a flush, then we have a straight flush.
            return IsStraight(hand) && IsFlush(hand);
        }

        public static bool IsThreeOfAKind(Card[] hand)
        {
          

            // Sort hand by rank.
            hand = hand.OrderBy(item => Enumeration.FindByName<Rank>(item.Rank).Id).ToArray();

            // Check for 3 cards of the same rank and two high unmatched cards.
            // a a a b c
            bool lowThreeOfAKind = hand[0].Rank == hand[1].Rank &&
                                   hand[1].Rank == hand[2].Rank;

            //// Check for 3 cards of the same rank, one low unmatched card and one high unmatched card.
            //// a b b b c
            //bool middleThreeOfAKind = (int)hand[1].Rank == (int)hand[2].Rank &&
            //                          (int)hand[2].Rank == (int)hand[3].Rank;

            //// Check for 3 cards of the same rank and two low unmatched cards
            //// a b c c c
            //bool highThreeOfAKind = (int)hand[2].Rank == (int)hand[3].Rank &&
            //                        (int)hand[3].Rank == (int)hand[4].Rank;

            return lowThreeOfAKind ;

        }

        // <summary>
        /// Checks for a one pair hand.
        /// </summary>
        /// <remarks>A one pair hand has two cards of the same rank.</remarks>
        /// <param name="hand">The player's hand.</param>
        /// <returns>Returns true if the hand is a one pair; returns false otherwise.</returns>
        public static bool IsOnePair(Card[] hand)
        {
            // Check whether the hand is not a one pair but better.
            if (IsThreeOfAKind(hand))
                return false;

            // Sort hand by rank.
            hand = hand.OrderBy(item => Enumeration.FindByName<Rank>(item.Rank).Id).ToArray();

            // Check for two cards of the same rank in the lower position. 
            // a a b c d
            bool lowPair = hand[0].Rank == hand[1].Rank;

            // Check for two cards of the same rank in the lower middle position.
            // a b b c d
            bool lowerMiddlePair = hand[1].Rank == hand[2].Rank;

          
            return lowPair || lowerMiddlePair ;

        }

        public static PokerHand EvaluatePokerHand(Card[] hand)
        {

            if (IsStraightFlush(hand))
                return PokerHand.StraightFlush;

            if (IsFlush(hand))
                return PokerHand.Flush;

            if (IsStraight(hand))
                return PokerHand.Straight;

            if (IsThreeOfAKind(hand))
                return PokerHand.ThreeOfAKind;


            if (IsOnePair(hand))
                return PokerHand.Pair;

            return PokerHand.HighCard;

        }
    }
}
