﻿using TMS.Domain.Entites;
using TMS.Domain.Entites.Enums;
using TMS.Domain.ValueObjects;

public class VehicleTest
{
    public string Name { get; private set; }
    public VehicleRegistrationPlateVO VehicleRegistrationPlate { get; private set; }
    
    [Fact]
    public void Should_Vehicle_Register_ResultOK()
    {
        var name = "Carreta";
        VehicleRegistrationPlateVO vehicleRegistrationPlate = new VehicleRegistrationPlateVO("ABC-123");


        var vehicle = new Vehicle(name, vehicleRegistrationPlate);
        Assert.Equal(name, vehicle.Name);
        Assert.Equal(vehicleRegistrationPlate, vehicle.VehicleRegistrationPlate);
    }
}

