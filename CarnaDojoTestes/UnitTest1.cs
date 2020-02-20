using CarnaDojo.Classes;
using NUnit.Framework;

namespace CarnaDojoTestes
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            //Arrange
            var variavel = 10;

            //Act
            variavel--;

            //Assert
            Assert.AreEqual(variavel, 9);
        }
    }
}