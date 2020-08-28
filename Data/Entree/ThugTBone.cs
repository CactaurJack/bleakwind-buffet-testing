using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree
{
    class ThugTBone
    {
        /// <summary>
        /// Gets burger price
        /// </summary>
        public double Price => 6.44;

        /// <summary>
        /// Gets calories
        /// </summary>
        public uint Calories => 982;


        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                return specialInstructions;
            }
        }

        public override string ToString()
        {
            return "Thug T-Bone";
        }
    }
}
