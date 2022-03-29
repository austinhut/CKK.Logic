using System.Collections.Generic;

namespace CKK.Logic.Models
{
   public class ShoppingCart
   {
      private Customer Customer;   //customer instance variable
                                              

      private List<ShoppingCartItem> Products;


      //Shopping Cart constructor
      public ShoppingCart(Customer cust)
      {
         Customer = cust;
         Products = new List<ShoppingCartItem>();
      }

      //calling method GetId from Customer class
      public int GetCustomerId()
      {
         return Customer.GetId();
      }


      public ShoppingCartItem AddProduct(Product prod, int quantity)
      {

         var existsItemAdd = GetProductById(prod.GetId());

         if (quantity < 0)
         {
            return null;
         }

         if (existsItemAdd == null)
         {
            ShoppingCartItem newItemAdd = new ShoppingCartItem(prod, quantity);
            Products.Add(newItemAdd);

            return newItemAdd;
         }

         else
         {

            existsItemAdd.SetQuantity(existsItemAdd.GetQuantity() + quantity);

            return existsItemAdd;
         }

      }


      //Calling above method with new paramters (Product = prod, quantity = 1)
      public ShoppingCartItem AddProduct(Product prod)
      {
         return AddProduct(prod, 1);

      }


      //this method removes a single quantity of a product using the product's ID
      //if the ID matches, a single "quantity" is subracted from the existing quantity 
      //and the new quantity is set through the set quantity accessor
      public ShoppingCartItem RemoveProduct(Product prod, int quantity)
      {
         var existsRemv = GetProductById(prod.GetId());

         //if the value is going to be less than or equal to zero at the end,
         //then it SHOULD remove the item from the shopping cart but still return
         //the ShoppingCartItem with a quantity of 0.*
         if (quantity <= 0)
         {
            //not sure if right, ask Q about this
            Products.Remove(existsRemv);

            return null;
         }

         if (existsRemv != null)
         {
            if (existsRemv.GetQuantity() <= quantity)
            {
               existsRemv.SetQuantity(0);
            }
            else
            {
               existsRemv.SetQuantity(existsRemv.GetQuantity() - quantity);

              
            }
            return existsRemv;
         }
         else
         {
            return null;
         }

      }

      //search for a specfic product by its product id, returns the product with a matching id, else returns null
      public ShoppingCartItem GetProductById(int Id)
      {

         Product prod = new Product();
         ShoppingCartItem getItem = new ShoppingCartItem(prod, Id);

         if (Id == getItem.GetProduct().GetId())
         {
            return getItem;
         }
         else
         {
            return null;
         }
      }


      //adds the total price of the products and their selected quantities(if the is NOT null), then returns the total
      public decimal GetTotal()
      {
         
         decimal grandTotal = 0;

         foreach (var element in Products)
         {
            var Price = element.GetProduct().GetPrice();
            var Qty = element.GetQuantity();
            decimal Total = Price * Qty;
            grandTotal = Total;

            //grandTotal += element.GetTotal();
         }
         
         return grandTotal;


      }


      //returns the product in whichever product slot is being summoned (productNum1, 1, or 3)
      public List<ShoppingCartItem> GetProducts()
      {
         return Products;

      }
   }
}
