using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Update(new Car { Id = 2, BrandId = 2, ColorId = 2, CarName = "C 180 AMG", ModelYear = 2018, DailyPrice = 1000, Description = "Aylık kiralama için günlük fiyattır." });
            //carManager.Add(new Car { BrandId = 2, ColorId = 2, CarName = "MERCEDES-BENZ C 180 AMG", ModelYear = 2018, DailyPrice = 0, Description = "Aylık kiralama için günlük fiyattır." });

            //MERCEDES-BENZ C 180 AMG
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand { BrandName = "MERCEDES-BENZ" });

            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Update(new Color { Id = 3, ColorName = "GRI"});

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Marka-Model: {0} - {1} / Renk: {2} / Fiyat: {3}", car.BrandName, car.CarName, car.ColorName, car.DailyPrice);
            }
        }
    }
}
