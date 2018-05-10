using System;
using ViolationBasicPrinciples.Interfaces;

namespace ViolationBasicPrinciples
{
    public class Chopper : IMotroBike
    {
        private double _distance;

        public string Name;

        public string Model;

        public double Distance
        {
            get => _distance;
            set
            {
                _distance = value;
                StayingQuality = _distance / 10 + 1;
            }
        }

        public double StayingQuality;

        public Chopper(string name, string model)
        {
            Name = name;
            Model = model;
        }

        public void PrintPaymentSlip(string paymentData)
        {
            Console.WriteLine(paymentData);
        }       

        public double Calculate()
        {
            return StayingQuality;
        }

        /// <summary>
        /// Doesn't take part in any competition
        /// </summary>
        /// <returns>Default int value</returns>
        public int CalculateCompetitionCounter()
        {
            return 0;
        }

        public double RideByDay(double speed, double hours)
        {
            return speed * hours;
        }

        public double RideByYear(double speed, double hours)
        {
            return speed * hours;
        }

        public double GetTotalDistance()
        {
            return this.Distance;
        }

        public double CalcServiceBill(params double[] priceList)
        {
            double sum = 0;

            foreach (var price in priceList)
            {
                sum += price;
            }

            return sum;
        }
    }
}
