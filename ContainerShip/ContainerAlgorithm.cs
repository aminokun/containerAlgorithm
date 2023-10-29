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
            int leftIndex = 0;
            int rightIndex = 0;

            int i = 0;

            void ClearCounter()
            {
                if (i == rows.Count)
                {
                    i = 0;
                    leftIndex = 0;
                    rightIndex = 0;
                    rowIndex = 0;
                }
            }

            List<Container> sortedContainers = Sorter(containers);

            foreach (Container container in sortedContainers)
            {
                if (container.isCooled)
                {
                    if (rows[rowIndex].stacks[stackIndex].CanAddContainer(container))
                    {
                        if (i % 2 == 0)
                        {
                            rows[rowIndex].stacks[stackIndex].AddContainer(container);
                            i++;
                            rightIndex++;
                            rowIndex = rows.Count - rightIndex;
                            ClearCounter();
                        }
                        else
                        {
                            rows[rowIndex].stacks[stackIndex].AddContainer(container);
                            i++;
                            leftIndex++;
                            rowIndex = leftIndex;
                            ClearCounter();
                        }
                    }
                }



            }
        }
    }
}