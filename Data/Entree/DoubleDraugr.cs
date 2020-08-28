using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree
{
    class DoubleDraugr
    {
        /// <summary>
        /// Gets burger price
        /// </summary>
        public double Price => 7.32;

        /// <summary>
        /// Gets calories
        /// </summary>
        public uint Calories => 843;

        public bool Tomato { get; set; } = true;

        public bool Lettuce { get; set; } = true;

        public bool Mayo { get; set; } = true;

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!Tomato) { specialInstructions.Add("Hold tomato"); };
                if (!Lettuce) { specialInstructions.Add("Hold lettuce"); };
                if (!Mayo) { specialInstructions.Add("Hold mayo"); };
                return specialInstructions;
            }
        }

        public override string ToString()
        {
            return "Double Drauger";
        }
    }
}
