using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using productTree;
using customerTree;

namespace InetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите имя");
            string nameOfCustomer = Console.ReadLine();
            Customer client1 = new Customer(nameOfCustomer);
            Basket newBasket = new Basket(client1);
            
            var prod1 = new SportProduct("мяч", 5, 100, "мяч обыкновенный", 0, 3);
            var prod2 = new SportProduct("Лыжи", 40.4m, 105, "Лыж обыкновенный", 180, 3);
            var prod3 = new SportProduct("мяч футбольный", 15, 101, "мяч футбольный", 0, 3);
            var prod4 = new SportProduct("мяч баскетбольный", 15, 102, "мяч баскетбольный", 0, 3);
            var prod5 = new SportProduct("Гантели", 10, 120, "гантели 5кг", 0, 5);

            var prod6 = new AppliancesProduct ("Утюг", 50, 200, 500, "Утюг маленький");
            var prod7 = new AppliancesProduct("светильник", 60, 220, 80, "светильник невысокий");
            var prod8 = new AppliancesProduct("телевизор", 500, 250, 400, "телевизор старый");

            newBasket.Add(prod8, prod5);


            Catalog appliancesCatalog = new Catalog();
            appliancesCatalog.AddProd(prod6, prod7, prod8);
            

            Catalog sportCatalog = new Catalog();
            sportCatalog.AddProd(prod1, prod2, prod3, prod4, prod5);

            Console.WriteLine(prod1 == prod2);
            Console.WriteLine(prod3 == prod4);

            Console.WriteLine(prod6 > prod7);
            Console.WriteLine(prod1 < prod8);
            
            appliancesCatalog.RemoveProd(250);

            foreach (var item in appliancesCatalog)
            {
                Console.WriteLine($"{item}\n");
            }

            Console.ReadKey();

        }
    }
}
