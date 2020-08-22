using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numeroaletra.Controllers;

namespace UnitTestNumeroaLetra
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLiteral1()
        {
            //Arrange
            LiteralController literalController = new LiteralController();
            int a = 5;
            string esperado = "CINCO 00 /100";

            //Act
            string resultado = literalController.LiteralGet(a);
            //Assert
            Assert.AreEqual(esperado, resultado);
        }
    }
}
