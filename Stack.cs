using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace containership
{
    public class Stack
    {
        public int MaxStackWeight = 120000;
        List<Container> containers = new List<Container>();
        public int Count()
        {
            return containers.Count;
        }

        public Container TopContainer(List<Container> sortedStack)
        {
            return sortedStack.Last();
        }
    }
}