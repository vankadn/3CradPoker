namespace _3CradPoker.Enumerations
{
    public class PokerHand : Enumeration
    {
        public static readonly PokerHand Flush = new PokerHand(1, "Flush");
        public static readonly PokerHand Straight = new PokerHand(2, "Straight");
        public static readonly PokerHand StraightFlush = new PokerHand(3, "StraightFlush");
        public static readonly PokerHand ThreeOfAKind = new PokerHand(4, "ThreeOfAKind");
        public static readonly PokerHand Pair = new PokerHand(5, "Pair");
        public static readonly PokerHand HighCard = new PokerHand(6, "HighCard");

        public PokerHand(int id, string name)
            : base(id, name)
        {
        }
    }
}
