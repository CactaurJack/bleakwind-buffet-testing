using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace Data.Drinks
{
    class ArentinoAppleJuice
    {
        public Size Size { get; set; } = Size.Small;
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 44;
                if (Size == Size.Medium) return 88;
                if (Size == Size.Large) return 132;
                throw new NotImplementedException($"Unknown size of {Size}");
            }
        }

        public double Price
        {
            get
            {
                if (Size == Size.Small) return 0.62;
                if (Size == Size.Medium) return 0.87;
                if (Size == Size.Large) return 1.01;
                throw new NotImplementedException($"Unknown size of {Size}");
            }
        }

        public bool Ice { get; set; } = false;

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (Ice) { specialInstructions.Add("Add ice"); }
                return specialInstructions;
            }
        }

        public override string ToString()
        {
            return Size + " Arentino Apple Juice";
        }
        
    }
}
