using Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using Entities.Concrete;
using System.Text;
using System.Linq;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int colorId)
        {
            return _colorDal.GetAll().SingleOrDefault(c => c.ColorId == colorId);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
        }
    }
}
