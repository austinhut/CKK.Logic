using System;
using Xunit;
using CKK.Logic.Models;

namespace CKK_Tests
{
    public class UnitTest1
    {
        private ShoppingCartItem _Product1;     //shopping cart product 1 instance variable
        private ShoppingCartItem _Product2;     //shopping cart product 2 instance variable
        private ShoppingCartItem _Product3;     //shopping cart product 3 instance variable

        [Fact]
        public void TotalOfProductIsCorrect()
        {
            //Arrange (Setting up test)
           
            decimal expPrice = 10.49m;
            decimal expQuantity = 3m;


            //Customer cust = new Customer();
            Product prod = new Product();
            ShoppingCartItem cartItem = new ShoppingCartItem(prod, 3);
            //ShoppingCart cart = new ShoppingCart(cust);

            //Act (Action that is being tested)
           
            decimal expected = expPrice * expQuantity;

            decimal actual = cartItem.GetTotal();

            //Assert (What is to be expected from test compared to actual value)
           
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SucessfullAddProduct()
        {
            //Arrange (Setting up test)
            
            Product expProd = new Product();
            ShoppingCartItem expCartItem = new ShoppingCartItem (expProd, 2);

            //Act (Action that is being tested)
            var expected = expProd.GetId();


            var actual = _Product1.GetProduct().GetId();


            //Assert (What is to be expected from test compared to actual value)
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SuccessfulRemoveProduct()
        {
            //Arrange (Setting up test)

            Product expProd = new Product();
            ShoppingCartItem expCartItem = new ShoppingCartItem(expProd, 1);

            //Act (Action that is being tested)

            





            //Assert (What is to be expected from test compared to actual value)
            //Assert.Equal(expProd, _Product1);
        }
    }
}
