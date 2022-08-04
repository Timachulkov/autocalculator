using autocalculator;
namespace AutoCalculatroTest
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void Car_RealVehicleRange()
        {
            float fuelConsumption = 5.8f;
            int maxPassengers = 4;
            int fuelTankVolumeNew = 100;
            PassengerCar car = new PassengerCar(fuelConsumption, maxPassengers, fuelTankVolumeNew);
            
        }
    }
}