
namespace DesignPatterns.Behavioral.Strategy.OrderProcessing
{
    public interface IOrder
    {
        // this is returning the total amount of the order for demo purposes
        decimal Process(ICalculateTax taxCalculator);
    }

    public interface ICalculateTax
    {
        decimal TaxAmount(long itemSold, decimal price, bool isFood);
    }
}
