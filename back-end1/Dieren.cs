using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Dieren
    {
        public enum SizeOptions
        {
            Small = 1,
            Medium = 3,
            Large = 5
        }

        public enum EatOptions
        {
            Meat,
            Plants
        }

        public SizeOptions Size { get; set; }
        public EatOptions Eat { get; set; }

        public Dieren(SizeOptions _Size, EatOptions _Eat) 
        { 
            Size = _Size;
            Eat = _Eat;
        }
    }
}
