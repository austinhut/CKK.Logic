using System;
using Xunit;
using CKK.Logic.Models;

namespace CKK_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TotalOfProductIsCorrect()
        {
            //Arrange (Setting up test)
            decimal price = 10.49m;
            int quantity = 4;

            decimal expected = 41.96m;

            Product prod = new Product()
            
            //Act (Action that is being tested)
            

            //Assert (What is to be expected from test compared to actual value)
            Assert.Equal(expected, actual);
        }
    }
}
