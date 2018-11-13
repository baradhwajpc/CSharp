using PVM.ProductMaster;
namespace PVM.ProductFactories
{
        public class MedicineProductFactory : ProductFactory
        {
            
            /// <summary>
            ///  Overriding Create Product to create concrete objects 
            /// </summary>
            /// <param name="name">name of the product</param>
            /// <param name="price">product price</param>
            /// <param name="imported">is imported</param>
            /// <param name="quantity">no of items</param>
            /// <returns></returns>
            public override ProductMaster.Product CreateProduct(string name, double price, bool imported, int quantity)
            {
                // Overridden method returns the concrete product type.
                return new Medicine(name, price, imported, quantity);
            }
    }
}
