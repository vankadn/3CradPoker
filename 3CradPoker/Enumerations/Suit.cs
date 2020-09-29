namespace _3CradPoker.Enumerations
{
    public class Suit : Enumeration
    {
        public static readonly Suit Hearts = new Suit(1, "h");
        public static readonly Suit Diamonds = new Suit(2, "d");
        public static readonly Suit Spades = new Suit(3, "s");
        public static readonly Suit Clubs = new Suit(3, "c");

        public Suit(int id, string name)
            : base(id, name)
        {
        }
    }
}
