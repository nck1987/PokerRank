using System;

namespace newsoftit
{
    public enum Suit
    {
        Clubs,
        Hearts,
        Spades,
        Diamonds
    }

    public enum Rank
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    public class Card
    {
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }
    }
}
