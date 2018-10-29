using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public struct Card
    {
        //public Card() //Constructor: default values assigned to properties and or/methods run upon instantiation of a class
        //{
            
        //}
        public Suit Suit { get; set; }// now that we have enum for suit the type of this property is Suit 
        //and will not accept any other values than the 4 specified in enum Suit

        public Face Face { get; set; }
        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    }

    public enum Suit //user defined datatype with a defined set of integral values
    {
        Clubs,
        Diamonds,
        Spades,
        Hearts
    }

    public enum Face
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
}
