﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Domain.Entites.Enums;
using TMS.Domain.ValueObjects;

namespace TMS.Domain.Entites
{
    public class Vehicle : BaseEntity
    {
        public Vehicle(string name, VehicleRegistrationPlateVO vehicleRegistrationPlate)
        {
            Name = name;
            VehicleRegistrationPlate = vehicleRegistrationPlate;
        }
        public string Name { get; private set; }
        public VehicleRegistrationPlateVO VehicleRegistrationPlate { get; private set; }

        public void UpdateVehicle(string name, VehicleRegistrationPlateVO vehicleRegistrationPlate)
        {
            Name = name;
            VehicleRegistrationPlate = vehicleRegistrationPlate;
        }
    }
}
