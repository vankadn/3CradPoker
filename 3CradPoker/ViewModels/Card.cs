namespace _3CradPoker.ViewModels
{
    public class Card
    {
        public Card(string suit, string rank, string pairSuitRank)
        {
            Suit = suit;
            Rank = rank;
            PairSuitRank = pairSuitRank;
        }

        public Card(string pairSuitRank)
        {
            Suit = pairSuitRank[1].ToString();
            Rank = pairSuitRank[0].ToString();
            PairSuitRank = pairSuitRank;
        }

        public string Suit { get; set; }
        public string Rank { get; set; }
        public string PairSuitRank { get; set; }
    }
}
