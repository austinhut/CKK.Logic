using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
   public class StoreItem
   {
      private Product Product;         //product instance variable
      private int Quantity;            //quantity instance variable


      //StoreItem constructor; sets the constructor's
      //properties to their corresponding public values
      public StoreItem(Product product, int quantity)
         {
            Product = product;
            Quantity = quantity;
         }

      public int GetQuantity()                     
      {
         return Quantity;
      }
      public void SetQuantity(int quantity)
      {
         Quantity = quantity;
      }
      public Product GetProduct()
      {
         return Product;
      }
      public void SetProduct(Product product)
      {
         Product = product;
      }
   }
}
