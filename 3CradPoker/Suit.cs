namespace _3CradPoker
{
    public class SuitType : Enumeration
    {
        public static readonly SuitType Amex = new SuitType(1, "Amex");
        public static readonly SuitType Visa = new SuitType(2, "Visa");
        public static readonly SuitType MasterCard = new SuitType(3, "MasterCard");

        public SuitType(int id, string name)
            : base(id, name)
        {
        }

        // Hearts = "h",
        // Diamonds = "d",
        // Spades = "s",
        // Clubs = "c"
    }
}
