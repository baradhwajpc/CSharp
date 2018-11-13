using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PVM.ProductMaster;
namespace PVM.ProductFactories
{
    public class MiscellaneousProductFactory:ProductFactory
    {
        public override ProductMaster.Product CreateProduct(string name, double price, bool imported, int quantity)
        {
            // Overridden method returns the concrete product type.
            return new MiscellaneousProduct(name, price, imported, quantity);
        }
    }
}
