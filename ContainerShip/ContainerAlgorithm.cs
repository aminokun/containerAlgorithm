using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            int stackIndex;
            int leftIndex = 0;
            int rightIndex = 0;
            int i = 0;
            bool isContainerAdded;

            int maxStack = rows.Count() - 1;

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
                bool normalContainer = !container.isCooled && !container.isValuable;
                bool cooledContainer = container.isCooled;
                bool valuableContainer = container.isValuable && !container.isCooled;


                if (cooledContainer)
                {
                    if (rows[rowIndex].stacks[0].CanAddContainer(container))
                    {
                        if (i % 2 == 0)
                        {
                            rows[rowIndex].stacks[0].AddContainer(container);
                            i++;
                            rightIndex++;
                            rowIndex = rows.Count - rightIndex;
                            ClearCounter();
                        }
                        else
                        {
                            rows[rowIndex].stacks[0].AddContainer(container);
                            i++;
                            leftIndex++;
                            rowIndex = leftIndex;
                            ClearCounter();
                        }
                    }
                }

                if (normalContainer)
                {
                    stackIndex = 1;
                    isContainerAdded = false;
                    while (isContainerAdded == false)
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
                                isContainerAdded = true;
                            }
                            else
                            {
                                rows[rowIndex].stacks[stackIndex].AddContainer(container);
                                i++;
                                leftIndex++;
                                rowIndex = leftIndex;
                                ClearCounter();
                                isContainerAdded = true;
                            }
                        }
                        else
                        {
                            if(stackIndex < maxStack)
                            {
                                stackIndex++;
                            }
                        }
                    }
                }
            
                if(valuableContainer)
                {

                }
            }
        }
    }
}