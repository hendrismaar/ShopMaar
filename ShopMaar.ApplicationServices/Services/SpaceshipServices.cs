﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopMaar.Core.Domain.Spaceship;
using ShopMaar.Core.Dto;
using ShopMaar.Core.ServiceInterface;
using ShopMaar.Data;

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
                    Dimensions = dto.Dimensions,
                    PassengerCount = dto.PassengerCount,
                    CrewCount = dto.CrewCount,
                    CargoWeight = dto.CargoWeight,
                    MaxSpeedInVacuum = dto.MaxSpeedInVaccuum,
                    BuiltAtDate = dto.BuiltAtDate,
                    MaidenLaunch = dto.MaidenLaunch,
                    Manufacturer = dto.Manufacturer,
                    IsSpaceShipPerviouslyOwned = dto.IsSpaceshipPreviouslyOwned,
                    FullTripsCount = dto.FullTripsCount,
                    Type = dto.Type,
                    EnginePower = dto.EnginePower,
                    FuelConsumptionPerDay = dto.FuelConsumptionPerDay,
                    MaintenanceCount = dto.MaintenanceCount,
                    LastMaintenance = dto.LastMaintenance,
                    CreatedAt = dto.CreatedAt,
                    ModifiedAt = dto.ModifiedAt,
                };
                await _context.spaceships.AddAsync(domain);
                await _context.SaveChangesAsync();
                return domain;
            }
        }
    }