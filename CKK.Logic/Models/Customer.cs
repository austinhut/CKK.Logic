using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
   public class Customer
   {
      private int Id;            //instance variable for id
      private string Name;       //instance variable for name
      private string Address;    //instance variable for address


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
      public string GetAddress()
      {
         return Address;
      }
      public void SetAddress(string address)
      {
         Address = address;
      }

   }
}
