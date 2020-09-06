﻿using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda
    {
        public Size Size { get; set; } = Size.Small;
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 117;
                if (Size == Size.Medium) return 153;
                if (Size == Size.Large) return 205;
                throw new NotImplementedException($"Unknown size of {Size}");
            }
        }

        public double Price
        {
            get
            {
                if (Size == Size.Small) return 1.42;
                if (Size == Size.Medium) return 1.74;
                if (Size == Size.Large) return 2.07;
                throw new NotImplementedException($"Unknown size of {Size}");
            }
        }

        public bool Ice { get; set; } = true;

        private SodaFlavor flavor = SodaFlavor.Cherry;

        public SodaFlavor Flavor
        {
            get
            {
                return flavor;
            }

            set
            {
                flavor = value;
            }
        }

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if(!Ice) { specialInstructions.Add("Hold ice"); }
                return specialInstructions;
            }
        }

        public override string ToString()
        {
            return Size + " " + flavor + " Sailor Soda";
        }



    }
}

