using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homepractica.Models
{
    enum CardType
    {
        Visa,
        Master,
        VisaElectron
    }
    class Card
    {
        public ulong Number { get; set; }

        public string  Holder { get; set; }

        public DateTime Expire { get; set; }

        public short CVV { get; set; }

        public CardType Type { get; set; }

        public double Balance { get; set; }
    }
}
