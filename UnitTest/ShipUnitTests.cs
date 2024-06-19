using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContainerVervoer;
using ContainerVervoer.Error;
using System.Collections.Generic;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class ShipTests
    {
        private Ship _ship;

        [TestInitialize]
        public void Setup()
        {
            _ship = new Ship(10, 5);
        }

        [TestMethod]
        public void ShipInitializationTest()
        {
            Assert.AreEqual(10, _ship.length);
            Assert.AreEqual(5, _ship.width);
            Assert.AreEqual(10 * 5 * 150, _ship.maxWeight);
            Assert.AreEqual(10 * 5 * 75, _ship.minWeight);
            Assert.AreEqual(0, _ship.TotalWeight);
        }

        [TestMethod]
        public void AddContainerToShipTest()
        {
            Container container = new Container(10, false, false);
            _ship.Containers.Add(container);
            Assert.AreEqual(1, _ship.Containers.Count);
            Assert.AreEqual(10, _ship.TotalWeight);
        }

        [TestMethod]
        public void DistributeContainersTest()
        {
            Container container1 = new Container(10, true, false);
            Container container2 = new Container(20, false, true);
            Container container3 = new Container(15, true, true);
            Container container4 = new Container(5, false, false);
            _ship.Containers.AddRange(new List<Container> { container1, container2, container3, container4 });

            bool result = _ship.DistributeContainers();
            Assert.IsTrue(result);
            Assert.AreEqual(0, _ship.SortedContainers.Count);
        }
    }
}