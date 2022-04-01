using System.Collections.Generic;
using System.Linq;


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
         //Product prod = new Product();

         var existsRemv = FindStoreItemById(id);

         if (existsRemv != null && existsRemv.GetProduct().GetId() == id)
         {

            existsRemv.SetQuantity(existsRemv.GetQuantity() - quantity);

            if ((existsRemv.GetQuantity() - quantity) < 0)
            {
               
               existsRemv.SetQuantity(0);
               
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
         Product prod = new();
         return Items.FirstOrDefault(p => p.GetProduct().GetId() == Id);
      }

      public List<StoreItem> GetStoreItems()
      {
         //LINQ count of total list contents
         int totalElements = Items.Count();

         return Items;
      }
   }
}
