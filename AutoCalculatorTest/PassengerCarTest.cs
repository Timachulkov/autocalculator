namespace AutoCalculatorTest
{
    [TestClass]
    public class PassengerCarTest
    {
        [TestMethod]
        public void PassengerCar_VehicleFuelUse()
        {
            float fuelConsumption = 6f;
            int maxPassengers = 4;
            int fuelTankVolumeNew = 55;
            int distance = 500;
            float fuelUseExpected = 30;
            PassengerCar car = new PassengerCar(fuelConsumption, maxPassengers, fuelTankVolumeNew);
            float carRange = car.VehicleFuelUse(distance);

            Assert.AreEqual(fuelUseExpected, carRange, 0.001, "Fuel use wrong");
        }
        [TestMethod]
        public void PassengerCar_VehicleRange_FullTank()
        {
            float fuelConsumption = 6f;
            int maxPassengers = 4;
            int fuelTankVolumeNew = 55;
            float carRangeExpected = 916.666666667f;
            PassengerCar car = new PassengerCar(fuelConsumption, maxPassengers, fuelTankVolumeNew);
            car.ChangeFuel(fuelTankVolumeNew);
            float carRange = car.VehicleRange();

            Assert.AreEqual(carRangeExpected, carRange, 0.001, "VehicleRange at fullTank wrong");
        }
        [TestMethod]
        public void PassengerCar_VehicleRange_half()
        {
            float fuelConsumption = 6f;
            int maxPassengers = 4;
            int fuelTankVolumeNew = 55;
            float carRangeExpected = 416.666666667f;
            PassengerCar car = new PassengerCar(fuelConsumption, maxPassengers, fuelTankVolumeNew);
            car.ChangeFuel(25);
            float carRange = car.VehicleRange();

            Assert.AreEqual(carRangeExpected, carRange, 0.001, "VehicleRange at halfTank wrong");
        }
        [TestMethod]
        public void PassengerCar_test_RealVehicleRange_FullTank_AllPassagers()
        {
            float fuelConsumption = 6f;
            int maxPassengers = 4;
            int fuelTankVolumeNew = 55;
            float carRangeExpected = 696.666666667f;
            PassengerCar car = new PassengerCar(fuelConsumption, maxPassengers, fuelTankVolumeNew);
            car.ChangeFuel(fuelTankVolumeNew);
            car.ChangeNumPassengers(maxPassengers);

            float carRange = car.RealVehicleRange();

            Assert.AreEqual(carRangeExpected, carRange, 0.001, "RealVehicleRange wrong");
        }
    }
}