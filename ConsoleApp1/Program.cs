using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
            ColorTest();
            BrandTest();

        }

        private static void BrandTest()
        {
            Console.WriteLine("Veritabanındaki bütün araba markaları");
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandId + " / " + brand.BrandName);
            }
            Console.WriteLine("------------------------------------");
        }

        private static void ColorTest()
        {
            Console.WriteLine("Veritabanındaki bütün renkler");
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorId + " / " + color.ColorName);
            }
            Console.WriteLine("------------------------------------");
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine("Bütün arabalar!");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("------------------------------------");

            Console.WriteLine("2000 yılından önceki arabalar!");
            foreach (var car in carManager.GetCarsBefore2000())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("------------------------------------");
        }
    }
}
