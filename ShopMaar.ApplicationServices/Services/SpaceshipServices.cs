﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ShopMaar.Core.Domain.Spaceship;
using ShopMaar.Core.Dto;
using ShopMaar.Core.ServiceInterface;
using ShopMaar.Data;
using Microsoft.EntityFrameworkCore;

namespace ShopMaar.ApplicationServices.Services
{
        public class SpaceshipsServices : ISpaceshipsServices
        {
            private readonly ShopMaarContext _context;
            public SpaceshipsServices(ShopMaarContext context)
            {
                _context = context;
            }

            public async Task<Spaceship> Add(SpaceshipDto dto)
            {
                var domain = new Spaceship()
                {
                    Name = dto.Name,
                    Description = dto.Description,
                    //Dimensions = dto.Dimensions,
                    PassengerCount = dto.PassengerCount,
                    CrewCount = dto.CrewCount,
                    CargoWeight = dto.CargoWeight,
                    MaxSpeedInVacuum = dto.MaxSpeedInVaccuum,
                    BuiltAtDate = dto.BuiltAtDate,
                    MaidenLaunch = dto.MaidenLaunch,
                    Manufacturer = dto.Manufacturer,
                    IsSpaceShipPreviouslyOwned = dto.IsSpaceshipPreviouslyOwned,
                    FullTripsCount = dto.FullTripsCount,
                    Type = dto.Type,
                    EnginePower = dto.EnginePower,
                    FuelConsumptionPerDay = dto.FuelConsumptionPerDay,
                    MaintenanceCount = dto.MaintenanceCount,
                    LastMaintenance = dto.LastMaintenance,
                    CreatedAt = dto.CreatedAt,
                    ModifiedAt = dto.ModifiedAt,
                };
                await _context.Spaceships.AddAsync(domain);
                await _context.SaveChangesAsync();
                return domain;
            }

        public async Task<Spaceship> Update(SpaceshipDto dto)
        {
            var domain = new Spaceship()
            {
                Name = dto.Name,
                Description = dto.Description,
                //Dimensions = dto.Dimensions,
                PassengerCount = dto.PassengerCount,
                CrewCount = dto.CrewCount,
                CargoWeight = dto.CargoWeight,
                MaxSpeedInVacuum = dto.MaxSpeedInVaccuum,
                BuiltAtDate = dto.BuiltAtDate,
                MaidenLaunch = dto.MaidenLaunch,
                Manufacturer = dto.Manufacturer,
                IsSpaceShipPreviouslyOwned = dto.IsSpaceshipPreviouslyOwned,
                FullTripsCount = dto.FullTripsCount,
                Type = dto.Type,
                EnginePower = dto.EnginePower,
                FuelConsumptionPerDay = dto.FuelConsumptionPerDay,
                MaintenanceCount = dto.MaintenanceCount,
                LastMaintenance = dto.LastMaintenance,
                CreatedAt = dto.CreatedAt,
                ModifiedAt = DateTime.Now,
            };
            _context.Spaceships.Update(domain);
            await _context.SaveChangesAsync();
            return domain;
        }
        public async Task<Spaceship> GetUpdate(Guid id)
        {
            var result = await _context.Spaceships
                .FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }
    }
    }