using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
   public class Store
   {
      private int _id;
      private string _name;
      private Product _product1;
      private Product _product2;
      private Product _product3;

      public int GetId()
      {
         return _id;
      }
      public void SetId(int id)
      {
         _id = id;
      }
      public string GetName()
      {
         return _name;
      }
      public void SetName(string name)
      {
         _name = name;
      }


      public void AddStoreItem(Product prod)
      {
         if (_product1 == null)
         {
            _product1 = prod;
         }
         else if (_product2 == null)
         {
            _product2 = prod;
         }
         else if (_product3 == null)
         {
            _product3 = prod;
         }

      }
      public void RemoveStoreItem(int productNum)
      {
         if (_product1 != null)
         {
            _product1 = null;
         }
         else if (_product2 != null)
         {
            _product2 = null;
         }
         else if (_product3 != null)
         {
            _product3 = null;
         }
         
      }

      //public int GetStoreItem(int productNum)
      //{
      //   if (_product1 != null)
      //   {
      //      return _product1;
      //   }
      //}



   }
}
