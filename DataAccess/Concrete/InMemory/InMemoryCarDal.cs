using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{CarId = 1, BrandId=1, ColorId=2,DailyPrice=3000, ModelYear=2015, Description = "Araba1"},
                new Car{CarId = 2, BrandId=1, ColorId=4,DailyPrice=1500, ModelYear=1999, Description = "Araba2"},
                new Car{CarId = 3, BrandId=1, ColorId=1,DailyPrice=3500, ModelYear=2018, Description = "Araba3"},
                new Car{CarId = 4, BrandId=1, ColorId=3,DailyPrice=1000, ModelYear=1995, Description = "Araba4"},
                new Car{CarId = 5, BrandId=1, ColorId=1,DailyPrice=1900, ModelYear=2005, Description = "Araba5"},
                new Car{CarId = 6, BrandId=1, ColorId=5,DailyPrice=2600, ModelYear=2011, Description = "Araba6"},
                new Car{CarId = 7, BrandId=1, ColorId=2,DailyPrice=3300, ModelYear=2016, Description = "Araba7"},
            };
        }


        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            var deleted = _car.SingleOrDefault(c => c.CarId == car.CarId);
            _car.Remove(deleted);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int Id)
        {
            return _car.SingleOrDefault(c => c.CarId == Id);
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car updatedCar = _car.SingleOrDefault(c => c.CarId == car.CarId);
            updatedCar.BrandId = car.BrandId;
            updatedCar.ColorId = car.ColorId;
            updatedCar.DailyPrice = car.DailyPrice;
            updatedCar.Description = car.Description;
        }
    }
}
