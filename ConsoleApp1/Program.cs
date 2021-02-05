using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Console.WriteLine("Bütün arabalar!");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("2000 yılından önceki arabalar!");
            foreach (var car in carManager.GetCarsBefore2000())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
