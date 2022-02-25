using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingCartTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            decimal product1 = 1.23m;
            decimal product2 = 2.34m;
            decimal product3 = 3.45m;

            decimal expected = 7.02m;

            decimal actual = product1 + product2 + product3;

            Assert.AreEqual(expected, actual);




        }
    }
}
