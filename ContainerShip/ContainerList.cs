﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using containership;


namespace ContainerShip
{
    public class ContainerList
    {
        public ContainerList() 
        {

        }

        public List<Container> TestContainerList()
        {
            Container C1 = new Container(20000, true, false);
            Container C2 = new Container(10000, true, false);
            Container C3 = new Container(7000, true, false);
            Container C4 = new Container(4000, true, false);
            //Container CV1 = new Container(6000, true, true);
            //Container CV2 = new Container(5500, true, true);
            //Container CV3 = new Container(4500, true, true);
            //Container N1 = new Container(30000, false, false);
            //Container N2 = new Container(25000, false, false);
            //Container V1 = new Container(12000, false, true);
            //Container V2 = new Container(10000, false, true);

            List<Container> TestContainers = new(){
            C2 , C4 , C3 , C1 /*, CV2 , CV3 , CV1 , N2 , N1 , V2, V1*/
            };

            return TestContainers;
        }
    }
}
