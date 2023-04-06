using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIniKassa
{
    internal class Program
    {
        static void Main2(string[] args)

        {
            List<Product> korzina = new List<Product>();
            while (true)
            {
                Console.WriteLine("Do you wanna buy smth: Press Y to continue");
                char otvet = Convert.ToChar(Console.ReadLine());
                if (otvet == 'y')
                {


                    Console.WriteLine("In database we have 4 products types: Bakery(1), Drink(2), Meat(3) and Fish(4)");
                    string chosedprdt = Console.ReadLine();


                    if (chosedprdt == ProductType.Fish.ToString())
                    {
                        Console.WriteLine("PLese type a price of fish");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Product Mehsul = new Product(ProductType.Fish, price);

                        Console.WriteLine("Type a name of fish please");
                        string fishname = Console.ReadLine();
                        Mehsul.Name = fishname;
                        korzina.Add(Mehsul);
                    }


                    if (chosedprdt == ProductType.Meat.ToString())
                    {
                        Console.WriteLine("PLese type a price of meat");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Product Mehsul = new Product(ProductType.Meat, price);

                        Console.WriteLine("Type a name of meat please");
                        string meatname = Console.ReadLine();
                        Mehsul.Name = meatname;
                        korzina.Add(Mehsul);
                    }



                    if (chosedprdt == ProductType.Drink.ToString())
                    {
                        Console.WriteLine("PLese type a price of Drink");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Product Mehsul = new Product(ProductType.Drink, price);

                        Console.WriteLine("Type a name of drink please");
                        string drinkname = Console.ReadLine();
                        Mehsul.Name = drinkname;
                        korzina.Add(Mehsul);
                    }


                    if (chosedprdt == ProductType.Bakery.ToString())
                    {
                        Console.WriteLine("PLese type a price of bakery");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Product Mehsul = new Product(ProductType.Bakery, price);

                        Console.WriteLine("Type a name of bakery please");
                        string bakeryname = Console.ReadLine();
                        Mehsul.Name = bakeryname;
                        Mehsul.DiscountPrice = Product.DiscountedPRice(price);
                        korzina.Add(Mehsul);
                    }
                }
                else
                {
                    Console.WriteLine($"Let see what we have: The number of items: {Product.TotalCount}");
                    foreach (Product prd in korzina)
                    {
                        if (prd.Type == ProductType.Bakery)
                        {
                            Console.WriteLine($"YOu have a discount from {prd.Price}  to {prd.DiscountPrice}");
                        }
                        Console.WriteLine($"you have {prd.Type}  adi ile {prd.Name}  with price {prd.Price} and of course the code is {prd.Code}");
                    }



                }
            }








        }
    }

    class Product
    {
        public string Code;
        public string Name;
        public double Price;
        public static int N = 1000;
        public double DiscountPrice;
        public ProductType Type;
        public static int TotalCount;

        public Product(ProductType Tyype, double Pricce)
        {
            Type = Tyype;
            Price = Pricce;
            TotalCount++;
            N++;
            Code = N + Type.ToString().Substring(0, 1);
        }

        public static double DiscountedPRice(double priceee)
        {
            return priceee * 0.9;
        }
    }

    enum ProductType
    {
        Bakery = 1,
        Drink = 2,
        Meat = 3,
        Fish = 4,

    }
}
