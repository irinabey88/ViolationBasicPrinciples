﻿using System;
using ViolationBasicPrinciples.Interfaces;

namespace ViolationBasicPrinciples
{
    public class Enduro : IMotroBike
    {
        private double _distance;

        private int _competitionCounter;

        public string Name;

        public string Model;

        public double StayingQuality;

        public double Distance
        {
            get => _distance;
            set
            {
                _distance = value;
                StayingQuality = _distance / 100000 + 1;
            }
        }

        public Enduro(string name, string model)
        {
            Name = name;
            Model = model;
        }

        public void PrintPaymentSlip(string paymentData)
        {
            Console.WriteLine(paymentData);
        }

        public double RideByDay(double speed, double hours)
        {
            Distance += speed * hours;
            return speed * hours;
        }

        public double RideByYear(double speed, double hours)
        {
            Distance += speed * hours;
            return speed * hours;
        }

        public double GetTotalDistance()
        {
            return Distance;
        }

        public double Calculate()
        {
            return StayingQuality;
        }

        public int CalculateCompetitionCounter()
        {
            Distance += 20;
            _competitionCounter++;

            return _competitionCounter;
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