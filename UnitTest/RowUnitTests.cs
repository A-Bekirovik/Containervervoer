using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContainerVervoer;
using System.Collections.Generic;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class RowTests
    {
        private Row _row;

        [TestInitialize]
        public void Setup()
        {
            _row = new Row(10, RowSides.Left);
        }

        [TestMethod]
        public void RowInitializationTest()
        {
            Assert.AreEqual(10, _row.Width);
            Assert.AreEqual(RowSides.Left, _row.Side);
            Assert.AreEqual(10, _row.RowofStacks.Count);
        }

        [TestMethod]
        public void AddNormalContainerToRowTest()
        {
            Container container = new Container(10, false, false);
            bool result = _row.TryAddingContainer(container);
            Assert.IsTrue(result);
            Assert.AreEqual(1, _row.RowofStacks[0].containers.Count);
        }

        [TestMethod]
        public void AddCoolableValuableContainerToRowTest()
        {
            Container container = new Container(10, true, true);
            bool result = _row.TryAddingContainer(container);
            Assert.IsTrue(result);
            Assert.IsTrue(_row.RowofStacks[0].containers.Contains(container));
            Assert.IsTrue(_row.HasCoolableValuableContainer);
        }

        [TestMethod]
        public void PreventAddingMultipleCoolableValuableContainersTest()
        {
            Container container1 = new Container(10, true, true);
            Container container2 = new Container(15, true, true);
            bool result1 = _row.TryAddingContainer(container1);
            bool result2 = _row.TryAddingContainer(container2);
            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }

        [TestMethod]
        public void PreventAddingCoolableContainerToNonFrontStackTest()
        {
            Row nonFrontRow = new Row(10, RowSides.Left);
            Container container = new Container(10, false, true);
            for (int i = 1; i < nonFrontRow.Width; i++)
            {
                bool result = nonFrontRow.RowofStacks[i].TryAddingContainer(container);
                Assert.IsFalse(result);
            }
        }
    }
}
