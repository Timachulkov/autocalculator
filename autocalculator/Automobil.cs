namespace autocalculator
{
    public abstract class Automobil
    {
        protected string typeTc = "";
        protected int speed; //km/h
        protected int fuelTankVolume;
        protected float fuelConsumption;
        protected float fuel;
        public float VehicleRange() => (fuel/fuelConsumption)*100;
        public float VehicleFuelUse(int lengh) => (fuelConsumption * (lengh/100));
        public abstract float RealVehicleRange();
        public bool ChangeFuel(int fuelNew)
        {
            if (fuelNew <= fuelTankVolume)
            {
                fuel = fuelNew;
                return true;
            }
            return false;
        }
    }

    public class PassengerCar : Automobil
    {
        int maxPassengers;
        int passengers;

        public PassengerCar(float fuelConsumptionNew, int maxPassengersNew, int fuelTankVolumeNew)
        {
            fuelConsumption = fuelConsumptionNew;
            maxPassengers = maxPassengersNew;
            fuelTankVolume = fuelTankVolumeNew;
            typeTc = "Car";
        }
        public override float RealVehicleRange() => VehicleRange() - (VehicleRange() * (0.06f * passengers));
        public bool ChangeNumPassengers(int passengersNew)
        {
            if (passengersNew <= maxPassengers)
            {
                passengers = passengersNew;
                return true;
            }
            return false;
        }
    }
    public class Truck : Automobil
    {
        int loadCapacity;
        int load;

        public Truck(float fuelConsumptionNew, int loadCapacityNew, int fuelTankVolumeNew)
        {
            fuelConsumption = fuelConsumptionNew;
            loadCapacity = loadCapacityNew;
            fuelTankVolume = fuelTankVolumeNew;
            typeTc ="Truck";
        }
        public override float RealVehicleRange() => VehicleRange() - (VehicleRange() * (0.04f * (load / 200)));
        public bool Changeload(int newLoad)
        {
            if (newLoad <= loadCapacity)
            {
                load = newLoad;
                return true;
            }
            return false;
        }
    }
    public class SportCar : Automobil
    {
        public SportCar(float fuelConsumptionNew, int fuelTankVolumeNew)
        {
            fuelConsumption = fuelConsumptionNew;
            fuelTankVolume = fuelTankVolumeNew;
            typeTc = "SportCar";
        }
        public override float RealVehicleRange() => VehicleRange();
    }
}

