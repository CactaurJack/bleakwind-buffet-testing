using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace Data.Drinks
{
    class WarriorWater
    {
        public Size Size { get; set; } = Size.Small;
        public uint Calories
        {
            get
            {
                return 0;
            }
        }

        public double Price
        {
            get
            {
                return 0.0;
            }
        }

        public bool Ice { get; set; } = true;
        public bool Lemon { get; set; } = false;

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!Ice) { specialInstructions.Add("Hold ice"); }
                if (Lemon) { specialInstructions.Add("Add Lemon"); }
                return specialInstructions;
            }
        }

        public override string ToString()
        {
            return Size + " Warrior Water";
        }
    }
}
