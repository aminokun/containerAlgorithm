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
            //Assert.AreEqual(CorrectOrder, sortedContainers);
            Assert.That(sortedContainers, Is.EqualTo(CorrectOrder));

            Assert.Pass();
        }

        [Test]
        public void ContainerAlgorithm_WhenGivenAListOfContainersCooled_ReturnsPlacedCooledContainers_EventAmountOfRows()
        {
            //Arrange

            Container C1 = new Container(20000, true, false);
            Container C6 = new Container(20000, true, false);
            Container C2 = new Container(10000, true, false);
            Container C7 = new Container(10000, true, false);
            Container C3 = new Container(7000, true, false);
            Container C8 = new Container(7000, true, false);
            Container C4 = new Container(4000, true, false);
            Container C9 = new Container(4000, true, false);
            Container C5 = new Container(3000, true, false);
            Container C10 = new Container(3000, true, false);

            List<Container> TestCooledContainers = new(){
            C2 , C4 , C3 , C1 , C5 , C6 , C7 , C8 , C9 , C10
            };

            ContainerAlgorithm containerPlacer = new ContainerAlgorithm();
            Ship ship = new Ship(4, 4, TestCooledContainers);

            List<Row> rows = ship.ReturnRowsForTest();

            // Act
            containerPlacer.Placer(rows, TestCooledContainers);

            // Assert
            Assert.IsTrue(rows[0].stacks[0].Contains(C1));
            Assert.IsTrue(rows[3].stacks[0].Contains(C6));
            Assert.IsTrue(rows[1].stacks[0].Contains(C2));
            Assert.IsTrue(rows[2].stacks[0].Contains(C7));
            Assert.IsTrue(rows[0].stacks[0].Contains(C3));
            Assert.IsTrue(rows[3].stacks[0].Contains(C8));
            Assert.IsTrue(rows[1].stacks[0].Contains(C4));
            Assert.IsTrue(rows[2].stacks[0].Contains(C9));
            Assert.IsTrue(rows[0].stacks[0].Contains(C5));
            Assert.IsTrue(rows[3].stacks[0].Contains(C10));
        }

        [Test]
        public void ContainerAlgorithm_WhenGivenAListOfContainersCooled_ReturnsPlacedCooledContainers_OddAmountOfRows()
        {
            //Arrange
            Container C1 = new Container(20000, true, false);
            Container C6 = new Container(20000, true, false);
            Container C2 = new Container(10000, true, false);
            Container C7 = new Container(10000, true, false);
            Container C3 = new Container(7000, true, false);
            Container C8 = new Container(7000, true, false);
            Container C4 = new Container(4000, true, false);
            Container C9 = new Container(4000, true, false);
            Container C5 = new Container(3000, true, false);
            Container C10 = new Container(3000, true, false);

            List<Container> TestCooledContainers = new(){
            C2 , C4 , C3 , C1 , C5 , C6 , C7 , C8 , C9 , C10
            };

            ContainerAlgorithm containerPlacer = new ContainerAlgorithm();
            Ship ship = new Ship(4, 5, TestCooledContainers);

            List<Row> rows = ship.ReturnRowsForTest();

            // Act
            containerPlacer.Placer(rows, TestCooledContainers);

            // Assert
            Assert.IsTrue(rows[0].stacks[0].Contains(C1));
            Assert.IsTrue(rows[4].stacks[0].Contains(C6));
            Assert.IsTrue(rows[1].stacks[0].Contains(C2));
            Assert.IsTrue(rows[3].stacks[0].Contains(C7));
            Assert.IsTrue(rows[2].stacks[0].Contains(C3));
            Assert.IsTrue(rows[0].stacks[0].Contains(C8));
            Assert.IsTrue(rows[4].stacks[0].Contains(C4));
            Assert.IsTrue(rows[1].stacks[0].Contains(C9));
            Assert.IsTrue(rows[3].stacks[0].Contains(C5));
            Assert.IsTrue(rows[2].stacks[0].Contains(C10));
        }
    }
}