using System;
using ViolationBasicPrinciples;

namespace RepaireService
{
    class Program
    {
        static void Main(string[] args)
        {
            MotorbikeService motorbikeService = new MotorbikeService();
            Enduro enduro = new Enduro("Honda", "X250");
            RacingBike racingBike = new RacingBike("Kawasaki", "H2R");
            Chopper chopper = new Chopper("Boulevard", "C90");

            motorbikeService.CalculateCompetitionCounter(enduro);
            motorbikeService.CalculateCompetitionCounter(racingBike);
            motorbikeService.CalculateCompetitionCounter(chopper);

            foreach (var motorBike in motorbikeService.GetAll())
            {
                if (motorBike is Chopper bike)
                {
                    Console.WriteLine(bike.Distance); 
                }

                if (motorBike is Enduro bike2)
                {
                    Console.WriteLine(bike2.Distance);
                }

                if (motorBike is RacingBike bike1)
                {
                    Console.WriteLine(bike1.Distance);
                }
            }

            Console.ReadLine();
        }
    }
}
