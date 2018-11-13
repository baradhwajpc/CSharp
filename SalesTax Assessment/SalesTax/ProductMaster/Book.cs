using PVM.Calculations;
using PVM.ProductFactories;
using System;

namespace PVM.ProductMaster
{
    public class Book:Product
    {
        
        public Book()
            : base()
        {
        }

        public Book(String name, double price, bool imported, int quantity)
            : base(name, price, imported, quantity)
        {

        }

        public override ProductFactory GetFactory()
        {
            return new BookProductFactory();
        }
        /// <summary>
        /// Each product has a defined tax value that needs to be overridden from the base class
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public override double GetTaxValue(string country)
        {
            if (country == "Local")
                return LocalTax.BOOK_TAX;
            else
                return 0;
        }
    }
}
