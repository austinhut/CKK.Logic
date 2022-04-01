using System.Collections.Generic;
using System.Linq;

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


      public ShoppingCartItem RemoveProduct(int id, int quantity)
      {
         var existsRemv = GetProductById(id);

         if (existsRemv != null && existsRemv.GetProduct().GetId() == id)
         {

            existsRemv.SetQuantity(existsRemv.GetQuantity() - quantity);

            if (existsRemv.GetQuantity() < 0)
            {
               existsRemv.SetQuantity(0);
               
               Products.Remove(existsRemv);
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

         return Products.FirstOrDefault(p => p.GetProduct().GetId() == Id);
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
            grandTotal += Total;

            //grandTotal += element.GetTotal();
         }
         return grandTotal;
      }


      //returns the product in whichever product slot is being summoned (productNum1, 1, or 3)
      public List<ShoppingCartItem> GetProducts()
      {
         //LINQ count of list contents
         int totalElements = Products.Count();

         return Products;
      }
   }
}
