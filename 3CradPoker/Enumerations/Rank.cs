namespace _3CradPoker.Enumerations
{
    class Rank : Enumeration
    {
        public static readonly Rank Two = new Rank(1, "2");
        public static readonly Rank Three = new Rank(2, "3");
        public static readonly Rank Four = new Rank(3, "4");
        public static readonly Rank Five = new Rank(4, "5");
        public static readonly Rank Six = new Rank(5, "6");
        public static readonly Rank Seven = new Rank(6, "7");
        public static readonly Rank Eight = new Rank(7, "8");
        public static readonly Rank Nine = new Rank(8, "9");
        public static readonly Rank Ten = new Rank(9, "T");
        public static readonly Rank Jack = new Rank(10, "J");
        public static readonly Rank Queen = new Rank(11, "Q");
        public static readonly Rank King = new Rank(12, "K");
        public static readonly Rank Ace = new Rank(13, "A");

        public Rank(int id, string name)
            : base(id, name)
        {
        }
    }
}
