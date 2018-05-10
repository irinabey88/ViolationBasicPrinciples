namespace ViolationBasicPrinciples.Interfaces
{
    public interface IMotroBike
    {
        double CalcServiceBill(params double[] priceList);

        double RideByDay(double speed, double hours);

        double RideByYear(double speed, double hours);

        double GetTotalDistance();

        void PrintPaymentSlip(string paymentData);

        double Calculate();

        int CalculateCompetitionCounter();
    }
}