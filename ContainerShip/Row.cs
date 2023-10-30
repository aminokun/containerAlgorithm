using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace containership
{
    public class Row
    {
        public List<Stack> stacks = new List<Stack>();
        private static int Length;

        public bool Contains(Container container)
        {
            return stacks.Any(stack => stack.Contains(container));
        }



        public Row(int length)
        {
            Length = length;
            for (int i = 0; i < Length; i++)
            {
                stacks.Add(new Stack());
            }
        }

    }
}