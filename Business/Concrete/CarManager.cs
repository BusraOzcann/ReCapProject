using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length>2 && car.DailyPrice>0)
            {
                _carDal.Add(car);
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsBefore2000()
        {
            var result = _carDal.GetAll().Where(c => c.ModelYear < 2000).ToList();
            return result;
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll().Where(p => p.BrandId == brandId).ToList();
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll().Where(p => p.ColorId == colorId).ToList();
        }
    }
}
