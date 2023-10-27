using containership;

namespace ContainerShip.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ContainerAlgorithm_WhenGivenAListOfContainers_ReturnsSortedList()
        {
            //Arrange

            Container C1 = new Container(20000, true, false);
            Container C2 = new Container(10000, true, false);
            Container C3 = new Container(7000, true, false);
            Container C4 = new Container(4000, true, false);
            Container CV1 = new Container(6000, true, true);
            Container CV2 = new Container(5500, true, true);
            Container CV3 = new Container(4500, true, true);
            Container N1 = new Container(30000, false, false);
            Container N2 = new Container(25000, false, false);
            Container V1 = new Container(12000, false, true);
            Container V2 = new Container(10000, false, true);

            List<Container> TestContainers = new(){ 
            C2 , C4 , C3 , C1 , CV2 , CV3 , CV1 , N2 , N1 , V2, V1
            };

            List<Container> CorrectOrder = new(){
            C1 , C2 , C3 , C4 , CV1 , CV2 , CV3 , N1 , N2 , V1 , V2
            };


            ContainerAlgorithm containerSorter = new ContainerAlgorithm();

            // Act
            List<Container> sortedContainers = containerSorter.Sorter(TestContainers);

            // Assert
            Assert.That(sortedContainers, Is.EqualTo(CorrectOrder));

            Assert.Pass();
        }
    }
}