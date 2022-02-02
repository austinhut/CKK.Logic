using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
   public class Product
   {
      private int id;                        //id instance variable
      private string name;                   //name instance variable
      private decimal price;                 //price instance variable

      public int Id { get; set; }            //auto-implemented property for Id
      public string Name { get; set; }       //auto-implemented property for Name
      public decimal Price { get; set; }     //auto-implemented property for Price


      public int GetId()
      {
         return Id;
      }
      public void SetId(int Id)
      {
         id = Id;
      }
      public string GetName()
      {
         return Name;
      }
      public void SetName(string Name)
      {
         name = Name;
      }
      public decimal GetPrice()
      {
         return Price;
      }
      public void SetPrice(decimal Price)
      {
         price = Price;
      }
   }
}
