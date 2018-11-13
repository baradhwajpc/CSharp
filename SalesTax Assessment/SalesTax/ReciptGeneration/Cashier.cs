using PVM.Calculations;
using PVM.ProductMaster;
using PVM.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVM.ReciptGenerator
{
    public class Cashier
    {
        ITaxCalculator taxCalculator;

        public Cashier(ITaxCalculator calculator)
        {
            taxCalculator = calculator;
        }

        public double CalculateTax(double price, double tax, bool imported)
        {

            double totalProductTax = taxCalculator.CalculateTax(price, tax, imported);
            return totalProductTax;
        }

        public double CalculateTotalProductCost(double price, double tax)
        {
            return Utilities.Truncate(price + tax);
        }

        public double CalculateTotalTax(List<Product> prodList)
        {
            double totalTax = 0.0;

            foreach (Product p in prodList)
            {
                totalTax += (p.TaxedCost - p.Price);
            }

            return Utilities.Truncate(totalTax);
        }

        public double CalculateTotalAmount(List<Product> prodList)
        {
            double totalAmount = 0.0;

            foreach (Product p in prodList)
            {
                totalAmount += p.TaxedCost;
            }

            return Utilities.Truncate(totalAmount);
        }

        public Receipt CreateNewReceipt(List<Product> productList, double totalTax, double totalAmount)
        {
            return new Receipt(productList, totalTax, totalAmount);
        }

        public void GenerateReceipt(Receipt r)
        {
            String receipt = r.ToString();
            Console.WriteLine(receipt);
        }

    }
}
