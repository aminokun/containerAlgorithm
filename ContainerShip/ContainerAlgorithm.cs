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
    }
}