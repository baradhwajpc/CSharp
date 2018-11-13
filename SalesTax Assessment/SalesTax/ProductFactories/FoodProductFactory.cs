using PVM.ProductMaster;
namespace PVM.ProductFactories
{
    public class FoodProductFactory:ProductFactory
    {
        public override ProductMaster.Product CreateProduct(string name, double price, bool imported, int quantity)
        {
            // Overridden method returns the concrete product type.
            return new Food(name, price, imported, quantity);
        }
    }
}
