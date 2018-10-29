﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\Nastya\Documents\GitHub\C-Sharp-Coding-Projects\log.txt", true))
            {
                file.Write(DateTime.Now + " ");
              
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0);
        }
    }
}