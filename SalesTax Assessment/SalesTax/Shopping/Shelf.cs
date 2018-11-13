using PVM.ProductMaster;
using System;
using System.Collections.Generic;

namespace PVM.Shopping
{
    public class Shelf
    {
         private readonly Dictionary<string, Product> items;
        // Business Validation - Check if the item exist in shelf
         public Shelf()
         {
             items = new Dictionary<string, Product>();
             AddProductItemsToShelf("book", new Book());
             AddProductItemsToShelf("music cd", new MiscellaneousProduct());
             AddProductItemsToShelf("chocolate bar", new Food());
             AddProductItemsToShelf("box of chocolates", new Food());
             AddProductItemsToShelf("bottle of perfume", new MiscellaneousProduct());
             AddProductItemsToShelf("packet of headache pills", new Medicine());
         }
        // Implemeting Statergy pattern to add items to shelf 
        public void AddProductItemsToShelf(String productItem, Product productCategory)
        {
            items.Add(productItem, productCategory);
        }
        public Product SearchAndRetrieveItemFromShelf(String name, double price, bool imported, int quantity)
        {
            Product productItem = items[name].GetFactory().CreateProduct(name, price, imported, quantity);
            // Verifying if the item is available in shelf and adding to the cart 
            return productItem;
        }
        public int GetShelfSize()
        {
            return items.Count;
        }
    }
}
