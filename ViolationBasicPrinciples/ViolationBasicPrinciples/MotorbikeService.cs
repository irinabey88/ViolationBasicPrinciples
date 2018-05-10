using System.Collections.Generic;

namespace ViolationBasicPrinciples
{
    public class MotorbikeService
    {
        private List<object> _motorbikes;

        public MotorbikeService()
        {
            _motorbikes = new List<object>();
        }

        public void PrintPaymentSlip(object obj, string paymentSlip)
        {
            if (!_motorbikes.Contains(obj))
            {
                _motorbikes.Add(obj);
            }

            if (obj is Chopper bike1)
            {
                bike1.PrintPaymentSlip(paymentSlip);
            }
            else if(obj is Enduro bike2)
            {
                bike2.PrintPaymentSlip(paymentSlip);
            }
            else if (obj is RacingBike bike)
            {
                bike.PrintPaymentSlip(paymentSlip);
            }
        }

        public double Calculate(object obj)
        {
            if (!_motorbikes.Contains(obj))
            {
                _motorbikes.Add(obj);
            }

            if (obj is Chopper bike)
            {
                return bike.Calculate();
            }

            if (obj is Enduro bike2)
            {
                return bike2.Calculate();
            }

            if (obj is RacingBike bike1)
            {
                return bike1.Calculate();
            }

            return 0;
        }

        public double RideByDay(object obj, double speed, double hours)
        {
            if (!_motorbikes.Contains(obj))
            {
                _motorbikes.Add(obj);
            }

            if (obj is Chopper bike)
            {
                return bike.RideByDay(speed, hours);
            }

            if (obj is Enduro bike2)
            {
                return bike2.RideByDay(speed, hours);
            }

            if (obj is RacingBike bike1)
            {
                return bike1.RideByDay(speed, hours);
            }

            return 0;
        }

        public double RideByYear(object obj, double speed, double hours)
        {
            if (!_motorbikes.Contains(obj))
            {
                _motorbikes.Add(obj);
            }

            if (obj is Chopper bike)
            {
                return bike.RideByDay(speed, hours);
            }

            if (obj is Enduro bike2)
            {
                return bike2.RideByDay(speed, hours);
            }

            if (obj is RacingBike bike1)
            {
                return bike1.RideByDay(speed, hours);
            }

            return 0;
        }

        public double GetTotalDistance(object obj)
        {
            if (!_motorbikes.Contains(obj))
            {
                _motorbikes.Add(obj);
            }

            if (obj is Chopper bike)
            {
                return bike.GetTotalDistance();
            }

            if (obj is Enduro bike2)
            {
                return bike2.GetTotalDistance();
            }

            if (obj is RacingBike bike1)
            {
                return bike1.GetTotalDistance();
            }

            return 0;
        }

        public double CalcServiceBill(object obj, params double[] priceList)
        {
            if (!_motorbikes.Contains(obj))
            {
                _motorbikes.Add(obj);
            }

            if (obj is Chopper bike)
            {
                return bike.CalcServiceBill(priceList);
            }

            if (obj is Enduro bike2)
            {
                return bike2.CalcServiceBill(priceList);
            }

            if (obj is RacingBike bike1)
            {
                return bike1.CalcServiceBill(priceList);
            }

            return 0;
        }

        public int CalculateCompetitionCounter(object obj)
        {
            if (!_motorbikes.Contains(obj))
            {
                _motorbikes.Add(obj);
            }

            if (obj is Chopper bike)
            {
                return bike.CalculateCompetitionCounter();
            }

            if (obj is Enduro bike2)
            {
                return bike2.CalculateCompetitionCounter();
            }

            if (obj is RacingBike bike1)
            {
                return bike1.CalculateCompetitionCounter();
            }

            return 0;
        }

        public IEnumerable<object> GetAll()
        {
            return this._motorbikes;
        }
    }
}