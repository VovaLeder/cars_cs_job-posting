namespace Cars
{
    public abstract class Car
    {
        /// <summary>
        /// Type of car
        /// </summary>
        public CarType carType { get; protected set; }

        /// <summary>
        /// Average fuel consumption (liters per kilometers)
        /// </summary>
        public float afc { get; protected set; }

        /// <summary>
        /// Fuel tank volume (liters)
        /// </summary>
        public float ftv { get; protected set; }

        /// <summary>
        /// Average speed of car in kilometers per hour
        /// </summary>
        public float speed { get; protected set; }

        /// <summary>
        /// Returns how far a car can travel with a full tank of fuel
        /// </summary>
        /// <returns>Kilometers in <i>float</i></returns>
        public virtual float travelLength()
        {
            return ftv / afc;
        }

        /// <summary>
        /// Returns how far a car can travel with <b>fuelLevel</b> liters of fuel
        /// </summary>
        /// <returns>Kilometers in <i>float</i></returns>
        public virtual float travelLength(float fuelLevel)
        {
            return fuelLevel / afc;
        }

        /// <summary>
        /// Returns how long a car will travel with <b>fuelLevel</b> liters of fuel
        /// </summary>
        /// <returns>Hours in <i>float</i></returns>
        public float travelTimeByFuelLevel(float fuelLevel)
        {
            return travelLength(fuelLevel) / speed;
        }

        /// <summary>
        /// Returns how long a car will travel <b>lenght</b> kilometers
        /// </summary>
        /// <returns>Hours in <i>float</i></returns>
        public float travelTimeByLength(float length)
        {
            return length / speed;
        }
    }
}