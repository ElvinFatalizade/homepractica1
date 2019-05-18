using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homepractica.Models
{
    class Store
    {
        private Card[] _cards;

        public Card[] Cards
        {
            get
            {
                return this._cards;
            }
        }

        public Store()
        {
            this._cards = new Card[0];
            this._virtualcards = new VirtualCard[0];
            this._operations = new Operation[0];
        }

        private VirtualCard[] _virtualcards;

        private Operation[] _operations;

        public void AddCard(Card card)
        {
            Array.Resize(ref this._cards, this._cards.Length + 1);

            this._cards[this._cards.Length-1] = card;
        }

        public void RemoveCard (int index)
        {

        }
    }
}
