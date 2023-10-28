using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace containership
{
    public class ContainerAlgorithm
    {
        //Sort containers by type and size
        public List<Container> Sorter(List<Container> containers)
        {
           List<Container> sortedContainers = containers
                .OrderByDescending(cooled => cooled.isCooled && !cooled.isValuable)
                .ThenByDescending(cooledValuable => cooledValuable.isValuable && cooledValuable.isCooled)
                .ThenByDescending(normal => !normal.isCooled && !normal.isValuable)
                .ThenByDescending(valuable => valuable.isValuable && !valuable.isCooled)
                .ThenByDescending(weight => weight.Weight)
                .ToList();
            return sortedContainers;
        }

        public void Placer(List<Row> rows, List<Container> containers)
        {
            int rowIndex = 0;
            int stackIndex = 0;

            List<Container> sortedContainers = Sorter(containers);

            foreach (Container container in sortedContainers)
            {
                if (container.isCooled)
                {
                    if (rows[rowIndex].stacks[stackIndex].CanAddContainer(container))
                    {
                        rows[rowIndex].stacks[stackIndex].AddContainer(container);
                        sortedContainers.Remove(container);
                        rowIndex++;
                    }
                }
            }
        }
    }
}