﻿using PVM.ProductMaster;
using System;
using System.Collections.Generic;

namespace PVM.ReciptGenerator
{
    public class Receipt
    {
        private List<Product> ProductList { get; set; }
        private double TotalSalesTax { get; set; }
        private double TotalAmount { get; set; }

        public Receipt(List<Product> prod, double tax, double amount)
        {
            ProductList = prod;
            TotalSalesTax = tax;
            TotalAmount = amount;
        }

        public int GetTotalNumberOfItems()
        {
            return ProductList.Count;
        }

        public override string ToString()
        {
            String receipt = "";
            Console.WriteLine("-----------------------");
            foreach (var p in ProductList)
            {
                receipt += (p.ToString() + "\n");
            }
            receipt += "Total sales tax = " + TotalSalesTax + "\n";
            receipt += "Total amount = " + TotalAmount + "\n";
            return receipt;
        }
    }
}
