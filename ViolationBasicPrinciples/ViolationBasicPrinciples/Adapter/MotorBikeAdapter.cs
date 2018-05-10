namespace ViolationBasicPrinciples.MotorbikeAdapter
{
    public class BikeAdapter
    {
        public object Bike { get; set; }

        public BikeAdapter(object motorbike)
        {
            Bike = motorbike;
        }
    }
}