using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloDIO;

namespace HelloDIOTest
{
    [TestClass]
    public class SaudacoesTest
    {
        [TestMethod]
        public void SaudacaoTest()
        {
            // Arrange
            var s = "Olá Digital Innovation One!";
            var hello = new Saudacoes();

            // Act
            var result = hello.Saudacao(s);

            // Assert
            Assert.AreEqual(s, result);
        }
    }
}
