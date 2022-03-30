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
            try
            {
                //Arrange (Setting up test)

                decimal expPrice = 10.49m;
                decimal expQuantity = 3m;

                Product prod = new Product();
                ShoppingCartItem cartItem = new ShoppingCartItem(prod, 3);
               cartItem.GetProduct().SetPrice(expPrice);
                

                //Act (Action that is being tested)
                
                decimal expected = expPrice * expQuantity;

                decimal actual = cartItem.GetTotal();

                //Assert (What is to be expected from test compared to actual value)

                Assert.Equal(expected, actual);
            }
            catch
            {
                throw new Exception("Total of product is incorrect");
            }
        }

        [Fact]
        public void SucessfullAddProduct()
        {
            try
            {
                //Arrange (Setting up test)

                Product prodAdd = new();
                Customer cust = new Customer();
                ShoppingCart newCart = new ShoppingCart(cust);

                //Act (Action that is being tested)
                
                cust.SetId(1);
                prodAdd.SetId(1);
                

                var actProdAdded = newCart.AddProduct(prodAdd, 3).GetQuantity();


                //Assert (What is to be expected from test compared to actual value)

                Assert.Equal(3, actProdAdded);
            }
            catch
            {
                throw new Exception("Product was not successfully added");
            }

        }

        [Fact]
        public void SuccessfulRemoveProduct()
        {
        try
        {
           //Arrange (Setting up test)
           Product prodRemove = new();
           Customer cust = new Customer();
           ShoppingCart newCart = new ShoppingCart(cust);
           Store newStore = new();
           
           var prodRemv = new Product();

           prodRemv.SetId(1);


           //Act (Action that is being tested)


           newStore.AddStoreItem(prodRemv, 3);

           var prodRmv = newStore.RemoveStoreItem(prodRemove.GetId(), 2).GetQuantity();

           


           //Assert (What is to be expected from test compared to actual value)
           Assert.Equal(1, prodRmv);
        }

        catch
           {
           throw new Exception("Product was not removed successfully");
           }
        }
    }
}



