using PVM.Utility;
namespace PVM.Calculations
{
    public class LocalTaxCalculator : ITaxCalculator
    {
        // Tax calculation for various products is constant.
        /// <summary>
        /// Returns tax based on import
        /// </summary>
        /// <param name="price"></param>
        /// <param name="localTax"></param>
        /// <param name="imported"></param>
        /// <returns></returns>
        public double CalculateTax(double price, double localTax, bool imported)
        {
            double tax = price * localTax;
            if (imported)
                tax += (price * 0.05);
            tax = Utilities.RoundOff(tax);
            return tax;
        }
    }
}
