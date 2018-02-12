using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
         
            string choice = "";
            //--------------------------------Q1a(i - x)----------------------------------//
            List<Product> inventory = new List<Product>()
            {
                new Product("lettuce", 10.5 , 50, "Leafy green"),
                new Product("cabbage", 20 , 100, "Cruciferous"),
                new Product("pumpkin", 30 , 30, "Marrow"),
                new Product("cauliflower", 10 , 25, "Cruciferous"),
                new Product("zucchini", 20.5 , 50, "Marrow"),
                new Product("yam", 30 , 50, "Root"),
                new Product("spinach", 10 , 100, "Leafy green"),
                new Product("broccoli", 20.2 , 75, "Cruciferous"),
                new Product("Garlic", 30 , 20, "Leafy green"),
                new Product("silverbeet", 10 , 50, "Marrow")
            };
            Console.WriteLine("1. See the products listed by their type");
            Console.WriteLine("2. Check out the total price of the inventory");
            Console.WriteLine("3. Check out the average price of all products in the inventory");
            Console.WriteLine("4. See a list of costly products and a list of cheap products");
            Console.WriteLine("5. Exit");
            //--------------------------------Q1a(xi - xiv)------------------------------------//
            do
            {
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("Enter your choice among 1,2,3,4 and 5.");

                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":

                        List<Product> leafy_green = inventory.FindAll(x => x.type == "Leafy green");
                        Console.WriteLine("The leafy green products are:  ");
                        foreach (Product leafy in leafy_green)
                        {
                            Console.WriteLine(leafy.name + "   ");
                        }
                        Console.WriteLine("------------------------------------------------------");


                        List<Product> marrow = inventory.FindAll(x => x.type == "Marrow");
                        Console.WriteLine("The marrow products are:  ");
                        foreach (Product mar in marrow)
                        {
                            Console.WriteLine(mar.name + "   ");
                        }
                        Console.WriteLine("------------------------------------------------------");


                        List<Product> root = inventory.FindAll(x => x.type == "Root");
                        Console.WriteLine("The root products are:  ");
                        foreach (Product roo in root)
                        {
                            Console.WriteLine(roo.name + "   ");
                        }
                        Console.WriteLine("------------------------------------------------------");


                        List<Product> cruciferous = inventory.FindAll(x => x.type == "Cruciferous");
                        Console.WriteLine("The cruciferous products are:  ");
                        foreach (Product cruc in cruciferous)
                        {
                            Console.WriteLine(cruc.name + "   ");
                        }
                        break;


                    case "2":

                        double total_price = 0;
                        foreach (var item in inventory)
                        {
                            total_price += item.quantity * item.price;
                        }
                        Console.WriteLine("Total price of the inventory : Rs." + total_price);
                        break;


                    case "3":

                        total_price = 0;
                        foreach (var item in inventory)
                        {
                            total_price += item.quantity * item.price;
                        }
                        Console.WriteLine("Average price of all products in inventory : Rs." + (total_price / inventory.Count));
                        break;


                    case "4":

                        List<Product> cheap = inventory.FindAll(x => x.price <= 50);
                        List<Product> costly = inventory.FindAll(x => x.price > 50);
                        Console.WriteLine("Price > Rs.50 is considered as costly and Price <= Rs.50 is cheap");
                        
                        if (cheap.Count > 0)
                        {
                            Console.WriteLine("The cheap products are: ");
                            foreach (Product item in cheap)
                            {
                                Console.WriteLine(item.name + " for Rs." + item.price);
                            }
                        }
                        else
                        {
                            Console.WriteLine("There is no cheap product");
                        }

                        Console.WriteLine("-----------------------------------------------");
                        if (costly.Count > 0)
                        {
                            Console.WriteLine("The costly products are: ");
                            foreach (Product item in costly)
                            {
                                Console.WriteLine(item.name + " for Rs." + item.price);
                            }
                        }
                        else
                        {
                            Console.WriteLine("There is no costly product");
                        }
                        break;

                    case "5":
                        choice = "5";
                        break;

                    default:
                        Console.WriteLine("Oops! Wrong Choice!");
                        break;
                }
            } while (choice != "5");

        }
    }
    class Product
    {
        public string name;
        public double quantity;
        public double price;
        public string type;
        public Product(string n, double p, double q, string t)
        {
            name = n;
            quantity = q;
            price = p;
            type = t;
        }
        
    }
}
