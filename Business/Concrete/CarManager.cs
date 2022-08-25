using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
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
            if (car.CarName.Length < 2)
            {
                Console.WriteLine("Araba ismi minimum 2 karakter olmalıdır.");
            }
            else if (car.DailyPrice <= 0)
            {
                Console.WriteLine("Araba fiyatı 0'dan büyük olmalıdır.");
            }
            else
            {
                _carDal.Add(car);
                Console.WriteLine("Araba Eklendi.");
            }
            
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int carId)
        {
            return _carDal.Get(c => c.Id == carId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public void Update(Car car)
        {
            if (car.CarName.Length < 2)
            {
                Console.WriteLine("Araba ismi minimum 2 karakter olmalıdır.");
            }
            else if (car.DailyPrice <= 0)
            {
                Console.WriteLine("Araba fiyatı 0'dan büyük olmalıdır.");
            }
            else
            {
                _carDal.Update(car);
                Console.WriteLine("Araba Güncellendi.");
            }            
        }
    }
}
