using PVM.ProductMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVM.ProductFactories
{
    //Abstract Factory - Concrete Implenentations are available in derieved class
    public abstract class ProductFactory
    {
        public abstract Product CreateProduct(String name, double price, bool imported, int quantity);
    }
}
