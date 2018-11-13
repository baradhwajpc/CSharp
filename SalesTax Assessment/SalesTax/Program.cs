using PVM.Shopping;
using System;
using System.Collections.Generic;

namespace PVMSalesTax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sales Tax Calculator");
            Store store = new Store();
            store.GetSalesOrder(1);
            store.CheckOut();
            store = new Store();
            store.GetSalesOrder(2);
            store.CheckOut();
            store = new Store();
            store.GetSalesOrder(3);
            store.CheckOut();
            Console.ReadLine();
        }
    }
}
