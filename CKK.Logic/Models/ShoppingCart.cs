using CKK.Logic.Models;

namespace CKK.Logic.Models
{
   public class ShoppingCart
   {
        private Customer Customer;              //customer instance variable
        private ShoppingCartItem _Product1;     //shopping cart product 1 instance variable
        private ShoppingCartItem _Product2;     //shopping cart product 2 instance variable
        private ShoppingCartItem _Product3;     //shopping cart product 3 instance variable

        
        //Shopping Cart constructor
        public ShoppingCart(Customer cust)
        {
            Customer = cust;    
        }

        //calling method GetId from Customer class
        public int GetCustomerId()
        {
            return Customer.GetId();
        }
        
        
        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            
            //checking for a valid quantity of product before continuing 
            if (quantity < 1)
            {
                return null;
            }
           
            //checking for a valid product (hence != null) AND checks to make sure that the product and it's
            //ID are equal this instance of prod and it's corresponding ID.
            if (_Product1 != null && _Product1.GetProduct().GetId() == prod.GetId())
            {
                _Product1.SetQuantity(_Product1.GetQuantity() + quantity);

                return _Product1;
            }
            else if (_Product2 != null && _Product2.GetProduct().GetId() == prod.GetId())
            {
                _Product2.SetQuantity(_Product2.GetQuantity() + quantity);

                return _Product2;
            }
           
            else if (_Product3 != null && _Product3.GetProduct().GetId()  == prod.GetId())
            {
                _Product3.SetQuantity(_Product3.GetQuantity() + quantity);

                return _Product3;
            }
            
            //checking for instance where a new product is added
            
            //the condition of the if statement checks to see if the new product is being added to _Product1.
            //if that is the case, the product would not equal what was previously in _Product1, hence it being 
            //equal to null. if the product is equal to null, we then set the value of _Product1 to the instance 
            //of Product (prod) that we are working with. 
            if (_Product1.GetProduct() == null)
            {
                _Product1.SetProduct(prod);

                return _Product1;
            }
            if (_Product2.GetProduct() == null)
            {
                _Product2.SetProduct(prod);
                
                return _Product2;
            }
            else if (_Product3.GetProduct() == null)
            {
                _Product3.SetProduct(prod);

                return _Product3;
            }
            return null;
        }

      
      //Calling above method with new paramters (Product = prod, quantity = 1)
      public ShoppingCartItem AddProduct(Product prod)
      {
         return AddProduct(prod, 1);

      }

      public ShoppingCartItem RemoveProduct(Product prod, int quantity)
      {
         if (_Product1 != null && _Product1.GetProduct().GetId() == prod.GetId())
         {
            
            _Product1.SetQuantity(_Product1.GetQuantity() - quantity);
            
            if (_Product1.GetQuantity() < 1)
            {
               return null;
            }
            
            return _Product1;
         }
         else if (_Product2 != null && _Product2.GetProduct().GetId() == prod.GetId())
         {
            _Product2.SetQuantity(_Product2.GetQuantity() - quantity);

            if (_Product2.GetQuantity() < 1)
            {
               return null;
            }

            return _Product2;
         }
         else if (_Product3 != null && _Product3.GetProduct().GetId() == prod.GetId())
         {
            _Product3.SetQuantity(_Product3.GetQuantity() - quantity);

            if (_Product3.GetQuantity() < 1)
            {
               return null;
            }

            return _Product3;
         }
         return null;
      }

      //public ShoppingCartItem GetProductById(int id)
      //{

      //}

      //public ShoppingCartItem GetProduct(int productNum)
      //{

      //}







   }
}
