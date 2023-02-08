using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile: Animal 
    {
        public Reptile()
        {
            isScaley = true;
            LegCount = 4;
            isAmphibious = false;
            NumberOfTeeth = 2;
        }

        public bool isScaley { get; set; }
        public bool isAmphibious { get; set; }
        public bool hasLegs { get; set; }   

        public int NumberOfTeeth { get; set; }








    }
}
