
namespace PVM.Calculations
{
    public interface ITaxCalculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="price">Product Price</param>
        /// <param name="tax">Product Tax</param>
        /// <param name="imported">Is Imported</param>
        /// <returns></returns>
        double CalculateTax(double price, double tax, bool imported);
    }
}
