namespace DesignPatternsInCSharp.Behavioral
{
    /*
        Strategy is a behavioral design pattern that lets you define a family of algorithms, 
        put each of them into a separate class, and make their objects interchangeable.
    */

    // Strategy Interface
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }
    // Concrete Strategy 1
    public class UPIPaymentStrategy : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using UPI.");
        }
    }
    // Concrete Strategy 2
    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using Credit Card.");
        }
    }
    // Context
    public sealed class ShoppingCart(IPaymentStrategy? paymentStrategy = null)
    {
        private IPaymentStrategy? _paymentStrategy = paymentStrategy;

        public void Checkout(decimal amount)
        {
            if (_paymentStrategy == null)
            {
                Console.WriteLine($"No Payment Strategy Detected.");
                return;
            }
            _paymentStrategy.Pay(amount);
        }


    }
}