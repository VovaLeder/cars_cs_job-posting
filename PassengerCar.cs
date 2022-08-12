namespace Cars
{
    public  class PassengerCar : Car
    {

        public int numberOfPassengers { get; private set; }

        public PassengerCar(float afc, float ftv, float speed)
        {
            carType = CarType.PassengerCar;

            this.afc = afc;
            this.ftv = ftv;
            this.speed = speed;
        }

        /// <summary>
        /// Adds a passenger to the car
        /// </summary>
        /// <returns><b>True</b> if there's enough space for the passenger. <b>False</b> otherwise</returns>
        public bool addPassenger()
        {
            if (numberOfPassengers < 3)
            {
                numberOfPassengers++;
                return true;
            }
            return false;
        }

        public override float travelLength()
        {
            return base.travelLength() * (1 - .06f * numberOfPassengers);
        }

        public override float travelLength(float fuelLevel)
        {
            return base.travelLength(fuelLevel) * (1 - .06f * numberOfPassengers);
        }
    }
}
