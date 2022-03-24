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
      private Store store;
      //private Product _Product1;
      //private Product _Product2;
      //private Product _Product3;

      private List<StoreItem> Items;




      //"Store" constructor
      public Store()
      {
         Items = new List<StoreItem>();
      }

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

      public StoreItem AddStoreItem(Product prod, int quantity)
      {

         var exists = FindStoreItemById(prod.GetId());

         if (quantity < 0)
         {
            return null;
         }


         if (exists == null)
         {
            StoreItem newItem = new StoreItem(prod, quantity);
            Items.Add(newItem);
            
            return newItem;

         }
         else
         {
            exists.SetQuantity(exists.GetQuantity() + quantity);
            return exists;
         }
         

      }
      public StoreItem RemoveStoreItem(int id, int productNum)
      {
         if (productNum == 1)
         {
            _Product1 = null;
         }
         else if (productNum == 2)
         {
            _Product2 = null;
         }
         else if (productNum == 3)
         {
            _Product3 = null;
         }

      }

      public StoreItem FindStoreItemById(int Id)
      {
         if (_Product1.GetId() == Id)
         {
            return _Product1;
         }
         else if (_Product2.GetId() == Id)
         {
            return _Product2;
         }
         else if (_Product3.GetId() == Id)
         {
            return _Product3;
         }
         return null;
      }

      public List<StoreItem> GetStoreItems()
      {
         if (productNum == 1)
         {
            return _Product1;
         }
         else if (productNum == 2)
         {
            return _Product2;
         }
         else if (productNum == 3)
         {
            return _Product3;
         }
         return null;
      }


   }
}
