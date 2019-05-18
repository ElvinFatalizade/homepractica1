using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homepractica.Models
{
    class VirtualCard:Card
    {
        public Card Card { get; set; }

        public DateTime CreateAt { get; set; }

        public double  Price { get; set; }

        public string Desc { get; set; }
    }
}
