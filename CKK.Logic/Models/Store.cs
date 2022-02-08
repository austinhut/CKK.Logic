using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
   public class Store
   {
      private int _Id;
      private string _Name;
      private Product _Product1;
      private Product _Product2;
      private Product _Product3;

      public int GetId()
      {
         return _Id;
      }
      public void SetId(int id)
      {
         _Id = id;
      }
      public string GetName()
      {
         return _Name;
      }
      public void SetName(string name)
      {
         _Name = name;
      }


      public void AddStoreItem(Product prod)
      {
         if (_Product1 == null)
         {
            _Product1 = prod;
         }
         else if (_Product2 == null)
         {
            _Product2 = prod;
         }
         else if (_Product3 == null)
         {
            _Product3 = prod;
         }

      }
      public void RemoveStoreItem(int productNum)
      {
         if (_Product1 != null)
         {
            _Product1 = null;
         }
         else if (_Product2 != null)
         {
            _Product2 = null;
         }
         else if (_Product3 != null)
         {
            _Product3 = null;
         }
         
      }

      public Product GetStoreItem(int productNum)
      {
         if (_Product1 != null)
         {
            return _Product1;
         }
         else if (_Product2 != null)
         {
            return _Product2;
         }
         else if (_Product3 != null)
         {
            return _Product3;
         }
         
      }

      public int FindStoreItembyId(int Id)
      {
         if (_Product1 != null)
         {
            _Product1.GetId();
         }
         else if (_Product2 != null)
         {
            _Product2.GetId();
         }
         else if (_Product3 != null)
         {
            _Product3.GetId();
         }
      }


   }
}
