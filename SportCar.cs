namespace Cars
{
    public  class SportCar : Car
    {

        public SportCar(float afc, float ftv, float speed)
        {
            carType = CarType.SportCar;

            this.afc = afc;
            this.ftv = ftv;
            this.speed = speed;
        }

    }
}
