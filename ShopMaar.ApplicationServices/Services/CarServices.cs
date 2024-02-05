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
                .FirstOrDefaultAsync(x => x.Id == id);
            _context.Cars.Remove(carId);
            await _context.SaveChangesAsync();
            return carId;
        }
        public async Task<Car> Update(CarDto dto)
        {
            var domain = new Car()
            {
                Id = Guid.NewGuid(),
                Brand = dto.Brand,
                Model = dto.Model,
                Price = dto.Price,
                Description = dto.Description,
                GearShiftType = dto.GearShiftType,
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now,
            };
            _context.Cars.Update(domain);
            await _context.SaveChangesAsync();
            return domain;
        }
        public async Task<Car> GetAsync(Guid id)
        {
            var result = await _context.Cars
                .FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }
    }
}