using System;
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
            Container C5 = new Container(3000, true, false);
            Container C6 = new Container(20000, true, false);
            Container C7 = new Container(10000, true, false);
            Container C8 = new Container(7000, true, false);
            Container C9 = new Container(4000, true, false);
            Container C10 = new Container(3000, true, false);
            Container N1 = new Container(120000, false, false);
            Container N2 = new Container(119999, false, false);
            Container N3 = new Container(119998, false, false);
            Container N4 = new Container(119997, false, false);
            Container N5 = new Container(119996, false, false);
            Container N6 = new Container(119995, false, false);
            Container N7 = new Container(119994, false, false);
            Container N8 = new Container(119993, false, false);
            Container N9 = new Container(119992, false, false);
            Container N10 = new Container(119991, false, false);
            Container N11 = new Container(119989, false, false);
            Container N12 = new Container(119988, false, false);
            //Container CV1 = new Container(6000, true, true);
            //Container CV2 = new Container(5500, true, true);
            //Container CV3 = new Container(4500, true, true);
            //Container N1 = new Container(30000, false, false);
            //Container N2 = new Container(25000, false, false);
            //Container V1 = new Container(12000, false, true);
            //Container V2 = new Container(10000, false, true);




            List<Container> TestNormalContainers = new(){
            N1, N2, N3, N4, N5, N6, N7, N8, N9, N10, N11, N12
            };
            List<Container> TestContainersCooled = new(){
            C2 , C4 , C3 , C1, C5 , C6 , C7 , C8 , C9 , C10 /*, CV2 , CV3 , CV1 , N2 , N1 , V2, V1*/
            };

            return TestNormalContainers;
        }
    }
}
