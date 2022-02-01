using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
   public class Customer
   {
      private int id;            //instance variable for id
      private string name;       //instance variable for name
      private string address;    //instance variable for address

      public int Id { get; set; }            //auto-implemented property for Id
      public string Name { get; set; }       //auto-implemented property for Name
      public string Address { get; set; }    //auto-implemented property for Address
   }
}
