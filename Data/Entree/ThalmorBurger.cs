using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree
{
    class ThalmorBurger
    {
        /// <summary>
        /// Gets burger price
        /// </summary>
        public double Price => 8.32;

        /// <summary>
        /// Gets calories
        /// </summary>
        public uint Calories => 943;

        public bool Bacon { get; set; } = true;

        public bool Egg { get; set; } = true;

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!Bacon) { specialInstructions.Add("Hold bacon"); };
                if (!Egg) { specialInstructions.Add("Hold egg"); };
                return specialInstructions;
            }
        }

        public override string ToString()
        {
            return "Thalmor Burger";
        }
    }
}
