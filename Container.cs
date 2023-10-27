using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace containership
{
    public class Container
    {
        int Weight { get; set; }
        public bool isCooled { get; private set; }
        public bool isValuable { get; private set; }

        public Container(int weight, bool isCooled, bool isValuable)
        {
            Weight = weight;
            this.isCooled = isCooled;
            this.isValuable = isValuable;
        }

        public override string ToString()
        {
            return "Container:\n    " + this.Weight.ToString() + "Kg, " + " Cooled: " + this.isCooled.ToString() + "Valuable: " + this.isValuable.ToString() ;
        }
    }
}