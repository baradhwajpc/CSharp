using PVM.ReciptGenerator;
using PVM.ProductMaster;
using PVM.Utility;
using System;
namespace PVM.Shopping
{
    public class Store
    {
        private Cart cart;
        private Shelf shelf;
        private Counter paymentCounter;
        private string country;

        public Store()
        {
            country = "Local";
            cart = new Cart();
            paymentCounter = new Counter(country);
            shelf = new Shelf();
        }

        public void RetrieveOrderAndPlaceInCart(String name, double price, bool imported, int quantity)
        {
            Product product = shelf.SearchAndRetrieveItemFromShelf(name, price, imported, quantity);
            cart.AddItemToCart(product);
        }

        public void GetSalesOrder(int cartNumber)
        {
            switch (cartNumber)
            {
                case 1:
                    RetrieveOrderAndPlaceInCart("book", 12.49, false, 1);
                    RetrieveOrderAndPlaceInCart("music cd", 14.99, false, 1);
                    RetrieveOrderAndPlaceInCart("chocolate bar", 0.85, false, 1);
                    break;
                case 2:
                    RetrieveOrderAndPlaceInCart("box of chocolates", 10.00, true, 1);
                    RetrieveOrderAndPlaceInCart("bottle of perfume", 47.50, true, 1);
                    break;
                case 3:
                    RetrieveOrderAndPlaceInCart("bottle of perfume", 27.99, true, 1);
                    RetrieveOrderAndPlaceInCart("bottle of perfume", 18.99, false, 1);
                    RetrieveOrderAndPlaceInCart("packet of headache pills", 9.75, false, 1);
                    RetrieveOrderAndPlaceInCart("box of chocolates", 11.25, true, 1);
                    break;
                default:
                    break;
            }
        }

        public void CheckOut()
        {
            paymentCounter.BillItems(cart);
            Receipt receipt = paymentCounter.GetReceipt();
            paymentCounter.PrintReceipt(receipt);
        }

        public String GetProductName()
        {
            Console.WriteLine("Enter the product name:\n");
            return Console.ReadLine();
        }

        public double GetProductPrice()
        {
            Console.WriteLine("Enter the product price:\n");
            var input = Console.ReadLine();
            double val;
            while (!(double.TryParse(input, out val)))
            {
                Console.WriteLine("Invalid price. Enter a number");
            }

            return val;
        }

        public bool IsProductImported()
        {
            Console.WriteLine("Is product imported or not?(y/n)\n");
            var input = Console.ReadLine();
            bool isValid = false;
            while (!isValid)
            {
                if (input.ToLowerInvariant() == "y")
                    isValid = true;
                else if (input.ToLowerInvariant() == "n")
                    isValid = true;
                else
                    Console.WriteLine("Invalid input. Enter (Y/N)");
            }

            if (input == "Y")
                return true;
            else
                return false;
        }

        public int GetQuantity()
        {
            Console.WriteLine("Enter the quantity:\n");
            var input = Console.ReadLine();
            int intVal;
            while (!(int.TryParse(input, out intVal)))
            {
                Console.WriteLine("Invalid input. Enter a integer");
            }
            return intVal;
        }

        public bool IsAddAnotherProduct()
        {
            Console.WriteLine("Do you want to add another Product?(Y/N)");

            var input = Console.ReadLine();
            while (!(input.ToLowerInvariant() == "y" || input.ToLowerInvariant() == "n"))
            {
                Console.WriteLine("Invalid input. Enter (Y/N)");
            }

            bool addAnotherProduct = Utilities.ParseBoolean(Convert.ToChar(input));
            return addAnotherProduct;
        }
    }
}
