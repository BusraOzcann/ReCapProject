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
            UsersTest();
            CustomerTest();
            RentalTest();
        }

        private static void BrandTest()
        {
            Console.WriteLine("Veritabanındaki bütün araba markaları");
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandId + " / " + brand.BrandName);
            }
            Console.WriteLine("------------------------------------");
        }

        private static void ColorTest()
        {
            Console.WriteLine("Veritabanındaki bütün renkler");
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorId + " / " + color.ColorName);
            }
            Console.WriteLine("------------------------------------");
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine("Bütün arabalar!");
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("------------------------------------");

            Console.WriteLine("2000 yılından önceki arabalar!");
            foreach (var car in carManager.GetCarsBefore2000().Data)
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("------------------------------------");
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Console.WriteLine("Bütün kiralık arabalar");
            foreach (var rental in rentalManager.GetAll().Data)
            {
                Console.WriteLine(rental.Id + " / " + rental.CustomerId);
            }
            Console.WriteLine("------------------------------------");
        }

        private static void UsersTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            Console.WriteLine("Bütün kullanıcılar");
            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.Id + " / " + user.FirstName);
            }
            Console.WriteLine("------------------------------------");
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Console.WriteLine("Bütün müşteriler");
            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(customer.Id + " / " + customer.CompanyName);
            }
            Console.WriteLine("------------------------------------");
        }
    }
}
