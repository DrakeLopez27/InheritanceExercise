using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird() { }

        public string wingColor { get; set; }
        public bool CanFly { get; set; }
        public bool doesMigrate { get; set; }

        public double BeakLength { get; set; }


    }
}
