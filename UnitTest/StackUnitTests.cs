using ContainerVervoer;

namespace UnitTest
{
    [TestClass]
    public class StackUnitTests
    {
        [TestMethod]
        public void TryAddingContainer_AddnormalContainer()
        {
            // Arrange
            var stack = new Stack(0, true);
            var container = new Container(30, false, false);

            // Act
            bool result = stack.TryAddingContainer(container);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(1, stack.containers.Count);
            Assert.AreEqual(container, stack.containers.First());
        }

        [TestMethod]
        public void TryAddingContainer_TwoValuableOnEachother()
        {
            // Arrange
            var stack = new Stack(0, true);
            var container1 = new Container(30, true, true);
            var container2 = new Container(30, true, true);

            // Act
            bool result1 = stack.TryAddingContainer(container1);
            bool result2 = stack.TryAddingContainer(container2);

            // Assert
            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
            Assert.AreEqual(1, stack.containers.Count);
            Assert.AreEqual(container1, stack.containers.First());
        }

        [TestMethod]
        public void TryAddingContainer_TwoNormalContainersOnEachother()
        {
            // Arrange
            var stack = new Stack(0, true);
            var container1 = new Container(30, false, false);
            var container2 = new Container(30, false, false);

            // Act
            bool result1 = stack.TryAddingContainer(container1);
            bool result2 = stack.TryAddingContainer(container2);

            // Assert
            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
            Assert.AreEqual(2, stack.containers.Count);
            Assert.AreEqual(container2, stack.containers.First());
            Assert.AreEqual(container1, stack.containers.Last());
        }
    }
}