using CKK.Logic.Models;

namespace CKK.Logic.Models
{
   public class ShoppingCart
   {
      private Customer Customer;
      private ShoppingCartItem _Product1;
      private ShoppingCartItem _Product2;
      private ShoppingCartItem _Product3;

      private int _CustomerId;


      //Shopping Cart constructor
      public ShoppingCart(Customer cust)
      {
         Customer = cust;
      }

      public int GetCustomerId()
      {
         return _CustomerId;
      }

      public ShoppingCartItem AddProduct(Product prod, int quantity)
      {
         
      }

      public void AddProduct(Product prod)
      {
         if (prod == null)
         {
            _Product1 = prod;
         }
         else if (prod == null)
         {
            _Product2 = prod;
         }
         else if (prod == null)
         {
            _Product3 = prod;
         }
      }

      public ShoppingCartItem RemoveProduct(Product prod, int quantity)
      {
         
      }

      public decimal GetTotal()
      {
         
      }



   }
}
