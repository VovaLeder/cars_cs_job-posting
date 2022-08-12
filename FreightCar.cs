namespace Cars
{
    public  class FreightCar : Car
    {
        /// <summary>
        /// How many a car can carry in kg
        /// </summary>
        public float loadCapacity { get; private set; }

        /// <summary>
        /// How many a car carries now in kg
        /// </summary>
        public float cargoWeight { get; private set; }

        public FreightCar(float afc, float ftv, float speed, float loadCapacity)
        {
            carType = CarType.FreightCar;

            this.afc = afc;
            this.ftv = ftv;
            this.speed = speed;
            this.loadCapacity = loadCapacity;
        }

        /// <summary>
        /// Adds a <b>cargoWeight</b> kg of cargo to the car
        /// </summary>
        /// <returns><b>True</b> if there's enough space for cargo. <b>False</b> otherwise</returns>
        public bool addCargo(float cargoWeight)
        {
            if (this.cargoWeight + cargoWeight < loadCapacity)
            {
                this.cargoWeight += cargoWeight;
                return true;
            }
            return false;
        }

        public override float travelLength()
        {
            return base.travelLength() * (1 - .0002f * cargoWeight);
        }

        public override float travelLength(float fuelLevel)
        {
            return base.travelLength(fuelLevel) * (1 - .0002f * cargoWeight);
        }
    }
}
