using System;
using System.Collections.Generic;
using System.Linq;

public class Controller
{
    public static void Main()
    {
        //var input = Console.ReadLine();
        //Console.WriteLine($"{input}:");
        //Task 1
        //Array names = Enum.GetValues(typeof(CardSuits));
        //foreach (var suit in names)
        //{
        //    Console.WriteLine($"Ordinal value: {(int)suit}; Name value: {suit}");
        //}

        //Task 2
        //Array names = Enum.GetValues(typeof(CardRanks));
        //foreach (var suit in names)
        //{
        //    Console.WriteLine($"Ordinal value: {(int)suit}; Name value: {suit}");
        //}

        //Task 3 & 4
        //var cardRank = Console.ReadLine();
        //var cardSuit = Console.ReadLine();
        //var cardRank2 = Console.ReadLine();
        //var cardSuit2 = Console.ReadLine();
        //var curCard = new Card(cardSuit, cardRank);
        //var curCard2 = new Card(cardSuit2, cardRank2);
        //if (curCard.CompareTo(curCard2) > 0)
        //{
        //    Console.WriteLine(curCard);
        //}
        //else if (curCard.CompareTo(curCard2) < 0)
        //{
        //    Console.WriteLine(curCard2);
        //}
        //Task 6
        //var request = Console.ReadLine();
        //object[] attributes = null;
        //if (request == "Rank")
        //{
        //    attributes = typeof(CardRanks).GetCustomAttributes(false);
        //}
        //else if (request == "Suit")
        //{
        //    attributes = typeof(CardSuits).GetCustomAttributes(false);
        //}
        //foreach (var attr in attributes)
        //{
        //    Console.WriteLine(attr);
        //}
        //Task 7
        //foreach (var card in Enum.GetValues(typeof(CardRanks)))
        //{
        //    foreach (var suit in Enum.GetValues(typeof(CardSuits)))
        //    {
        //        Console.Write(card);
        //        Console.WriteLine($" of {suit}");
        //    }
        //}
        //Task 8
        var player1 = Console.ReadLine();
        var player2 = Console.ReadLine();
        var deck = new List<Card>();
        var player1Cards = new List<Card>();
        var player2Cards = new List<Card>();
        foreach (var card in Enum.GetValues(typeof(CardRanks)))
        {
            foreach (var suit in Enum.GetValues(typeof(CardSuits)))
            {
                deck.Add(new Card(suit.ToString(), card.ToString()));
            }
        }
        for (int i = 0; i < 10; i++)
        {
            try
            {
                var cardParams = Console.ReadLine().Split();
                var card = deck.Where(x => x.Suit.ToString() == cardParams[2] && x.Rank.ToString() == cardParams[0]).First();
                if (player1Cards.Contains(card) || player2Cards.Contains(card))
                {
                    Console.WriteLine("Card is not in the deck.");
                    i--;
                    continue;
                }
                if (i < 5)
                {
                    player1Cards.Add(card);
                }
                else
                {
                    player2Cards.Add(card);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No such card exists.");
                i--;
                continue;
            }
        }
        var winner = string.Empty;
        Card bestCard = player1Cards.First();
        foreach (var card in player1Cards)
        {
            if (card.CompareTo(bestCard) > 0)
            {
                bestCard = card;
                winner = player1;
            }
        }
        foreach (var card in player2Cards)
        {
            if (card.CompareTo(bestCard) > 0)
            {
                bestCard = card;
                winner = player2;
            }
        }
        Console.WriteLine($"{winner} wins with {bestCard.ToString()}.");
    }
}