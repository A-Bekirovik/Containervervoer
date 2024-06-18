using ContainerVervoer;

namespace UnitTest;

[TestClass]
public class ShipUnitTests
{
    [TestMethod]
    public void DistributeContainers_SortCorrectly()
    {
        // Arrange
        var ship = new Ship(5, 3);
        ship.Containers.Add(new Container(10, false, false));
        ship.Containers.Add(new Container(15, true, false)); 
        ship.Containers.Add(new Container(20, false, true)); 
        ship.Containers.Add(new Container(25, true, true));  
        ship.Containers.Add(new Container(8, false, false)); 

        // Act
        bool result = ship.DistributeContainers();

        // Assert
        Assert.IsTrue(result);
        Assert.AreEqual(5, ship.SortedContainers.Count);

        var expectedOrder = new List<ContainerType>
            {
                ContainerType.CoolableValuable,
                ContainerType.Coolable,
                ContainerType.Valuable,
                ContainerType.Normal,
                ContainerType.Normal
            };

        CollectionAssert.AreEqual(expectedOrder, ship.SortedContainers.Select(c => c.Type).ToList());
    }
}
