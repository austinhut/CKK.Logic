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
            if (quantity < 1)
            {
                return null;
            }
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
                return _Product3;
            }
            return null;

        }


        //
        //public ShoppingCartItem AddProduct(Product prod)
        //{
                
        //}






   }
}
