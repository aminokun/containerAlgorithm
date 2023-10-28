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
        private int currentWeight = 0;
        public int Count()
        {
            return containers.Count;
        }

        public bool Contains(Container container)
        {
            return containers.Contains(container);
        }


        public Container? TopContainer()
        {
            if (containers.Count != 0)
            {
                return containers.Last();
            }
            return null;

        }

        public bool CanAddContainer(Container container)
        {
            foreach (Container placedContainer in containers)
            {
                currentWeight += placedContainer.Weight;
            }

            if(TopContainer() != null && container.Weight + currentWeight <= MaxStackWeight && !TopContainer().isValuable) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddContainer(Container container)
        {
            containers.Add(container);
        }
    }
}