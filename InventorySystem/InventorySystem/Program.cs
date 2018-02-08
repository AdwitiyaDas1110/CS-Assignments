using System;
using System.Collections.Generic;
using System.Linq;

namespace InventorySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>();
			products.Add(new Product("lettuce", 10.5 , 50, "Leafy green"));
			products.Add(new Product("cabbage", 20, 100, "Cruciferous"));
			products.Add(new Product("pumpkin", 30 , 30, "Marrow"));
			products.Add(new Product("cauliflower", 10, 25, "Cruciferous"));
			products.Add(new Product("zucchini", 20.5, 50, "Marrow"));
			products.Add(new Product("yam", 30 , 50, "Root"));
			products.Add(new Product("spinach", 10 , 100, "Leafy green"));
			products.Add(new Product("broccoli", 20 , 75, "Cruciferous"));
			products.Add(new Product("garlic", 30 , 20, "Leafy green"));
			products.Add(new Product("silverbeet", 10 , 50, "Marrow"));

			//----------------------------------Question 1 a-------------------------------------//

			Console.WriteLine("-------------------------------------------------------------------");
			Console.WriteLine("Total number of Products in list = " + products.Count );
			products.Add(new Product("Potato", 10, 50, "Root"));




			//----------------------------------Question 1 b-------------------------------------//

			Console.WriteLine("-------------------------------------------------------------------");
			Console.WriteLine("Products which are leafy green are :");
			foreach (Product p in products)
			{
				if (p.type == "Leafy green")
				{
					Console.WriteLine(p.display());
				}
			}


			//----------------------------------Question 1 c-------------------------------------//

			Console.WriteLine("-------------------------------------------------------------------");
			products.RemoveAt(8);
			Console.WriteLine("After removing Garlic, number of products in list:" + products.Count);




			//----------------------------------Question 1 d-------------------------------------//

			Console.WriteLine("-------------------------------------------------------------------");

			var c = products.Find(x => x.name == "cabbage");
			c.quantity += 50;
			products.Insert(1, c);
			Console.WriteLine("After changing quantity of cabbages:" + products.ElementAt(1).quantity);




			//----------------------------------Question 1 c-------------------------------------//

			Console.WriteLine("-------------------------------------------------------------------");
			double round_amount = 0;
			var lettuce = products.Find(x => x.name == "lettuce");
			round_amount += lettuce.price * 1;
			var zucchini = products.Find(x => x.name == "lettuce");
			round_amount += zucchini.price * 2;
			var broccoli = products.Find(x => x.name == "lettuce");
			round_amount += broccoli.price * 1;
			Console.WriteLine("After buying 1kg lettuce, 2kg zucchini and 1 kg broccoli, user has to pay : Rs." + round_amount);


		}

	}
		class Product
		{
			public string name { get; set; }
			public double price { get; set; }
			public int quantity { get; set; }
			public string type { get; set; }
			public Product(string n, double p, int q, string t)
			{
				name = n;
				price = p;
				quantity = q;
				type = t;

			}
			public string display()
			{
				return "Name: " + name + " Quantiy: " + quantity + " Price: Rs." + price + " Type: " + type;
			}
		}
}
