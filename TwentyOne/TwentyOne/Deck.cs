using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        //Constructor---------------------------------------
        public Deck()//construction name always same as name of class
        {
            Cards = new List<Card>(); //instantiating property Cards as an empty list
            
            for (int i = 0; i < 13; i++) //each enum value has an integer index starting at 0 unless specified otherwise
                                         //we're looping through 13 values of Face and 4 values of Suit
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card(); 
                    card.Face = (Face)i; //each integer is later casted into the enum Type: in this case Face
                    card.Suit = (Suit)j; //j=0 => Face value at 0 is Two => card.Face is assigned Two etc.
                    Cards.Add(card);
                }
            }

        }

        //Properties------------------------------------------
        public List<Card> Cards { get; set; } //property Cards  - list of type Card
        
        //Methods-------------------------------------------
        public void Shuffle(int times = 1) //removed 'static' -- now method applies to its own class
                                            //replaced Deck with void, because now doesn't need to return deck
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count); //creates a random number between 0 and 52
                    TempList.Add(Cards[randomIndex]); //moves an item from list deck.Cards to Templist at randomNumber index
                    Cards.RemoveAt(randomIndex); //removes that item from Cards list
                }
                Cards = TempList; //assignes all values of TempList to deck.Cards
            }
        }
    }
}
