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

         var existsAdd = FindStoreItemById(prod.GetId());

         if (quantity < 0)
         {
            return null;
         }


         if (existsAdd == null)
         {
            StoreItem newItemAdd = new StoreItem(prod, quantity);
            Items.Add(newItemAdd);
            
            return newItemAdd;

         }
         else
         {
            existsAdd.SetQuantity(existsAdd.GetQuantity() + quantity);
            return existsAdd;
         }
         

      }
      public StoreItem RemoveStoreItem(int id, int quantity)
      {
         Product prod = new Product();

         var existsRemv = FindStoreItemById(prod.GetId());

         

         
         //if quantity is at zero, the quantity shall remain zero
         if (quantity <= 0)
         {
            return null;
         }
         
         //
         if (existsRemv != null)
         {
            if (existsRemv.GetQuantity() <= quantity)
            {
               existsRemv.SetQuantity(0);
               
            }
            else
            {
               existsRemv.SetQuantity(existsRemv.GetQuantity() - quantity);
            }
            return existsRemv;
         }
         else
         {
            return null;
         }
      }

      public StoreItem FindStoreItemById(int Id)
      {
         Product prod = new Product();
         StoreItem findItem = new StoreItem(prod, Id);


         if (Id == findItem.GetProduct().GetId())
         {
            return findItem;
         }
         else
         {
            return null;
         }

      }

      public List<StoreItem> GetStoreItems()
      {
         return Items;
      }


   }
}
