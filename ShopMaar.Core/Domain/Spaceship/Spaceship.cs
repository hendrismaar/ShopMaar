﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMaar.Core.Domain.Spaceship
{
    public class Spaceship
    {
        [Key]
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public ICollection<Dimension> Dimensions { get; set; } 
        public int PassengerCount { get; set; }
        public int CrewCount { get; set; }
        public int CargoWeight { get; set; }
        public int MaxSpeedInVacuum { get; set; }
        public DateTime BuiltAtDate { get; set; }
        public DateTime MaidenLaunch { get; set; }
        public string Manufacturer { get; set; }
        public bool IsSpaceShipPreviouslyOwned { get; set; }
        public int FullTripsCount { get; set; }
        public string Type { get; set; }
        public int EnginePower { get; set; }
        public int FuelConsumptionPerDay { get; set; }
        public int MaintenanceCount { get; set; }
        public DateTime LastMaintenance { get; set; }

        // only in db

        public DateTime CreatedAt { get; set;}
        public DateTime ModifiedAt { get; set; } 
    }
    //public class Dimension
    //{
    //    [Key]
    //    public int DimensionID { get; set; }
    //    public int Width { get; set; }
    //    public int Height { get; set; }
    //    public int Depth { get; set; }
    //}
}
