using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PVM.Calculations;
using PVM.ProductFactories;
namespace PVM.ProductMaster
{
    public class Medicine : Product
    {
         public Medicine()
            : base()
        {

        }

         public Medicine(String name, double price, bool imported, int quantity)
            : base(name, price, imported, quantity)
        {
        }

        public override ProductFactories.ProductFactory GetFactory()
        {
            return new MedicineProductFactory();
        }
        /// <summary>
        /// Each product has a defined tax value that needs to be overridden from the base class
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public override double GetTaxValue(string country)
        {
            if (country == "Local")
                return LocalTax.MEDICAL_TAX;
            else
                return 0;
        }
    }
}
