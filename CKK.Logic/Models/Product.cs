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
   }
}
