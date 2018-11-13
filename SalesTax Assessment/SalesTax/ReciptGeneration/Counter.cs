using PVM.Calculations;
using PVM.ProductMaster;
using PVM.Shopping;
using System;
using System.Collections.Generic;
namespace PVM.ReciptGenerator
{
    public class Counter
    {
        private Cashier cashier;
        private Receipt receipt;
        private List<Product> productList;
        private String country;

        public Counter(String country)
        {
            this.country = country;
        }

        public void BillItems(Cart cart)
        {
            productList = cart.GetItemsFromCart();

            foreach (Product p in productList)
            {
                cashier = GetCashier(country);
                double productTax = cashier.CalculateTax(p.Price, p.GetTaxValue(country), p.Imported);
                double taxedCost = cashier.CalculateTotalProductCost(p.Price, productTax);
                p.TaxedCost = taxedCost;
            }
        }

        public Receipt GetReceipt()
        {
            double totalTax = cashier.CalculateTotalTax(productList);
            double totalAmount = cashier.CalculateTotalAmount(productList);
            receipt = cashier.CreateNewReceipt(productList, totalTax, totalAmount);
            return receipt;
        }

        public void PrintReceipt(Receipt receipt)
        {
            cashier.GenerateReceipt(receipt);
        }

        public Cashier GetCashier(String strategy)
        {
            CalculatorFactory factory = new CalculatorFactory();
            ITaxCalculator taxCal = factory.GetTaxCalculator(strategy);
            return new Cashier(taxCal);
        }
    }
}
