using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using ShopMaar.Core.Domain;
using ShopMaar.Core.Dto;
using ShopMaar.Core.ServiceInterface;
using ShopMaar.Data;

namespace ShopMaar.ApplicationServices.Services
{
    public class CarServices : ICarServices
    {
        private readonly ShopMaarContext _context;
        private readonly IFilesServices _fileServices;

        public CarServices(ShopMaarContext context, IFilesServices fileServices)
        {
            _context = context;
            _fileServices = fileServices;
        }

        public async Task<Car> Create(CarDto dto)
        {
            Car car = new();

            car.Id = Guid.NewGuid();
            car.Brand = dto.Brand;
            car.Model = dto.Model;
            car.Price = dto.Price;
            car.Description = dto.Description;
            car.GearShiftType = dto.GearShiftType;
            car.CreatedAt = DateTime.Now;
            car.ModifiedAt = DateTime.Now;
            _fileServices.FilesToApi(dto, car);

            await _context.Cars.AddAsync(car);
            await _context.SaveChangesAsync();
            return car;
        }
        public async Task<Car> Delete(Guid id)
        {
            var carId = await _context.Cars
                .Include(x => x.FilesToApi)
                .FirstOrDefaultAsync(x => x.Id == id);
            var images = await _context.FilesToApi
                .Where(x => x.CarId == id)
                .Select(y => new FileToApiDto
                {
                    Id = y.Id,
                    RealEstateId = y.CarId,
                    ExistingFilePath = y.ExistingFilePath
                }).ToArrayAsync();
            await _fileServices.RemoveImagesFromApi(images);
            _context.Cars.Remove(carId);
            await _context.SaveChangesAsync();
            return carId;
        }
        public async Task<Car> Update(CarDto dto)
        {
            Car car = new Car();

            car.Id = (Guid)dto.Id;
            car.Brand = dto.Brand;
            car.Model = dto.Model;
            car.Price = dto.Price;
            car.Description = dto.Description;
            car.GearShiftType = dto.GearShiftType;
            car.CreatedAt = dto.CreatedAt;
            car.ModifiedAt = DateTime.Now;
            _fileServices.FilesToApi(dto, car);

            _context.Cars.Update(car);

            await _context.SaveChangesAsync();
            return car;
        }
        public async Task<Car> GetAsync(Guid id)
        {
            var result = await _context.Cars
                .FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }
    }
}