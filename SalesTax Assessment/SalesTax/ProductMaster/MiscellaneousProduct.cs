using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PVM.Calculations;
using PVM.ProductFactories;
namespace PVM.ProductMaster
{
    public class MiscellaneousProduct:Product
    {
        public MiscellaneousProduct()
            : base()
        {
        }

        public MiscellaneousProduct(String name, double price, bool imported, int quantity)
            : base(name, price, imported, quantity)
        {
        }
        public override ProductFactories.ProductFactory GetFactory()
        {
            return new MiscellaneousProductFactory();
        }
        /// <summary>
        /// Each product has a defined tax value that needs to be overridden from the base class
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public override double GetTaxValue(string country)
        {
            if (country == "Local")
                return LocalTax.MISC_TAX;
            else
                return 0;
        }
    }
}
