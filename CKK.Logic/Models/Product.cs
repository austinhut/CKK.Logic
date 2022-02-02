using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
   public class Product
   {
      private int Id;                        //id instance variable
      private string Name;                   //name instance variable
      private decimal Price;                 //price instance variable




      public int GetId()
      {
         return Id;
      }
      public void SetId(int id)
      {
         Id = id;
      }
      public string GetName()
      {
         return Name;
      }
      public void SetName(string name)
      {
         Name = name;
      }
      public decimal GetPrice()
      {
         return Price;
      }
      public void SetPrice(decimal price)
      {
         Price = price;
      }
   }
}
