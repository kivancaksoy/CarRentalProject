using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car { Id = 1, BrandId = 1, ColorId = 1, CarName = "BMW 5.20", ModelYear = 2019, DailyPrice = 1500, Description = "Aylık kiralama için günlük fiyattır." },
                new Car { Id = 2, BrandId = 4, ColorId = 2, CarName = "Peugeot 301", ModelYear = 2018, DailyPrice = 250, Description = "Yıllık kiralama için günlük fiyattır." },
                new Car { Id = 3, BrandId = 3, ColorId = 2, CarName = "Volkswagen Passat", ModelYear = 2020, DailyPrice = 500, Description = "Günlük kiralama için günlük fiyattır." },
                new Car { Id = 4, BrandId = 5, ColorId = 3, CarName = "Fiat Linea", ModelYear = 2018, DailyPrice = 200, Description = "Günlük kiralama için günlük fiyattır." },
                new Car { Id = 5, BrandId = 2, ColorId = 2, CarName = "MERCEDES-BENZ GLB 200 AMG", ModelYear = 2022, DailyPrice = 2500, Description = "Aylık kiralama için günlük fiyattır." },
                new Car { Id = 6, BrandId = 1, ColorId = 4, CarName = "BMW 2.16", ModelYear = 2020, DailyPrice = 1450, Description = "Yıllık kiralama için günlük fiyattır." },
                new Car { Id = 7, BrandId = 2, ColorId = 5, CarName = "MERCEDES-BENZ CLA 200 AMG", ModelYear = 2021, DailyPrice = 1750, Description = "Yıllık kiralama için günlük fiyattır." }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int carId)
        {
            var result = _cars.FirstOrDefault(c => c.Id == carId);
            return result;
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.First(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.CarName = car.CarName;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
