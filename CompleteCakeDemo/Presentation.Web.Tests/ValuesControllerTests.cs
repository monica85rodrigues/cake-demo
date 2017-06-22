namespace Presentation.Web.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Presentation.Web.Controllers;

    [TestClass]
    public class ValuesControllerTests
    {
        [TestMethod]
        public void Get_Success()
        {
            // Arrange
            var controller = new ValuesController();

            // Act
            var result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Get_WithValidId_Success()
        {
            // Arrange
            var controller = new ValuesController();

            // Act
            var result = controller.Get(1);

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
