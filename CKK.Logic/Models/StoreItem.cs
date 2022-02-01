using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
   class StoreItem
   {
      private Product product;         //product instance variable
      private int quantity;            //quantity instance variable


      //StoreItem constructor; sets the constructor's
      //properties to their corresponding public values
      public StoreItem(Product product, int quantity)
         {
            Product = product;
            Quantity = quantity;
         }
      public Product Product { get; set; }         //auto-implemented property for Product
      public int Quantity { get; set; }            //auto-implemented property for Quantity
   }
}
