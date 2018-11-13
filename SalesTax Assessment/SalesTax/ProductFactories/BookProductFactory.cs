
namespace PVM.ProductFactories
{
   public class BookProductFactory : ProductFactory
    {
       public override ProductMaster.Product CreateProduct(string name, double price, bool imported, int quantity)
        {
            // Overridden method returns the concrete product type.
            return new ProductMaster.Book(name, price, imported, quantity);
        }
    }
}
