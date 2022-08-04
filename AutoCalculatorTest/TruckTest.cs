namespace AutoCalculatorTest
{
    [TestClass]
    public class TruckTest
    {
        [TestMethod]
        public void PassengerCar_test_RealVehicleRange_FullTank_FullLoad()
        {
            float fuelConsumption = 10f;
            int loadCapacity = 1000;
            int fuelTankVolumeNew = 120;
            float carRangeExpected = 960;
            Truck car = new Truck(fuelConsumption, loadCapacity, fuelTankVolumeNew);
            car.ChangeFuel(fuelTankVolumeNew);
            car.Changeload(loadCapacity);

            float carRange = car.RealVehicleRange();

            Assert.AreEqual(carRangeExpected, carRange, 0.001, "RealVehicleRange wrong");
        }
    }
}
