using PVM.ProductMaster;
using System.Collections.Generic;

namespace PVM.Shopping
{
    public class Cart
    {
        private List<Product> productList { get; set; }
        public Cart()
        {
            productList = new List<Product>();
        }

        public void AddItemToCart(Product product)
        {
            productList.Add(product);
        }

        public List<Product> GetItemsFromCart()
        {
            return productList;
        }

        public int GetCartSize()
        {
            return productList.Count;
        }
    }
}
