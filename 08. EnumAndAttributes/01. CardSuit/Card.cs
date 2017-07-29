using System;

public class Card : IComparable<Card>
{
    public Card(string suit, string rank)
    {
        this.Rank = Enum.Parse(typeof(CardRanks), rank);
        this.Suit = Enum.Parse(typeof(CardSuits), suit);
        this.Power = (int)this.Rank + (int)this.Suit;
    }
    private object rank;
    private object suit;
    private int power;

    public object Rank
    {
        get
        {
            return rank;
        }

        private set
        {
            rank = value;
        }
    }

    public object Suit
    {
        get
        {
            return suit;
        }

        private set
        {
            suit = value;
        }
    }

    public int Power
    {
        get
        {
            return power;
        }

        private set
        {
            power = value;
        }
    }

    public int CompareTo(Card other)
    {
        return this.Power.CompareTo(other.Power);
    }

    public override string ToString()
    {
        return $"{this.Rank} of {this.Suit}";
    }
}