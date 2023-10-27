using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace containership
{
    public class Ship
    {
        private List<Row> rows = new List<Row>();
        private int MaxLength { get; }
        private int MaxWidth { get; }
        private int MinWeight { get; set; }

        private void CalcMinWeight(int maxStackWeight)
        {
            int totalSpace = MaxLength * MaxWidth;
            int totalWeight = totalSpace * maxStackWeight;
            MinWeight = totalWeight / 2;
        }


        public Ship(int maxLength, int maxWidth)
        {
            if (maxLength <= 0 || maxWidth <= 0)
            {
                throw new ArgumentException("Both maxLength and maxWidth must be greater than zero.");
            }

            MaxLength = maxLength;
            MaxWidth = maxWidth;

            for (int i = 0; i < maxWidth; i++)
            {
                rows.Add(new Row(maxLength));
            }
            int maxStackWeight = new Stack().MaxStackWeight;
            CalcMinWeight(maxStackWeight);
        }


        public override string ToString()
        {
            return "Ship:\n    " +  MaxLength.ToString() + " Wide, " +  MaxWidth.ToString() + " Long, " +  MinWeight.ToString() + " Kg Min Weight";
        }
    }
}